namespace CarManagementApp
{
    public class Wheel
    {
        public string Condition { get; set; } = "Нормальное"; // Состояние колеса

        public void Replace()
        {
            Condition = "Нормальное"; // После замены колесо становится нормальным
        }
    }
}
