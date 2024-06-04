using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address();
        address1.SetStreet("Rua Archimimo Albino de Abreu 195");
        address1.SetCity("Canela");
        address1.SetState("RS");
        address1.SetCountry("BR");

        Address address2 = new Address();
        address2.SetStreet("Central Perk Street");
        address2.SetCity("New York City");
        address2.SetState("NY");
        address2.SetCountry("US");

        Address address3 = new Address();
        address3.SetStreet("Augusto Pestana");
        address3.SetCity("Canela");
        address3.SetState("RS");
        address3.SetCountry("BR");

        Lectures lectureEvent = new Lectures();
        lectureEvent.SetAddress(address1);
        lectureEvent.SetTitle("Devocional com Casal Keller");
        lectureEvent.SetDescription("Spiritual devotional with Patriarch and his Wife");
        lectureEvent.SetDate("06/12/24");
        lectureEvent.SetTime("7pm");
        lectureEvent.SetSpeaker("David Keller and Teresa Keller");
        lectureEvent.SetCapacity(340);

        Receptions receptionEvent = new Receptions();
        receptionEvent.SetAddress(address2);
        receptionEvent.SetTitle("Welcome to Elder Garcia");
        receptionEvent.SetDescription("Reception for Elder Garcia after his 2-year mission");
        receptionEvent.SetDate("11/08/24");
        receptionEvent.SetTime("11am");
        receptionEvent.SetEmailForRSVP("laukeller01@gmail.com");

        OutdookGatherings outdoorGatherings = new OutdookGatherings();
        outdoorGatherings.SetAddress(address3);
        outdoorGatherings.SetTitle("Lauren and Eric's wedding");
        outdoorGatherings.SetDescription("Lauren and Eric's wedding ceremony on Cambara do Sul Canyon");
        outdoorGatherings.SetDate("03/11/23");
        outdoorGatherings.SetTime("11:30am");
        outdoorGatherings.SetWeather("Sunny with gentle winds");

        Console.WriteLine(" --- EVENT 1 --- ");
        Console.WriteLine("STANDART DETAILS:");
        Console.WriteLine($"{lectureEvent.GetStandartDetails()}\n");
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"{lectureEvent.GetFullDetails()}\n");
        Console.WriteLine("SHORT DESCRIPTION:");
        Console.WriteLine($"Lecture Event: {lectureEvent.GetShortDescription()}\n");
        
        Console.WriteLine(" --- EVENT 2 --- ");
        Console.WriteLine("STANDART DETAILS:");
        Console.WriteLine($"{receptionEvent.GetStandartDetails()}\n");
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"{receptionEvent.GetFullDetails()}\n");
        Console.WriteLine("SHORT DESCRIPTION:");
        Console.WriteLine($"Reception Event: {receptionEvent.GetShortDescription()}\n");

        Console.WriteLine(" --- EVENT 3 --- ");
        Console.WriteLine("STANDART DETAILS:");
        Console.WriteLine($"{outdoorGatherings.GetStandartDetails()}\n");
        Console.WriteLine("FULL DETAILS:");
        Console.WriteLine($"{outdoorGatherings.GetFullDetails()}\n");
        Console.WriteLine("SHORT DESCRIPTION:");
        Console.WriteLine($"Outdoor Gathering Event: {outdoorGatherings.GetShortDescription()}\n");
    }
}