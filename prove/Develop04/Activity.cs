public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(){
        _name = "Anonymus";
        _description = "Unknown topic";
        _duration = 30;
    }

    public void DisplayStartingMessage()
    {   
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}\n\n{_description}\n\nHow long, is seconds, would you like for your session?");
        string input =Console.ReadLine();
        _duration = Convert.ToInt32(input); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have complete another {_duration} seconds of {_name}");
    }

    public void ShowSpinner(int seconds)
    {
         Console.WriteLine(seconds);
    }

    public void ShowCountDown(int seconds)
    {
         Console.WriteLine(seconds);
    }

}