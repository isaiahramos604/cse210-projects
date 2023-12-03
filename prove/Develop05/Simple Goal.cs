public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(bool completedGoal, string goal, int points) : base(goal, completedGoal)
    {
        _points = points;
    }

    public override int RecordEvent()
    {
        SetCompletedGoal(true);
        return _points;
    }

    public override string DisplayStatus()
    {
        return $"[{(GetCompletedGoal() ? "X" : " ")}] {GetGoal()} (Simple)";
    }
}