public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        foreach (string scriptureWord in splitWords)
        {
            Word word = new Word(scriptureWord);
            _words.Add(word);
        }
        
        

    }
}