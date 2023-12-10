
class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        
        return _laps * 50 / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return base.GetSummary() +
            $": Distance {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
