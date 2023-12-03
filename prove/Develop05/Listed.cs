public class ListedGoals : Goal
{
    
    private int _pointsPerCompletion;
    private int _completionCount;
    private int _requiredCompletionCount;
    private int _bonusPoints;

    public ListedGoals(bool completedGoal, string goal, int pointsPerCompletion, int requiredCompletionCount, int bonusPoints)
        : base(goal, completedGoal)
    {
        _pointsPerCompletion = pointsPerCompletion;
        _requiredCompletionCount = requiredCompletionCount;
        _bonusPoints = bonusPoints;
        _completionCount = 0;
    }

    public override int RecordEvent()
    {
        _completionCount++;
        if (_completionCount >= _requiredCompletionCount)
        {
            SetCompletedGoal(true);
            return _pointsPerCompletion * _requiredCompletionCount + _bonusPoints;
        }
        return _pointsPerCompletion;
    }

    public override string DisplayStatus()
    {
        return $"[{(GetCompletedGoal() ? "X" : " ")}] {GetGoal()} (Completed {_completionCount}/{_requiredCompletionCount} times)";
    }
    
}