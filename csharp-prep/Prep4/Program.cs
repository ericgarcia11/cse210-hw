using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        // Console.WriteLine(words.Count);

        // ----- Iterating through a List -----

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        //  ---- getting the item by their index ----
        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        List<int> numbers = new List<int>();
        int number = 1;

        do
        {
              Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        } 
        while (number != 0);{
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            number = Convert.ToInt32(input);
            numbers.Add(number);
        }
        Console.WriteLine($"Your list is {numbers}");


        


    }
}