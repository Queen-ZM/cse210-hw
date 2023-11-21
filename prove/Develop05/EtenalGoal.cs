// Derived class for EternalGoal
public class EternalGoal : Goal
{
    public EternalGoal(string description) : base(description) { }

    public override void Display()
    {
        Console.WriteLine($"Eternal Goal: {description}");
    }
}