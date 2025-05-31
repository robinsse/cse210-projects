public class Comment
{
    private string _name;
    private string _text;
    public Comment(string commentorName, string text)
    {
        _name = commentorName;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"\"{_text}\" - {_name}");
    }
}