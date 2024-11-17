namespace CarManagementApp
{
    public class Car
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }
        public Wheel[] Wheels { get; set; }

        public Car(string name, int horsePower)
        {
            Name = name;
            Engine = new Engine { HorsePower = horsePower };
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
        }
    }

    public class Engine
    {
        public int HorsePower { get; set; }
        public bool IsRunning { get; private set; }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }

    public class Wheel
    {
        public string Condition { get; set; } = "Новое";

        public void Replace()
        {
            Condition = "Новое";
        }
    }
}
