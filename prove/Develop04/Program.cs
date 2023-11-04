class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Exit");
            int choice = int.Parse(Console.ReadLine());

            Activity selectedActivity = null;

            switch (choice)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectionActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            if (selectedActivity != null)
            {
                selectedActivity.Start();
                selectedActivity.DoActivity();
                selectedActivity.End();
            }
        }
    }
}
