// class for checklist goals
public class ChecklistGoal : Goal
{
    private int completionCount;

    public ChecklistGoal(string name) : base(name)
    {
        completionCount = 0;
    }

    // base class method to handle checklist-specific logic
    public override void CompleteGoal()
    {
        if (!IsCompleted)
        {
            completionCount++;
            if (completionCount == 3) //  Days can be adjusted as needed
            {
                base.CompleteGoal();
            }
        }
    }

    // base class method to display checklist-specific status
    public override string DisplayStatus()
    {
        return IsCompleted ? $"Completed {completionCount}/3 times" : "[ ]";
    }

    // base class method to save checklist-specific information
    public override string SaveGoal()
    {
        return $"{base.SaveGoal()},{completionCount}";
    }

    // base class method to load checklist-specific information
    public override void LoadGoal(string data)
    {
        base.LoadGoal(data);
        completionCount = int.Parse(data.Split(',')[4]);
    }
}