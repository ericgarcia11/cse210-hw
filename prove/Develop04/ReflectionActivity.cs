public class ReflectionActivity : Activity
{
    Random random = new Random();
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<int> _usedPrompts = new List<int>();
    private List<int> _usedQuestions = new List<int>();

    public ReflectionActivity(){
        _name = "The Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.Write(" --- ");
        DisplayPrompt();
        Console.Write(" --- ");
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Starting to display the questions
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
            for (int i=5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        // Displaying the questions until the time provided ends.
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            DisplayQuestion();
            foreach (string j in animationString)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
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

    public string GetRandomQuestion(){
        int randomIndex = random.Next(0,_questions.Count);
        while (_usedQuestions.Contains(randomIndex)){
            randomIndex = random.Next(0,_questions.Count);
        }
        _usedQuestions.Add(randomIndex);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }

    public void DisplayPrompt(){
        Console.Write(GetRandomPrompt());
    }

    public void DisplayQuestion(){
        Console.Write($"> {GetRandomQuestion()}");
    }
}