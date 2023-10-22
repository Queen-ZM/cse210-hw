public class PromptGenerator{
    string[] _prompts = new string[] {
        "How was your day?",
        "Did you do anything to assist or help anyone? ",
        "Did you find time to read scriptures today?"
    };

    Random _rnd = new Random();
    public string GetRandomPrompt(){
        int randomIndex = _rnd.Next(0,_prompts.Length);
        string getRandomPrompt = _prompts[randomIndex];

        return getRandomPrompt;
    }
}