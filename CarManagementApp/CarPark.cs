using System;
using System.Collections.Generic;

namespace CarManagementApp
{
    public class CarPark
    {
        // Список автомобилей в автопарке
        public List<Car> Cars { get; set; } = new List<Car>();

        // Добавление автомобиля в автопарк
        public void AddCar(Car car)
        {
            Cars.Add(car); // Добавляем новый объект Car в список Cars
        }

        // Удаление автомобиля из автопарка по имени
        public void RemoveCar(string carName)
        {
            // Ищем машину по имени в списке
            Car carToRemove = Cars.Find(c => c.Name == carName);
            if (carToRemove != null)
            {
                Cars.Remove(carToRemove); // Удаляем найденный объект Car
            }
        }

        // Получение автомобиля по имени
        public Car GetCar(string carName)
        {
            // Ищем машину по имени в списке и возвращаем её
            return Cars.Find(c => c.Name == carName);
        }
    }
}
