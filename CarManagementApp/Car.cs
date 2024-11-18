using System;
using System.Linq;

namespace CarManagementApp
{
    // Класс Car представляет автомобиль с его компонентами (двигатель, колеса) и управлением ими
    public class Car
    {
        // Свойство Name хранит название автомобиля
        public string Name { get; set; }

        // Свойство Engine хранит объект двигателя автомобиля
        public Engine Engine { get; set; }

        // Свойство Wheels хранит массив колес автомобиля (массив из 4 колес)
        public Wheel[] Wheels { get; set; }

        // Свойство Fuel хранит текущее количество топлива в автомобиле
        public int Fuel { get; private set; }

        // Свойство FuelTankCapacity хранит максимальный объем топливного бака
        public int FuelTankCapacity { get; private set; }

        // Свойство Mileage хранит пробег автомобиля в километрах
        public int Mileage { get; private set; } = 0;

        // Свойство FuelConsumption хранит расход топлива на 100 км
        public int FuelConsumption { get; private set; }

        // Конструктор класса Car
        // Инициализирует автомобиль с заданными параметрами: имя, мощность двигателя, расход топлива и объем бака
        public Car(string name, int horsePower, int fuelConsumption, int fuelTankCapacity)
        {
            Name = name;
            Engine = new Engine { HorsePower = horsePower };
            Wheels = new Wheel[4]; // Инициализация массива колес

            // Инициализация колес и подписка на событие поломки каждого колеса
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
                Wheels[i].ComponentBroken += OnComponentBroken; // Подписка на событие поломки колеса
            }

            Engine.ComponentBroken += OnComponentBroken; // Подписка на событие поломки двигателя

            FuelConsumption = fuelConsumption;
            FuelTankCapacity = fuelTankCapacity;
            Fuel = FuelTankCapacity; // Заполнение бака до максимума
        }

        // Свойство IsEngineOn проверяет, работает ли двигатель
        // Возвращает true, если двигатель включен, иначе false
        public bool IsEngineOn => Engine.IsRunning;

        // Метод StartEngine запускает двигатель
        public void StartEngine() => Engine.Start();

        // Метод StopEngine выключает двигатель
        public void StopEngine() => Engine.Stop();

        // Обработчик события поломки компонента (колеса или двигателя)
        // При поломке компонента выводится сообщение о поломке в консоль
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

        // Перегрузка метода Move: стандартное движение (обычная скорость)
        // Этот метод вызывает второй метод Move с параметром isFast = false (стандартная скорость)
        public void Move(int distance)
        {
            Move(distance, false);  // Перемещение с обычной скоростью
        }

        // Перегрузка метода Move: движение с дополнительными параметрами (например, высокая скорость)
        // Если параметр isFast равен true, расход топлива снижается на 20% (ускоренный режим)
        public void Move(int distance, bool isFast = false)
        {
            // Проверка, включен ли двигатель, если выключен - нельзя двигаться
            if (!IsEngineOn)
            {
                throw new InvalidOperationException("Двигатель выключен! Невозможно передвигаться.");
            }

            // Проверка, не сломан ли двигатель
            if (Engine.Condition == "Сломано")
                throw new InvalidOperationException("Двигатель сломан, машина не может двигаться.");

            // Проверка, достаточно ли топлива для движения
            if (Fuel < (distance * FuelConsumption) / 100)
                throw new InvalidOperationException("Недостаточно топлива!");

            // Проверка, не сломано ли одно из колес
            if (Wheels.Any(w => w.Condition == "Сломано"))
                throw new InvalidOperationException("Одно из колес сломано!");

            // Увеличиваем пробег
            Mileage += distance;

            // Расчет расхода топлива в зависимости от скорости
            if (isFast)
            {
                // Ускоренная скорость: расход топлива снижается на 20%
                Fuel -= (int)((distance * FuelConsumption) / 100 * 0.8); // Приведение типа к int
            }
            else
            {
                // Обычная скорость: расход топлива без изменений
                Fuel -= (distance * FuelConsumption) / 100;
            }

            // Поломка колеса каждые 200 км
            if (Mileage % 200 == 0)
            {
                Random random = new Random();
                int brokenWheelIndex = random.Next(Wheels.Length);
                Wheels[brokenWheelIndex].ChangeCondition("Сломано"); // Случайная поломка одного из колес
            }

            // Поломка двигателя каждые 1000 км
            if (Mileage % 1000 == 0)
            {
                Engine.ChangeCondition("Сломано"); // Поломка двигателя после 1000 км пробега
            }
        }

        // Метод Refuel заправляет автомобиль на указанное количество литров
        // Проверяет, не превышает ли заправка емкость бака
        public void Refuel(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Заправляемое количество должно быть положительным!");

            Fuel += amount;
            if (Fuel > FuelTankCapacity)
                Fuel = FuelTankCapacity; // Если заправлено больше, чем вмещает бак, устанавливаем максимальную емкость
        }

        // Метод ReplaceBrokenWheel заменяет сломанное колесо на новое
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
            throw new InvalidOperationException("Нет сломанных колес для замены."); // Если нет сломанных колес
        }

        // Метод для получения информации о машине
        // Если параметр showDetailed = true, выводится подробная информация
        public virtual string GetCarInfo(bool showDetailed = false)
        {
            // Основная информация о машине
            string info = $"Название: {Name}\n" +
                          $"Мощность двигателя: {Engine.HorsePower} л.с.\n" +
                          $"Пробег: {Mileage} км\n" +
                          $"Топливо: {Fuel}/{FuelTankCapacity} л\n" +
                          $"Расход топлива: {FuelConsumption} л/100 км\n" +
                          $"Двигатель: {(IsEngineOn ? "Включен" : "Выключен")} ({Engine.Condition})\n" +
                          $"Колеса: {string.Join(", ", Wheels.Select((w, i) => $"Колесо {i + 1}: {w.Condition}"))}";

            // Если showDetailed == true, добавляется подробная информация
            if (showDetailed)
            {
                info += $"\nОставшийся пробег до поломки двигателя: {1000 - Mileage % 1000} км";
                for (int i = 0; i < Wheels.Length; i++)
                {
                    info += $"\nКолесо {i + 1}: осталось до поломки {200 - Mileage % 200} км";
                }
            }

            return info;
        }
    }
}
