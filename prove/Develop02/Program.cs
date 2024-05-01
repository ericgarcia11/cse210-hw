using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
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
            if (response == 1){
                Write day1 = new Write();
                Console.WriteLine("If I had one thing I could over today, what would it be?");
                day1._questionOne = Console.ReadLine();
                Console.WriteLine("What was the best part of my day?");
                day1._questionTwo = Console.ReadLine();
                Console.WriteLine("If I had one thing I could over today, what would it be?");
                day1._questionThree = Console.ReadLine();
            }


        }
    }
}