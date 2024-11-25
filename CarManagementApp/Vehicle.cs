using System;

public abstract class Vehicle
{
    public string Name { get; set; } // Название транспортного средства

    // Базовый метод для получения информации о транспортном средстве.
    // Этот метод будет переопределяться в наследующих классах.
    public virtual string GetInfo(bool showDetailed)
    {
        // Строка с основной информацией о транспортном средстве
        string info = $"Название: {Name}";

        if (showDetailed)
        {
            // Добавление подробной информации, если параметр showDetailed равен true
            info += GetDetailedInfo();
        }

        return info; // Возвращаем информацию о транспортном средстве
    }

    // Этот метод можно переопределить в дочерних классах для предоставления подробной информации
    protected virtual string GetDetailedInfo()
    {
        // Возвращаем информацию о названии транспортного средства
        return $"Название: {Name}";
    }
}
