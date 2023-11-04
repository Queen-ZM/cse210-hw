// BreathingActivity 
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Breathe in and out")
    {
    }

    protected override void ShowAnimation()
    {
        Console.WriteLine("Displaying breathing animation...");
       
    }
}