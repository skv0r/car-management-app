// Component.cs
using System;

public abstract class Component
{
    public string Condition { get; protected set; } = "Новое";  // Изначальное состояние компонента.

    // Метод для изменения состояния компонента
    public void ChangeCondition(string condition)
    {
        if (condition != "Новое" && condition != "Сломано")
            throw new ArgumentException("Неверное состояние компонента");
        Condition = condition;

        if (Condition == "Сломано")
        {
            OnComponentBroken();  // Срабатывание события о поломке.
        }
    }

    // Защитный метод для вызова события
    protected virtual void OnComponentBroken()
    {
        ComponentBroken?.Invoke(this, EventArgs.Empty);
    }

    // Событие для поломки компонента
    public event EventHandler ComponentBroken;
}
