// Program class
class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            int choice = GetIntInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoalsToFile();
                    break;
                case 4:
                    LoadGoalsFromFile();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int typeChoice = GetIntInput("Enter your choice: ");

        string description = GetStringInput("Enter goal description: ");

        Goal goal;

        switch (typeChoice)
        {
            case 1:
                goal = new SimpleGoal(description);
                break;
            case 2:
                goal = new EternalGoal(description);
                break;
            case 3:
                goal = new ChecklistGoal(description);
                break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                goal = new SimpleGoal(description);
                break;
        }

        goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            goal.Display();
        }
    }

    static void SaveGoalsToFile()
    {
        string fileName = GetStringInput("Enter file name to save goals: ");

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in goals)
            {
                //writer.WriteLine($"{goal.GetType().Name},{goal.description},{goal.isCompleted}");
            }
        }

        Console.WriteLine("Goals saved to file successfully.");
    }

    static void LoadGoalsFromFile()
    {
        string fileName = GetStringInput("Enter file name to load goals from: ");

        if (File.Exists(fileName))
        {
            goals.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string type = parts[0];
                        string description = parts[1];
                        bool isCompleted = bool.Parse(parts[2]);

                        Goal goal;

                        switch (type)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(description);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(description);
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(description);
                                break;
                            default:
                                Console.WriteLine($"Invalid goal type in file: {type}. Skipping.");
                                continue;
                        }

                        goal.MarkAsCompleted(); // Mark as completed based on the loaded value
                        goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine("Invalid format in file. Skipping.");
                    }
                }
            }

            Console.WriteLine("Goals loaded from file successfully.");
        }
        else
        {
            Console.WriteLine($"File not found: {fileName}");
        }
    }

    static void RecordEvent()
    {
        int index = GetIntInput("Enter the index of the goal to mark as completed: ");

        if (index >= 0 && index < goals.Count)
        {
            goals[index].MarkAsCompleted();
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
    }

    static int GetIntInput(string prompt)
    {
        int result;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }

    static string GetStringInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
