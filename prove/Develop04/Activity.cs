using System;
using System.Threading;

// Base class for common attributes and behaviors
class Activity
{
    protected string Name;
    protected string Description;
    protected int DurationInSeconds;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {Name} activity - {Description}");
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void SetDuration()
    {
        Console.Write($"Enter the duration (in seconds) for {Name}: ");
        DurationInSeconds = int.Parse(Console.ReadLine());
    }

    public virtual void DoActivity()
    {
        Console.WriteLine("Activity is in progress...");
        ShowAnimation(); // Show animation while the activity is in progress
        Thread.Sleep(DurationInSeconds * 1000);
    }

    public virtual void End()
    {
        Console.WriteLine($"Good job! You've completed the {Name} activity.");
        Console.WriteLine($"Activity: {Name}, Duration: {DurationInSeconds} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected virtual void ShowAnimation()
    {
        // Common animation code here
    }
}