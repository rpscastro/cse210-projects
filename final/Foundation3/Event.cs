using System;
public abstract class Event
{

    protected string _title;
    protected string _description;
    protected Address _address;
    protected string _date;
    protected string _time;
    protected string _eventType;
   

    public Event(string title, string description, Address address, string date, string time){

        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;

    }


    public string GetStandardDetails()
    {

        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetFullAddress()}";
    
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {

        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    
    }




}