using System;

public class Engine : IComponent
{
    public string Condition { get; set; } = "Новое";  // Установка начального состояния компонента
    public int HorsePower { get; set; }
    public bool IsRunning { get; private set; }

    public void Start()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");

        IsRunning = true;  // Запускаем двигатель
    }

    public void Stop()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");

        IsRunning = false;  // Останавливаем двигатель
    }

    public void ChangeCondition(string condition)
    {
        Condition = condition;
    }
}
