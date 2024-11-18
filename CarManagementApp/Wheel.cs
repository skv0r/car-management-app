using System;

public class Wheel : IComponent
{
    public string Condition { get; set; } = "Новое";  // Состояние колеса

    public void Repair()
    {
        if (Condition == "Новое")
        {
            throw new InvalidOperationException("Колесо уже в хорошем состоянии.");
        }
        Condition = "Новое";  // Восстановление колеса в рабочее состояние
    }

    public void ChangeCondition(string condition)
    {
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");

        Condition = condition;
    }
}
