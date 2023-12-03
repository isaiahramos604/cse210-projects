public class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(bool completedGoal, string goal, int points) : base(goal, completedGoal)
    {
        _points = points;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string DisplayStatus()
    {
        return $"[ ] {GetGoal()} (Eternal)";
    }
}