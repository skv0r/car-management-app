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

        // Конструктор
        public Car(string name, int horsePower, int fuelConsumption, int fuelTankCapacity)
        {
            Name = name;
            Engine = new Engine { HorsePower = horsePower };
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
                Wheels[i].ComponentBroken += OnComponentBroken; // Подписка на событие поломки колеса
            }
            Engine.ComponentBroken += OnComponentBroken; // Подписка на событие поломки двигателя

            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            Fuel = FuelTankCapacity; // Заполняем бак до максимума
        }

        // Проверка состояния двигателя
        public bool IsEngineOn => Engine.IsRunning;

        // Методы для работы с двигателем
        public void StartEngine() => Engine.Start();
        public void StopEngine() => Engine.Stop();

        // Обработка события поломки компонента (колеса или двигателя)
        private void OnComponentBroken(object sender, EventArgs e)
        {
            if (sender is Engine)
            {
                // Сообщение о поломке двигателя
                Console.WriteLine($"{Name}: Двигатель сломан!");
            }
            else if (sender is Wheel wheel)
            {
                // Сообщение о поломке колеса
                Console.WriteLine($"{Name}: Колесо {Array.IndexOf(Wheels, wheel) + 1} сломано!");
            }
        }

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

        // Заправка автомобиля
        public void Refuel(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Заправляемое количество должно быть положительным!");

            Fuel += amount;
            if (Fuel > FuelTankCapacity)
                Fuel = FuelTankCapacity;
        }

        // Метод для замены сломанного колеса
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

        // Переопределение метода GetCarInfo с возможностью вывода подробной информации
        public virtual string GetCarInfo(bool showDetailed = false)
        {
            string info = $"Название: {Name}\n" +
                          $"Мощность двигателя: {Engine.HorsePower} л.с.\n" +
                          $"Пробег: {Mileage} км\n" +
                          $"Топливо: {Fuel}/{FuelTankCapacity} л\n" +
                          $"Расход топлива: {FuelConsumption} л/100 км\n" +
                          $"Двигатель: {(IsEngineOn ? "Включен" : "Выключен")} ({Engine.Condition})\n" +
                          $"Колеса: {string.Join(", ", Wheels.Select((w, i) => $"Колесо {i + 1}: {w.Condition}"))}";

            if (showDetailed)
            {
                // Добавление подробной информации
                info += $"\nОставшийся пробег до поломки двигателя: {1000 - Mileage % 1000} км";
                for (int i = 0; i < Wheels.Length; i++)
                {
                    info += $"\nКолесо {i + 1}: поломок - {Wheels[i].BrokenCount} раз";
                }
            }

            return info;
        }

    }
}
