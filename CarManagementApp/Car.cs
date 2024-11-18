using System;
using System.Linq;

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

        // Перегрузка метода Move: стандартное движение
        public void Move(int distance)
        {
            Move(distance, false);  // Перемещение с обычной скоростью
        }

        // Перегрузка метода Move: движение с дополнительными параметрами (например, высокая скорость)
        public void Move(int distance, bool isFast = false)
        {
            if (!IsEngineOn)
            {
                throw new InvalidOperationException("Двигатель выключен! Невозможно передвигаться.");
            }
            if (Engine.Condition == "Сломано")
                throw new InvalidOperationException("Двигатель сломан, машина не может двигаться.");

            if (Fuel < (distance * FuelConsumption) / 100)
                throw new InvalidOperationException("Недостаточно топлива!");

            if (Wheels.Any(w => w.Condition == "Сломано"))
                throw new InvalidOperationException("Одно из колес сломано!");

            Mileage += distance;

            // Высокая скорость: уменьшаем расход топлива
            if (isFast)
            {
                // Например, при высокой скорости расход топлива снижается на 20%
                Fuel -= (int)((distance * FuelConsumption) / 100 * 0.8); // Приведение типа к int

            }
            else
            {
                Fuel -= (distance * FuelConsumption) / 100;
            }

            // Поломка колеса каждые 200 км
            if (Mileage % 200 == 0)
            {
                Random random = new Random();
                int brokenWheelIndex = random.Next(Wheels.Length);
                Wheels[brokenWheelIndex].ChangeCondition("Сломано");
            }

            // Поломка двигателя каждые 1000 км
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
                    Wheels[i].ChangeCondition("Новое"); // Заменить сломанное колесо
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
                   $"Двигатель: {(IsEngineOn ? "Включен" : "Выключен")} ({Engine.Condition})\n" + // Отображение состояния двигателя
                   $"Колеса: {string.Join(", ", Wheels.Select((w, i) => $"Колесо {i + 1}: {w.Condition}"))}";
        }
    }

    public class Engine : Component
    {
        public int HorsePower { get; set; }
        public bool IsRunning { get; private set; } = false;

        public void Start()
        {
            if (Condition == "Сломано")
                throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");
            IsRunning = true;
        }

        public void Stop()
        {
            if (Condition == "Сломано")
                throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");
            IsRunning = false;
        }

        public void ChangeCondition(string condition)
        {
            Condition = condition;
        }
    }

    public class Wheel : Component
    {
        public void Repair()
        {
            if (Condition == "Сломано")
                ChangeCondition("Новое");
            else
                throw new InvalidOperationException("Колесо уже в рабочем состоянии.");
        }
    }

    public abstract class Component
    {
        public string Condition { get; protected set; } = "Новое"; // Убедитесь, что это public

        public void ChangeCondition(string condition)
        {
            if (condition != "Новое" && condition != "Сломано")
                throw new ArgumentException("Неверное состояние компонента");
            Condition = condition;
        }
    }
}
