namespace CarManagementApp
{
    public interface IComponent
    {
        string Condition { get; set; } // Состояние компонента (например, для колеса: целое или сломано)
        void Replace(); // Метод для замены компонента
    }
}
