using System.Linq;
using System;

namespace CarManagementApp
{
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

        public bool IsEngineOn => Engine.IsRunning; // Проверка состояния двигателя

        public void StartEngine() => Engine.Start();
        public void StopEngine() => Engine.Stop();

        public void Move(int distance)
        {
            if (!IsEngineOn)
                throw new InvalidOperationException("Двигатель выключен!");

            if (Fuel < (distance * FuelConsumption) / 100)
                throw new InvalidOperationException("Недостаточно топлива!");

            if (Wheels.Any(w => w.Condition == "Сломано"))
                throw new InvalidOperationException("Одно из колес сломано!");

            Mileage += distance;
            Fuel -= (distance * FuelConsumption) / 100;

            // Проверяем на повреждение колес
            if (Mileage % 200 == 0)
            {
                Random random = new Random();
                int brokenWheelIndex = random.Next(Wheels.Length); // Случайное колесо
                Wheels[brokenWheelIndex].Condition = "Сломано"; // Повреждаем его
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
            bool wheelReplaced = false;
            for (int i = 0; i < Wheels.Length; i++)
            {
                if (Wheels[i].Condition == "Сломано")
                {
                    Wheels[i].Replace(); // Заменить сломанное колесо
                    wheelReplaced = true;
                    break;
                }
            }

            if (!wheelReplaced)
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
}
