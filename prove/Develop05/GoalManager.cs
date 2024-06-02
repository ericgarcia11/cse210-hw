using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private int _level;

    private List<int> _checkedPoints;

    public GoalManager(){
        _score = 0;
        _goals = new List<Goal>();
        _checkedPoints = new List<int>();
    }

    public void Start(){
        int response = 0;
        while (response != 6){
            Console.WriteLine($"\nYou have {_score} points and your current level is {_level}.\n");
            Console.Write("Menu Options:"
            + "\n  1. Create new Goal"
            + "\n  2. List Goals"
            + "\n  3. Save Goals"
            + "\n  4. Load Goals"
            + "\n  5. Record Event"
            + "\n  6. Quit"
            + "\nSelect a choice from the menu: ");
            string answer = Console.ReadLine();
            response = Convert.ToInt32(answer);
            if (response == 6){
                break;
            }
            if (response == 1){
                Console.Write("The types of Goals are:"
                + "\n  1. Simple Goal"
                + "\n  2. Eternal Goal"
                + "\n  3. Checklist Goal"
                + "\nWhich type of goal would you like to create? ");
                string intAnswer = Console.ReadLine();
                int goalChosen = Convert.ToInt32(intAnswer);
                Goal newGoal = CreateGoal(goalChosen);
            }

            if (response == 2){
                Console.WriteLine("The Goals are: ");
                int count = 1;
                foreach(Goal goal in _goals){
                    Console.WriteLine($"{count}. {goal.GetStringRepresentation()}");
                    count += 1;
                }
            }
           
            if (response == 3){
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
           
            if (response == 4){
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
           
            if (response == 5){
                Console.WriteLine("The Goals are: ");
                int count = 1;
                foreach(Goal goal in _goals){
                    Console.WriteLine($"{count}. {goal.GetName()}");
                    count += 1;
                }
                Console.WriteLine("Which goal did you accomplish?");
                string ans = Console.ReadLine();
                int accomplishGoal = Convert.ToInt32(ans);
                _goals[accomplishGoal-1].RecordEvent();
                int goalPoints = Convert.ToInt32(_goals[accomplishGoal-1].GetPoints());
                _score += goalPoints;
                if (_goals[accomplishGoal -1] is ChecklistGoal){
                    if (_goals[accomplishGoal -1].IsComplete()){
                        _score += _goals[accomplishGoal-1].GetBonus();
                        Console.WriteLine($"Congratulations! You have earned {_goals[accomplishGoal -1].GetBonus() + goalPoints} points!");
                    }
                }
                else{
                    Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
                }
                Console.WriteLine($"You now have {_score} points.");
            }
            
            if (NewLevelReached()){
                _level +=1;
                Console.WriteLine($"\n ---- Congratulations! You have reached a new level!! ---- ");
                Console.WriteLine($"  ---- Level {_level} Unlocked :D ----");
            }
            
        }
    }

    public int QuantityPointsToNewLevel(){
        int count = 1;
        int total = 0;
        foreach (Goal goal in _goals){
            total += Convert.ToInt32(goal.GetPoints());
            count += 1;
        }
        int KeyNumber = (total / count) * 5;
        // Console.WriteLine("KeyNumber: " + KeyNumber);
        return KeyNumber;
    }

    public bool NewLevelReached(){
            int result = _score / QuantityPointsToNewLevel();
            if (result >= _level){
                _level = result;
                return true;
            }
        return false;
    }

    public void DisplayPlayerInfo(){

    }

    public void ListGoalsNames(){

    }

    public void ListGoalsDetails(){

    }

    public Goal CreateGoal(int goalTypeChosen){
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.WriteLine("What is amount of points associated with this goal? ");
        string points = Console.ReadLine();
        
        Goal goal =  new Goal();

        if (goalTypeChosen == 1){
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);   
            return simpleGoal; 
        }
        if (goalTypeChosen == 2){
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);   
            return eternalGoal;
        }
        if (goalTypeChosen == 3){
            Console.WriteLine("How many times does this goal needs to be accomplished for a bonus? ");
            string answer = Console.ReadLine();
            int target = Convert.ToInt32(answer);
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string answer2 = Console.ReadLine();
            int bonus = Convert.ToInt32(answer2);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);   
            return checklistGoal;
        }
        return goal;
        
    }

    public void SaveGoals(string filename){
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals){
                if (goal is SimpleGoal){
                    outputFile.WriteLine($"SimpleGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetDataToSave()}");
                }
                if (goal is EternalGoal){
                    outputFile.WriteLine($"EternalGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetDataToSave()}");
                }
                if (goal is ChecklistGoal){
                    outputFile.WriteLine($"ChecklistGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetDataToSave()}");
                }
            }
        }
    }

    public void LoadGoals(string filename){
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts.Length == 1){
                _score = Convert.ToInt32(parts[0]);
            }
            else{
                string[] parts2 = line.Split(":");
                string [] parts3 = parts2[1].Split(",");
                string goalType = parts2[0];
                if (goalType == "SimpleGoal"){
                    SimpleGoal simpleGoal = new SimpleGoal(parts3[0],parts[1],parts[2]);
                    if (parts[3] == "true" || parts[3] == "True"){
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                if (goalType == "EternalGoal"){
                    EternalGoal eternalGoal = new EternalGoal(parts3[0],parts[1],parts[2]);
                    _goals.Add(eternalGoal);
                } 
                if (goalType == "ChecklistGoal"){
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts3[0],parts[1],parts[2],Convert.ToInt32(parts[4]),Convert.ToInt32(parts[3]));
                    int amountComplete = Convert.ToInt32(parts[5]);
                    for (int i = 1; i <= amountComplete; i++){
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}