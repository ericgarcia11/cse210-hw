using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // this is prep 2
        Console.WriteLine("What is your grade percentage, please?");
        string input = Console.ReadLine();
        int Gpercentage = Convert.ToInt32(input);   
        int ldigit = Gpercentage % 10;
        string grade = "";
        int status = 0;
        string Gsign = "";
        string complete_grade = "";
        if (Gpercentage >= 90){
            grade = "A";
            status = 1;
        } else if (Gpercentage >= 80) {
            grade = "B";
            status = 1;
        } else if (Gpercentage >= 70) {
            grade = "C";
            status = 1;
        } else if (Gpercentage >= 60) {
            grade = "D";
            status = 0;
        } else {
            grade = "F";
            status = 0;
        }

        if (ldigit >=7){
            Gsign = "+";
        } else if (ldigit >= 3) {
            Gsign = "";
        } else {
            Gsign = "-";
        }
        
        if (grade == "A"){
            if (Gsign == "+"){
                complete_grade = grade;
            } else {
                complete_grade = grade + Gsign;
            }
        } else if (grade == "F"){
            complete_grade = grade;
        } else {
            complete_grade = grade + Gsign;
        }
        
        if (status == 1){
            Console.WriteLine($"Your grade is {complete_grade}.");
            Console.WriteLine("Congratulations, you have passed on your current class!");
        } else {
            Console.WriteLine($"Your grade is {complete_grade}.");
            Console.WriteLine("You did not passed. Keep trying to get a better grade on the next time.");
        }
        
    }
}