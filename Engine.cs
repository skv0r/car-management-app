using System;

// Класс Engine наследуется от Component и представляет двигатель автомобиля
// Класс управляет состоянием двигателя (работает/не работает) и его мощностью
public class Engine : Component
{
    // Свойство HorsePower хранит мощность двигателя в лошадиных силах
    public int HorsePower { get; set; }

    // Свойство IsRunning указывает, работает ли двигатель (true - работает, false - не работает)
    public bool IsRunning { get; private set; }

    // Метод Start запускает двигатель, если его состояние не "Сломано"
    // Если двигатель сломан, выбрасывается исключение
    public void Start()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя запустить.");
        IsRunning = true;
    }

    // Метод Stop останавливает двигатель, если его состояние не "Сломано"
    // Если двигатель сломан, выбрасывается исключение
    public void Stop()
    {
        if (Condition == "Сломано")
            throw new InvalidOperationException("Двигатель сломан, его нельзя остановить.");
        IsRunning = false;
    }

    // Переопределение метода ChangeCondition для изменения состояния двигателя
    // Изменяет состояние и вызывает событие поломки, если двигатель стал "Сломан"
    public void ChangeCondition(string condition)
    {
        Condition = condition;
    }
}
