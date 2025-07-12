using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hi what is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "A";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have an {letter} in your class.");
        

        if (grade > 70)
        {
            Console.WriteLine("Congratulations you passed your class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass your class, focus more and you will pass your class next time!");
        }
    }
}