using System.Collections.Generic;

namespace CarManagementApp
{
    public class CarPark
    {
        public List<Car> Cars { get; private set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }

        public Car GetCar(string name)
        {
            return Cars.Find(c => c.Name == name);
        }
    }
}
