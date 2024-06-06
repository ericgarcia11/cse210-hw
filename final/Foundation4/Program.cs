using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Swimming swimming = new Swimming();
        swimming.SetDate("11 Mar 2024");
        swimming.SetLenght(10);
        swimming.SetNLaps(3);

        Running running = new Running();
        running.SetDate("8 Nov 2022");
        running.SetLenght(25.4);
        running.SetDistance(5.2);

        Cycling cycling = new Cycling();
        cycling.SetDate("05 Fev 2020");
        cycling.SetLenght(54.2);
        cycling.SetSpeed(14.3);

        activities.Add(swimming);
        activities.Add(running);
        activities.Add(cycling);

        foreach(Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}