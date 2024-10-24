public class NegativeGoal : Goal
{
    private int _timesRecorded;

    public NegativeGoal(string name, string description, int points) 
        : base(name, description, -Math.Abs(points))
    {
        _timesRecorded = 0;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) -- Recorded {_timesRecorded} times (-{Math.Abs(_points)} points each)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points},{_timesRecorded}";
    }
}