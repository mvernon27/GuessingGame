using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            Console.WriteLine("Try to guess the secret number betwen 1 and 10. You have 3 guesses.");
            int guess1 = 0;


            int count = 0;
            while (guess1 != randomNumber && ++count < 4)
            {
                Console.WriteLine("Guess a number.");
                guess1 = Convert.ToInt32(Console.ReadLine());
                if (guess1 == randomNumber)
                {
                    Console.WriteLine("You have WON! The number was " + randomNumber + "!");
                }
                if (guess1 > randomNumber)
                {
                    Console.WriteLine("Your guess was greater than the secret number.");
                }
                if (guess1 < randomNumber && guess1 > 0)
                {
                    Console.WriteLine("Your guess was less than the secret number.");
                }
                if (guess1 == 0)
                {
                    Console.WriteLine("Guess the secret number between 1 and 10");
                }
                if (guess1 < 0)
                {
                    Environment.Exit(0);
                }
            }
            if (guess1 != randomNumber)
            {
                Console.WriteLine("You have lost, the secret number was " + randomNumber + ".");
            }
        }
    }
}










