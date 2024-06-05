using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Chase Wallace", "Coding");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Chase Wallace", "Fractions", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Chase Wallace", "Coding", "Coding for Dummies");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}