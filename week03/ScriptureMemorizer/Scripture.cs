using System.Globalization;

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

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int count = 0;
        while (count < numberToHide && visibleIndexes.Count > 0)
        {
            int randomIndex = rand.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];
            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomIndex);
            count++;
        }
    }
}