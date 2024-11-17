namespace CarManagementApp
{
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

        public string GetInfo()
        {
            return $"Двигатель мощностью {HorsePower} л.с., состояние: {(IsRunning ? "Включен" : "Выключен")}";
        }
    }
}
