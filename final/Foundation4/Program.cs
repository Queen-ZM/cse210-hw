class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("2022-11-03"), 30, 3.0),
            new Cycling(DateTime.Parse("2022-11-03"), 30, 20.0),
            new Swimming(DateTime.Parse("2022-11-03"), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}

