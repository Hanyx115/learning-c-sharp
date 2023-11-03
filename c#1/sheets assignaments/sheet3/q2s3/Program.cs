using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 1001);
        int attempts = 0;
        int userGuess = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess the number between 1 and 1000.");

        while (userGuess != randomNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                attempts++;

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

