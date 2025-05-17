public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }

    }

    public void SaveToFile(string fileName)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            lines.Add(entry._date);
            lines.Add(entry._thanks);
            lines.Add(entry._promptText);
            lines.Add(entry._entryText);
            lines.Add("");
        }

        File.WriteAllLines(fileName, lines);
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i += 5)
        {
            Entry entry = new Entry();
            entry._date = lines[i];
            entry._thanks = lines[i + 1];
            entry._promptText = lines[i + 2];
            entry._entryText = lines[i + 3];

            _entries.Add(entry);
        }
    }
}