// BreathingActivity derived from Activity
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Breathe in and out")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Follow the instructions to breathe in and out.");
    }

    public override void DoActivity()
    {
        base.DoActivity();
        Console.WriteLine("Breathe in...");
        Thread.Sleep(1000); // Pause for 1 second
        Console.WriteLine("Breathe out...");
        Thread.Sleep(1000); // Pause for 1 second
        for (int i = 0; i < DurationInSeconds - 2; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000); // Pause for 1 second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public override void End()
    {
        base.End();
    }
}

