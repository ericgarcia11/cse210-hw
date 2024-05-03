using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        List<string> questions = new List<string>
        {
            "If I had one thing I could over today, what would it be?",
            "What was the best part of my day?",
            "If I had one thing I could over today, what would it be?"
        };
        Random random = new Random();
        while (response != 5)
        {
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine();
            response = Convert.ToInt32(input); 
            if (response == 5){
                break;
            }
            DateTime currentDate = DateTime.Now;
            int randomIndex = random.Next(0,questions.Count);
            string question = questions[randomIndex];
            Write day1 = new Write();
            if (response == 1){
                Console.WriteLine(question);
                day1._answer = Console.ReadLine();
                day1._promptAndNote = $"{currentDate} -- Prompt: {question}\n{day1._answer}";
                day1.AddPromptsToWritingsList();
            }
            if (response == 2){
                day1.displayWritingList();
            }


        }
    }
}