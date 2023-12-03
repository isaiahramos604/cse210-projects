public abstract class Goal
{
    private string _goal;
    private bool _completedGoal;

    public string GetGoal()
    {
        return _goal;
    }

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public bool GetCompletedGoal()
    {
        return _completedGoal;
    }

    public void SetCompletedGoal(bool completedGoal)
    {
        _completedGoal = completedGoal;
    }

    public Goal(string goal, bool completedGoal)
    {
        _goal = goal;
        _completedGoal = completedGoal;
    }
 
       


    public abstract int RecordEvent();

    public abstract string DisplayStatus();
}