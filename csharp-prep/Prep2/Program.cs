using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(valueFromUser);

        string letterGrade;
        string passOrFailMessage;

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (gradePercentage >= 70)
        {
            passOrFailMessage = "Congratulations, you passed the class! ";
        }
        else
        {
            passOrFailMessage = "Fail! Better luck next time! ";
        }

        Console.WriteLine($"Your grade is {letterGrade} ");
        Console.WriteLine(passOrFailMessage);
    }
}