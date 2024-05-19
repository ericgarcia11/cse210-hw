using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment = new Assignment();
        assignment.setStudentName("Eric");
        assignment.setTopic("Programming with Classes");
        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.setProblems("8-19");
        mathAssignment.setTextbookSection("7.3");
        mathAssignment.setStudentName("Eric Garcia");
        mathAssignment.setTopic("Fractions");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.setStudentName("Lauren");
        writingAssignment.setTitle("The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}