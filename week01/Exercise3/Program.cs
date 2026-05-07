using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;
        while (guess != randomNumber)
        {
            Console.Write("Guess a number between 1 and 100: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                guessCount++;
                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        Console.WriteLine($"It took you {guessCount} guesses to find the number.");

        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine().ToLower();

        if (playAgain == "yes")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thanks for playing! Goodbye!");
        }
    }
}