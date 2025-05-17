public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who did you talk to today who made an impact on your day?",
        "How did God bless your life today?",
        "Did you receive any promptings today?",
        "What was the high point of today?",
        "What did you struggle with today?"
    };

    private Random rand = new Random();
    public string GetRandomPrompt()
    {
        int number = rand.Next(0, _prompts.Count);
        return _prompts[number];
    }
}