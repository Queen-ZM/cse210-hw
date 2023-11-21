// Derived class for SimpleGoal
public class SimpleGoal : Goal
{
    public SimpleGoal(string description) : base(description) { }

    public override void Display()
    {
        Console.WriteLine($"Simple Goal: {description}");
    }
}