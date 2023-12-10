class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base()
    {
        SetTitle(title);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetEventAddress(address);
        SetSpeaker(speaker);
        SetCapacity(capacity);
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
