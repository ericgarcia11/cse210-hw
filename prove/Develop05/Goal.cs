public class Goal 
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(){
        
    }

    public void SetShortName(string name){
        _shortName = name;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public void SetPoints(string points){
        _points = points;
    }

    public string GetName(){
        return _shortName;
    }

    public virtual void RecordEvent(){

    }

    public virtual bool IsComplete(){
        return false;
    }

    public virtual int GetBonus(){
        return 0;
    }

    public virtual string GetDataToSave(){
        return "";
    }

    public string GetDescription(){
        return _description;
    }

    public string GetPoints(){
        return _points;
    }

    public virtual string GetStringRepresentation(){
        return "";
    }
}