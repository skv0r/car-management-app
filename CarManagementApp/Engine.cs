using System;

public class Engine : Component
{
    public int HorsePower { get; set; }

    public void Start()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");
        // Логика запуска двигателя
    }

    public void Stop()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");
        // Логика остановки двигателя
    }
}
