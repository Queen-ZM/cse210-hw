//Eternal goal
public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name) { }

    // Override the base class method to make eternal goals never completed
    public override void CompleteGoal()
    {
        // Do nothing for eternal goals
    }
}