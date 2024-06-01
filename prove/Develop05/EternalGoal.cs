public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent(){
    }

    public override bool IsComplete(){
        return false;
    }

    public override string GetDataToSave()
    {
        return $"{_points}";
    }

    public override string GetStringRepresentation(){
        string stringRepresentation  = $"[ ] {_shortName} ({_description})";
        return stringRepresentation;
    }
}