using System;
// I added a code part to make sure no random prompts/questions are selected until they have all been used at least once in that session.
class Program
{
    static void Main(string[] args)
    {   
        int response = 0;   
        while (response != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:"
            + "\n  1. Start breathing actiivity"
            + "\n  2. Start reflecting activity"
            + "\n  3. Start listing activity"
            + "\n  4. Quit"
            + "\nSelect a choice  from the menu: ");
            string answer = Console.ReadLine();
            response = Convert.ToInt32(answer);
            if (response == 1){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            if (response == 2){
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
            }
            if (response == 3){
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        }
    }
}