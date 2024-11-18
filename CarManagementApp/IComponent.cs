public interface IComponent
{
    string Condition { get; set; }
    void ChangeCondition(string condition);
}
