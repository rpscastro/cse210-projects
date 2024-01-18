using System;
using System.IO;

public class Journal
{
    //Creates the journal's entries list
    public List<Entry> _entries = new List<Entry>();

    
    //Adds a new entry into the journal
    public void AddEntry(Entry newEntry)
    {
        //Uses the built in method of a List
        _entries.Add(newEntry);
    }
    
    //Display all entries 
    public void DisplayAll()
    {
        foreach (Entry entry in _entries) 
        {
           //Calls the method of Entry class
           entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            //Adds a new line into the file for each entry
            foreach (Entry entry in _entries) 
            {
               outputFile.WriteLine($"{entry._date}|{entry._time}|{entry._promptText}|{entry._entryText}"); 
            }
            
        }                   
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        //Adds a new entry for each line of the txt file
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string dateText = parts[0];
            string timeText = parts[1];
            string promptEntry = parts[2];
            string textEntry = parts[3];

            Entry entry = new Entry(dateText, timeText, promptEntry, textEntry);
               
            AddEntry(entry);
        }
    }
}