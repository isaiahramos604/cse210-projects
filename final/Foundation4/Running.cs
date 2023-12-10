class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return _durationMinutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() +
            $": Distance {_distance:F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
