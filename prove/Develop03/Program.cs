using System;
using System.Collections.Generic;
using System.IO;

        string initialSentence = "Alma 34:32 For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors";
        MemoryScriptureGame game = new MemoryScriptureGame(initialSentence);

        Console.WriteLine("Original Sentence:");
        Console.WriteLine(initialSentence);

        Console.WriteLine("\nPress Enter to start the game.");
        Console.ReadLine();

        game.StartGame();
    

