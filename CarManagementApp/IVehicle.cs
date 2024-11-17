public interface IVehicle
{
    void StartEngine();
    void StopEngine();
    void Move(int distance);
    void Refuel(int amount);
    void ReplaceBrokenWheel();
    string GetVehicleInfo();
}
