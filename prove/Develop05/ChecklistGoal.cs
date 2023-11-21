// Derived class for ChecklistGoal
public class ChecklistGoal : Goal
{
    public ChecklistGoal(string description) : base(description) { }

    public override void Display()
    {
        Console.WriteLine($"Checklist Goal: {description}");
    }
}