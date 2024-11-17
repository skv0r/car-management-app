using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManagementApp
{
    public class CarPark
    {
        private readonly List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            if (cars.Any(c => c.Name == car.Name)) // Проверка на существующий автомобиль с таким именем
            {
                throw new InvalidOperationException("Автомобиль с таким именем уже существует!"); // Выбрасываем исключение
            }
            cars.Add(car); // Добавляем автомобиль в коллекцию
        }

        public void RemoveCar(string carName)
        {
            Car car = cars.FirstOrDefault(c => c.Name == carName);
            if (car != null)
                cars.Remove(car);
            else
                throw new InvalidOperationException("Автомобиль не найден.");
        }

        public Car GetCar(string carName)
        {
            return cars.FirstOrDefault(c => c.Name == carName)
                   ?? throw new InvalidOperationException("Автомобиль не найден.");
        }

        public List<string> GetAllCarNames()
        {
            return cars.Select(c => c.Name).ToList();
        }
    }
}
