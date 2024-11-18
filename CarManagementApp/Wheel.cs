using System;

public class Wheel : IComponent
{
    public string Condition { get; set; } = "Новое";  // Состояние колеса
    public int BrokenCount { get; set; } = 0; // Счетчик поломок колеса

    // Событие поломки колеса
    public event EventHandler ComponentBroken;

    // Метод для восстановления колеса
    public void Repair()
    {
        if (Condition == "Новое")
        {
            throw new InvalidOperationException("Колесо уже в хорошем состоянии.");
        }
        Condition = "Новое";  // Восстановление колеса в рабочее состояние
        ComponentBroken?.Invoke(this, EventArgs.Empty); // Если колесо починено, срабатывает событие
    }

    // Метод для изменения состояния колеса
    public void ChangeCondition(string condition)
    {
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");

        Condition = condition;

        if (Condition == "Сломано")
        {
            BrokenCount++; // Увеличиваем счетчик поломок
            ComponentBroken?.Invoke(this, EventArgs.Empty); // Генерация события при поломке
        }
    }

    // Метод для получения информации о колесе
    public string GetInfo(bool showDetailed)
    {
        string info = $"Колесо состояние: {Condition}";

        if (showDetailed)
        {
            info += $"\nКоличество поломок: {BrokenCount}";
        }

        return info;
    }
}
