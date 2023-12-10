class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _eventAddress;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public TimeSpan GetTime()
    {
        return _time;
    }

    public void SetTime(TimeSpan time)
    {
        _time = time;
    }

    public Address GetEventAddress()
    {
        return _eventAddress;
    }

    public void SetEventAddress(Address address)
    {
        _eventAddress = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_eventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}