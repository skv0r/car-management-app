using System.Linq;
using System;

public class Car
{
    public string Name { get; set; }
    public Engine Engine { get; set; }
    public Wheel[] Wheels { get; set; }
    public int Fuel { get; private set; }
    public int FuelTankCapacity { get; private set; }
    public int Mileage { get; private set; } = 0;
    public int FuelConsumption { get; private set; }

    public Car(string name, int horsePower, int fuelConsumption, int fuelTankCapacity)
    {
        Name = name;
        Engine = new Engine { HorsePower = horsePower };
        Wheels = new Wheel[4];
        for (int i = 0; i < 4; i++)
        {
            Wheels[i] = new Wheel();
        }
        FuelConsumption = fuelConsumption;
        FuelTankCapacity = fuelTankCapacity;
        Fuel = FuelTankCapacity; // Заполняем бак до максимума
    }

    public bool IsEngineOn => Engine.Condition == "Включен";

    public void StartEngine()
    {
        if (Engine.Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");
        Engine.Start();
    }

    public void StopEngine()
    {
        if (Engine.Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");
        Engine.Stop();
    }

    public void Move(int distance)
    {
        if (Engine.Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, машина не может двигаться.");

        if (Fuel < (distance * FuelConsumption) / 100)
            throw new InvalidOperationException("Недостаточно топлива!");

        if (Wheels.Any(w => w.Condition == "Сломано"))
            throw new InvalidOperationException("Одно из колес сломано!");

        Mileage += distance;
        Fuel -= (distance * FuelConsumption) / 100;

        // Поломка колеса
        if (Mileage % 200 == 0)
        {
            Random random = new Random();
            int brokenWheelIndex = random.Next(Wheels.Length);
            Wheels[brokenWheelIndex].ChangeCondition("Сломано");
        }

        // Поломка двигателя
        if (Mileage % 1000 == 0)
        {
            Engine.ChangeCondition("Сломано");
        }
    }

    public void Refuel(int amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Заправляемое количество должно быть положительным!");

        Fuel += amount;
        if (Fuel > FuelTankCapacity)
            Fuel = FuelTankCapacity;
    }

    public void ReplaceBrokenWheel()
    {
        for (int i = 0; i < Wheels.Length; i++)
        {
            if (Wheels[i].Condition == "Сломано")
            {
                Wheels[i].ChangeCondition("Новое");
                return;
            }
        }
        throw new InvalidOperationException("Нет сломанных колес для замены.");
    }

    public string GetCarInfo()
    {
        return $"Название: {Name}\n" +
               $"Мощность двигателя: {Engine.HorsePower} л.с.\n" +
               $"Пробег: {Mileage} км\n" +
               $"Топливо: {Fuel}/{FuelTankCapacity} л\n" +
               $"Расход топлива: {FuelConsumption} л/100 км\n" +
               $"Двигатель: {(Engine.Condition == "Сломано" ? "Сломан" : "Работает")}\n" + // Добавлено состояние двигателя
               $"Колеса: {string.Join(", ", Wheels.Select((w, i) => $"Колесо {i + 1}: {w.Condition}"))}";
    }
}
