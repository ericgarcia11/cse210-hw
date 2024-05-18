using System.Globalization;

public class BreathingActivity : Activity
{
    public BreathingActivity(){
        _name = "The Breathing Activity";
        _description = "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void run(){
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
        // int i = 0;
        // while (DateTime.Now < endTime)
        // {
        //     string s = animationString[i];
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        //     i++;
        //     if (animationString.Count <= i){
        //         i = 0;                
        //     }
        // }

        // Display the breath in and breath out
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            for (int i=5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Write($"\nNow breathe out...");
            for (int i=5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        // Displaynig the "Well done" message and animation
        Console.WriteLine("\n\nWell done!!");
        foreach (string j in animationString)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        // Displaying the end message and final animation
        DisplayEndingMessage();
        foreach (string j in animationString)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}