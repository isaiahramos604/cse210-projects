class OutdoorGathering : Event
{
    private string _weatherForecast;

    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base()
    {
        SetTitle(title);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetEventAddress(address);
        SetWeatherForecast(weatherForecast);
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}
