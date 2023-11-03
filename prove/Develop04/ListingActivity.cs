// ListingActivity derived from Activity
class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "List good things that have happened today")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Answer the following questions and list the good things that have happened today.");
    }

    public override void DoActivity()
    {
        base.DoActivity();
        List<string> questions = new List<string>
        {
            "What made you smile today?",
            "What achievements are you proud of?",
            "Did you learn something new today?",
            "Who did you connect with today?",
            "What made you feel grateful today?"
        };

        Random random = new Random();

        for (int i = 0; i < DurationInSeconds; i++)
        {
            Console.WriteLine($"Question {i + 1}: {questions[random.Next(questions.Count)]}");
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            Console.WriteLine($"You listed: {answer}");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public override void End()
    {
        base.End();
    }
}

