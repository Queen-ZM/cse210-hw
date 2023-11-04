// ReflectionActivity 
class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "Reflect on random questions")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Reflect on the following questions:");
    }

    public override void DoActivity()
    {
        base.DoActivity();
        List<string> questions = new List<string>
        {
            "What is something you're grateful for?",
            "What is a recent challenge you've faced?",
            "What is a goal you're working towards?",
            "Describe a recent positive experience.",
            "What can you do to improve yourself?"
        };

        Random random = new Random();

        for (int i = 0; i < DurationInSeconds; i++)
        {
            Console.WriteLine($"Question {i + 1}: {questions[random.Next(questions.Count)]}");
            Console.Write("Your reflection: ");
            string reflection = Console.ReadLine();
            Console.WriteLine($"You reflected: {reflection}");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public override void End()
    {
        base.End();
    }
}


