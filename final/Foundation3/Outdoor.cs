using System;
public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, Address address, string date, string time, string weather) : base (title, description, address, date, time)
    {

        _eventType = "Outdoor";
        _weather = weather;

    }



    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {_eventType}\nStatement of the Weather: {_weather}";
    }


}