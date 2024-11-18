using System;

public abstract class Component
{
    public string Condition { get; protected set; } = "Новое";

    public void ChangeCondition(string condition)
    {
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");

        Condition = condition;
    }
}
