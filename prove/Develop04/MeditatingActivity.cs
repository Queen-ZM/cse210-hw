// MeditationActivity derived from Activity
class MeditationActivity : Activity
{
    public MeditationActivity() : base("Meditation", "Meditate for a specific time")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Get into a comfortable position and prepare to meditate.");
    }

    public override void DoActivity()
    {
        base.DoActivity();
        Console.WriteLine("Meditation in progress...");
    }

    public override void End()
    {
        base.End();
    }
}

