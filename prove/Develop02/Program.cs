public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new();

        while (true)
        {
            Console.WriteLine("1) Add New Entry");
            Console.WriteLine("2) Display Entries");
            Console.WriteLine("3) Save");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Exit");

           
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntryies();
                    break;
                case 3:
                    journal.Save();
                    break;
                case 4:
                    journal.Load();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;

            }
        }
    }
}