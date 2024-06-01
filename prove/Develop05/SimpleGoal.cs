public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent(){
        _isComplete = true;
    }

    public override bool IsComplete(){
        return _isComplete;
    }

    public override string GetDataToSave()
    {
        return $"{_points},{_isComplete}";
    }

    public override string GetStringRepresentation(){
        string stringRepresentation = "";
        if (_isComplete == true){
            stringRepresentation = $"[X] {_shortName} ({_description})";
        }
        else{
            stringRepresentation = $"[ ] {_shortName} ({_description})";
        }
        
        return stringRepresentation;
    }
}