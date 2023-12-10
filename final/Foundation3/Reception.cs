class Reception : Event
{
    private string _rsvpContactEmail;

    public string GetRSVPContactEmail()
    {
        return _rsvpContactEmail;
    }

    public void SetRSVPContactEmail(string rsvpContactEmail)
    {
        _rsvpContactEmail = rsvpContactEmail;
    }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpContactEmail)
        : base()
    {
        SetTitle(title);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetEventAddress(address);
        SetRSVPContactEmail(rsvpContactEmail);
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Contact Email: {_rsvpContactEmail}";
    }
}