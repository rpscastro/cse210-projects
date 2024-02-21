using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, Address address, string date, string time, string speaker, int capacity) : base (title, description, address, date, time)
    {

        _eventType = "Lecture";
        _speaker = speaker;
        _capacity = capacity;

    }



    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {_eventType}\nSpeaker Name: {_speaker}\nCapacity: {_capacity}";
    }


}