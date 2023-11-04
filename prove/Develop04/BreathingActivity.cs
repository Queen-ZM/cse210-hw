// BreathingActivity derived from Activity
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Breathe in and out")
    {
    }

    protected override void ShowAnimation()
    {
        Console.WriteLine("Displaying breathing animation...");
        // You can implement a breathing animation here
    }
}