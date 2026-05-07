using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter your grade percentage: ");
       string input = Console.ReadLine();

       int grade = int.Parse(input);
       string letter = "";

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
           letter = "D";
       }
       else
       {
           letter = "F";
       }

       int lastDigit = grade % 10;

       if (letter != "f" && letter != "F")
       {
           if (lastDigit >= 7)
           {
               letter += "+";
           }
           else if (lastDigit <= 3)
           {
               letter += "-";
           }
       }

       Console.WriteLine($"Your letter grade is: {letter}");

    if (grade >= 70)
       {
           Console.WriteLine("Congratulations! You passed the class.");
       }
       else
       {
           Console.WriteLine("Sorry, you did not pass the class.");
       }

   }
}