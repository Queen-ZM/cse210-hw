public class MemoryScriptureGame
{
    private Scripture scripture;

    public MemoryScriptureGame(string scripture)
    {
        this.scripture = new Scripture(scripture);
    }

    public void StartGame()
    {
        while (true)
        {
            Console.WriteLine("Enter 'quit' to end the game or press Enter to hide a word.");

            var input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideRandomWord();
                Console.WriteLine("\nHidden Sentence:");
                Console.WriteLine(scripture.ToString());
            }
            else
                break;
        }
    }
};
