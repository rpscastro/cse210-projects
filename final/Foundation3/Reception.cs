using System;
public class Reception : Event
{
    private string _rsvp;
   
    public Reception(string title, string description, Address address, string date, string time, string rsvp) : base (title, description, address, date, time)
    {

        _eventType = "Reception";
        _rsvp = rsvp;
        
    }



    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: {_eventType}\nE-mail for RSVP: {_rsvp}";
    }

}