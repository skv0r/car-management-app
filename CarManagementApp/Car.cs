using CarManagementApp;
using System.Linq;
using System;

public class Car
{
    public string Name { get; set; }
    public Engine Engine { get; set; }
    public Wheel[] Wheels { get; set; }
    public int Fuel { get; private set; } // Текущий уровень топлива (в литрах)
    public int FuelTankCapacity { get; private set; } // Объем бака (в литрах)
    public int Mileage { get; private set; } = 0; // Пробег автомобиля (в километрах)
    public int FuelConsumption { get; private set; } // Расход топлива на 100 км (в литрах)

    public Car(string name, int horsePower, int fuelConsumption, int fuelTankCapacity)
    {
        Name = name;
        Engine = new Engine { HorsePower = horsePower };
        Wheels = new Wheel[4]; // 4 колеса
        for (int i = 0; i < 4; i++)
        {
            Wheels[i] = new Wheel(); // Каждое колесо изначально новое
        }
        FuelConsumption = fuelConsumption;
        FuelTankCapacity = fuelTankCapacity;
        Fuel = FuelTankCapacity; // Заполняем полный бак при создании
    }

    public bool IsEngineOn => Engine.IsRunning;

    public void StartEngine()
    {
        if (!IsEngineOn)
        {
            Engine.Start();
        }
    }

    public void StopEngine()
    {
        if (IsEngineOn)
        {
            Engine.Stop();
        }
    }

    public void Move(int distance)
    {
        if (!IsEngineOn)
            throw new InvalidOperationException("Двигатель выключен!");

        if (Fuel < (distance * FuelConsumption) / 100)
        {
            StopEngine();
            throw new InvalidOperationException("Недостаточно топлива!");
        }

        if (Wheels.Any(w => w.Condition == "Сломано"))
            throw new InvalidOperationException("Одно из колес сломано!");

        Mileage += distance;
        Fuel -= (distance * FuelConsumption) / 100;

        // Логика повреждения колес
        if (Mileage % 200 == 0) // При каждом 200-километровом пробеге случайным образом ломаем одно из колес
        {
            Random random = new Random();
            int brokenWheelIndex = random.Next(Wheels.Length); // Случайный выбор колеса
            Wheels[brokenWheelIndex].Condition = "Сломано";
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
                Wheels[i].Replace();
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
               $"Двигатель: {(IsEngineOn ? "Включен" : "Выключен")}\n" +
               $"Колеса: {string.Join(", ", Wheels.Select((w, i) => $"Колесо {i + 1}: {w.Condition}"))}";
    }
}
