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
        Write myDay = new Write();
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
            
            if (response == 1){
                Console.WriteLine(question);
                myDay._answer = Console.ReadLine();
                myDay._promptAndNote = $"{currentDate} -- Prompt: {question}\n{myDay._answer}";
                myDay.AddPromptsToWritingsList();
            }
            if (response == 2){
                myDay.displayWritingList();
            }
            if (response == 3){
                // LOAD
            }
            if (response == 4){
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                string recordToSave = myDay._promptAndNote;
                Files file = new Files(fileName);
                file.fileName = fileName;
                file.addLineToFile(recordToSave);

            }


        }
    }
}