public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _listingPrompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void SelectListPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_listingPrompt.Count);
        Console.WriteLine($" --- {_listingPrompt[randomIndex]} --- ");
        Pause();
    }

    public void Run()
    {
        SelectListPrompt();
        ListedItems();
    }

    public void ListedItems()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = Countdown(startTime);

        _count = 0;
        List<string> _items = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"Item {_count + 1}: ");
            string answer = Console.ReadLine();
            _items.Add(answer);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
    }
}