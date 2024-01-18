using System;

public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;


    //Constructor to make easier the creation of a new entry
    public Entry (string _date, string _time, string _promptText, string _entryText)
    {
        this._date = _date;
        this._time = _time;
        this._promptText = _promptText;
        this._entryText = _entryText;
    }

    //Displays a entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}, {_time} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
    }
}