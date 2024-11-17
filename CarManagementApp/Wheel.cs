public class Wheel
{
    public string Condition { get; set; } = "Новое"; // По умолчанию колесо новое

    public void Replace() => Condition = "Новое"; // При замене колесо снова новое
}
