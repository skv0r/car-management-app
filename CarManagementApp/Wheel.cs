using System;

public class Wheel : IComponent
{
    public string Condition { get; set; } = "Новое";  // Состояние колеса

    // Событие поломки колеса
    public event EventHandler ComponentBroken;

    public void Repair()
    {
        if (Condition == "Новое")
        {
            throw new InvalidOperationException("Колесо уже в хорошем состоянии.");
        }
        Condition = "Новое";  // Восстановление колеса в рабочее состояние
        ComponentBroken?.Invoke(this, EventArgs.Empty); // Если колесо починено, срабатывает событие
    }

    public void ChangeCondition(string condition)
    {
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");

        Condition = condition;

        if (Condition == "Сломано")
        {
            ComponentBroken?.Invoke(this, EventArgs.Empty); // Генерация события при поломке
        }
    }
}
