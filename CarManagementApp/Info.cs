using System.Linq;

namespace CarManagementApp
{
    public sealed class Info : Car
    {
        // Конструктор для класса Info, который вызывает конструктор базового класса
        public Info(string name, int horsePower, int fuelConsumption, int fuelTankCapacity)
            : base(name, horsePower, fuelConsumption, fuelTankCapacity)
        {
        }

        // Переопределяем метод получения информации о машине
        public override string GetCarInfo(bool showDetailed = false)
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
