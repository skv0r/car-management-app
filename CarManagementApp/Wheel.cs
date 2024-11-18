using System;

public class Wheel : Component
{
    public void Replace()
    {
        if (Condition == "Сломано")
        {
            ChangeCondition("Новое"); // Заменить на новое состояние
        }
        else
        {
            throw new InvalidOperationException("Колесо не сломано, нет необходимости в замене.");
        }
    }
}
