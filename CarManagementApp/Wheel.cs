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
        // Если колесо уже новое, невозможно выполнить восстановление
        if (Condition == "Новое")
        {
            throw new InvalidOperationException("Колесо уже в хорошем состоянии.");
        }
        // Восстановление состояния колеса в "Новое"
        Condition = "Новое";
        // Генерация события о восстановлении колеса
        ComponentBroken?.Invoke(this, EventArgs.Empty);
    }

    // Метод для изменения состояния колеса
    public void ChangeCondition(string condition)
    {
        // Проверка, что состояние колеса либо "Новое", либо "Сломано"
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");

        // Изменение состояния колеса
        Condition = condition;

        // Если колесо сломано, увеличиваем счетчик поломок и генерируем событие
        if (Condition == "Сломано")
        {
            BrokenCount++; // Увеличиваем счетчик поломок
            ComponentBroken?.Invoke(this, EventArgs.Empty); // Генерация события при поломке
        }
    }

    // Метод для получения информации о колесе
    public string GetInfo(bool showDetailed)
    {
        // Базовая информация о состоянии колеса
        string info = $"Колесо состояние: {Condition}";

        if (showDetailed)
        {
            // Если запрашиваются подробности, добавляем информацию о количестве поломок
            info += $"\nКоличество поломок: {BrokenCount}";
        }

        return info;  // Возвращаем итоговую информацию
    }
}
