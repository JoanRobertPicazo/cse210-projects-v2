using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = -1;

        int count = 0;

        while (guess != magic)
        {
            Console.WriteLine($"the magic number is {magic}");

            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            count = count + 1;

            if (guess < magic)
            {
                Console.WriteLine($"Higher (Attempt #{count})");
            }
            else if (guess > magic)
            {
                Console.WriteLine($"Lower, (Attempt #{count})");
            }
            else
            {
                Console.WriteLine($"You've guessed it the magic number was {magic}!");
                Console.WriteLine($"It took you #{count} attempts.");

                Console.Write("Would you like to play again? (yes or no): ");
                string again = Console.ReadLine();

                if (again == "yes")
                {
                    guess = -1;
                    magic = randomGenerator.Next(1, 100); // change magic number
                    count = 0; // reset counter
                }
                else
                {
                    Console.Write("Thanks for playing");
                }
            }
        }
    }
}