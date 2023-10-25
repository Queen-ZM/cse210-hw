using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.GetRandomPrompt();
        Journal journal = new();

        string option = "0";
        do
        {
            Console.WriteLine("1) Add New Entry");
            Console.WriteLine("2) Display Entries");
            Console.WriteLine("3) Save");
            Console.WriteLine("4) Load");
            Console.WriteLine("5) Exit");

           

            
            option = Console.ReadLine();
            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Random Prompt");
                Console.WriteLine(prompt);
                Console.WriteLine("Enter your response:");

                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }

            if(option == "2")
            {
                journal.DisplayEntryies();
            }

            if(option == "3")
            {
                Console.WriteLine("Enter the filename to save from:");
                string filename = Console.ReadLine();

                journal.Save(filename);
            }

            if(option == "4")
            {
                Console.WriteLine("Enter the filename to load from: ");
                string filename = Console.ReadLine();

                journal.Load(filename);
            }
        }
        while(option != "5");
    }
};