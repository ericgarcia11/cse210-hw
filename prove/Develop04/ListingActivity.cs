public class ListingActivity : Activity
{
    private List<string> userInputs = new List<string>();
    private Random random = new Random();
    private List<int> _usedPrompts = new List<int>();
    private int _count = 0;
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(){
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name = "The Listing Activity";
    }

    public void Run(){
        DisplayStartingMessage();
         Console.Clear();
        // Display The "Get ready...." and animation
        List<string> animationString = new List<string>
        {
            "|","/","-","\\","|","/","-","\\"
        };
        Console.WriteLine("Get ready...");
        foreach (string j in animationString)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        // Displaying the prompt to consider
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.Write(" --- ");
        Console.Write(GetRandomPrompt());
        Console.Write(" --- ");
        Console.Write("\nYou may begin in: ");
        for (int i=5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        // Starts the countdown to user write the answers
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            Console.Write(">");
            SetListFromUser(Console.ReadLine());
        }
        // Display how many entries the user has recorded.
        if (GetListFromUser().Count == 1){
            Console.WriteLine($"You listed 1 item!");
        }else{
            Console.WriteLine($"You listed {GetListFromUser().Count} items!");
        }
        // Displaynig the "Well done" message and animation
        Console.WriteLine("\nWell done!!");
        foreach (string j in animationString)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        // Displaying the end message and final animation
        DisplayEndingMessage();
        foreach (string j in animationString)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string GetRandomPrompt(){
        int randomIndex = random.Next(0,_prompts.Count);
        while (_usedPrompts.Contains(randomIndex)){
            randomIndex = random.Next(0,_prompts.Count);
        }
        _usedPrompts.Add(randomIndex);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    public List<string> GetListFromUser(){
        return userInputs;
    }

    public void SetListFromUser(string userInput){
        userInputs.Add(userInput);
    }
}