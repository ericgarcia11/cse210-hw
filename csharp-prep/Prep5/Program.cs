using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
             Console.WriteLine("Please enter your name: ");
             string userName = Console.ReadLine();
             return userName;
        }
        static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int userNumber = Convert.ToInt32(input);
            return userNumber;
        }
        static int SquareNumber(int userNumber){
            int square = userNumber * userNumber;
            return square;
        }
        static void DisplayResult(string userName, int square){
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);

    }


}