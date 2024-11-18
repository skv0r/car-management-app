using System;

public class Engine : Component
{
    public int HorsePower { get; set; }
    public bool IsRunning { get; private set; } = false;  // добавляем свойство для состояния двигателя

    public void Start()
    {
        if (Condition == "Сломан")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");

        IsRunning = true; // Двигатель включается
    }

    public void Stop()
    {
        if (Condition == "Сломан")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");

        IsRunning = false; // Двигатель выключается
    }

    public void ChangeCondition(string newCondition)
    {
        Condition = newCondition;
    }
}
