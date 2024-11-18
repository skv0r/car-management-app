namespace CarManagementApp
{
    public class Engine
    {
        public int HorsePower { get; set; } // Мощность двигателя в лошадиных силах
        public bool IsRunning { get; private set; } // Статус двигателя (включен/выключен)

        // Метод для запуска двигателя
        public void Start()
        {
            IsRunning = true;
        }

        // Метод для остановки двигателя
        public void Stop()
        {
            IsRunning = false;
        }
    }
}
