using System;

public class Wheel : Component
{
    public void Repair()
    {
        if (Condition == "Сломано")
        {
            ChangeCondition("Новое"); // Заменить сломанное колесо на новое
        }
        else
        {
            throw new InvalidOperationException("Колесо уже в хорошем состоянии.");
        }
    }
}
