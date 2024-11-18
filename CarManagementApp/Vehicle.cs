using System;

public abstract class Vehicle
{
    public string Name { get; set; }

    // Базовый метод для получения информации о транспортном средстве.
    // Этот метод будет переопределяться в наследующих классах.
    public virtual string GetInfo(bool showDetailed)
    {
        string info = $"Название: {Name}";

        if (showDetailed)
        {
            info += GetDetailedInfo();
        }

        return info;
    }

    // Этот метод можно переопределить в дочерних классах для предоставления подробной информации
    protected virtual string GetDetailedInfo()
    {
         return $"Название: {Name}";
    }
}
