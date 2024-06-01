public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, string points, int target, int bonus){
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _isComplete = false;
    }

    public override void RecordEvent(){
        _amountCompleted += 1;
        if (_amountCompleted == _target){
            _isComplete = true;
        }
    }

    public override bool IsComplete(){
        return _isComplete;
    }

    public int GetAmountCompleted(){
        return _amountCompleted;
    }

    public int GetTarget(){
        return _target;
    }

    public override int GetBonus(){
        return _bonus;
    }

    public override string GetDataToSave()
    {
        return $"{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetStringRepresentation(){
        string stringRepresentation = "";
        if (_isComplete == true){
            stringRepresentation = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else{
            stringRepresentation = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        
        return stringRepresentation;
    }
}