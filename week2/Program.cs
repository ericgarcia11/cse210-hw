using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes"){
            Random random = new Random();
            int magic = random.Next(1, 11);
        
            int guess = -21321;

            int count = 0;

            while (magic != guess)
            {   
                if (guess > magic){
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("Higher");
                }

                Console.WriteLine("What is your guess?");
                string input = Console.ReadLine();
                guess = Convert.ToInt32(input);

                if (guess == magic){
                    break;
                } 
                count += 1;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {count} guesses.");
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}