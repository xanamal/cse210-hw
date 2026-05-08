using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string name = PromptUserName();
        
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);


    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, your favorite number squared is: {squaredNumber}");
    }

}