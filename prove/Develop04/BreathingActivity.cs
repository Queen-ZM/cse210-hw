// BreathingActivity derived from Activity
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Breathe in and out")
    {
    }

    public override void Start()
    {
        Console.WriteLine("Displaying meditation animation...");
        // You can implement meditation animation here
    }
}