using System;

public class Engine : Component
{
    public int HorsePower { get; set; }
    public bool IsRunning { get; private set; }

    // Запуск двигателя
    public void Start()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");
        IsRunning = true;
    }

    // Остановка двигателя
    public void Stop()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");
        IsRunning = false;
    }

    // Метод для изменения состояния двигателя
    public new void ChangeCondition(string condition)
    {
        base.ChangeCondition(condition); // Вызов базового метода для изменения состояния компонента

        if (Condition == "Сломано")
        {
            // Если двигатель сломан, вызываем событие поломки
            OnComponentBroken();
        }
    }
}
