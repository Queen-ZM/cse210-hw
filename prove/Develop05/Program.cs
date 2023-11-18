class Program
{
    static void Main()
    {
        List<Goal> goals = LoadGoals(); // Load goals from file

        Console.WriteLine("Welcome to Goal Tracker!");

        // Example: Displaying goal list and points
        DisplayGoals(goals);

        // Completing goals
        Console.Write("Enter the goal index to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].CompleteGoal();
        }

        // Save updated goals to file
        SaveGoals(goals);

        // Display updated goals
        DisplayGoals(goals);
    }

    // Method to display goals
    static void DisplayGoals(List<Goal> goals)
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].DisplayStatus()} {goals[i].Name} - Points: {goals[i].Points}");
        }
    }

    // Method to save goals to a file
    static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveGoal());
            }
        }
    }

    // Method to load goals from a file
    static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();

        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string data = reader.ReadLine();
                    string[] parts = data.Split(',');

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            goals.Add(new SimpleGoal(parts[1]));
                            break;
                        case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1]);
                            checklistGoal.LoadGoal(data);
                            goals.Add(checklistGoal);
                            break;
                        case "EternalGoal":
                            goals.Add(new EternalGoal(parts[1]));
                            break;
                    }
                }
            }
        }

        return goals;
    }
}
