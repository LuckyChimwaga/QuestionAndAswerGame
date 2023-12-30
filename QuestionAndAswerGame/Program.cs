// See https://aka.ms/new-console-template for more information


using System;
using System.Net.NetworkInformation;
namespace WordGuesingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] level1 = { "infinix", "sumsung", "iphone" };
            string[] level2 = { "sathiya", "sony", "Pioneer", "alpine" };
            string[] level3 = { "hp", "dell", "asus", "lenovo", "apple" };

            string[][] levels = {level1,level2, level3 };
            int maxRounds = 5;
            PlayGame(levels,maxRounds);
        }
        static void PlayGame(string[][] levels, int maxRounds)
        {
            int currentRound = 1;
            while (currentRound <= maxRounds)
            {
                string[] wordToGuess = levels[currentRound - 1];
                int pointsA = 0;
                int pointsB = 0;

                Console.WriteLine($"\nRound{currentRound}(Level {wordToGuess.Length})");
                foreach (string word in wordToGuess)
                {
                    //Player A sets word and hints for Player B
                    Console.WriteLine($"Player A: Enter hints for'{word}':");
                    string hintsA = Console.ReadLine();

                    //Player B guesses the word for Player A
                    Console.WriteLine("Player B: Guess the word: ");
                    string guessB = Console.ReadLine();
                    if (guessB.ToLower() == word.ToLower())
                    {
                        Console.WriteLine("correct!!!!!");
                        pointsB++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    //Switching of the Roles from Player A to Player B and vice versa

                    Console.WriteLine($"Player B: Enter hints for {word}: ");
                    string hintsB = Console.ReadLine();

                    Console.WriteLine("Player A: Guess the word: ");
                    string guessA = Console.ReadLine();
                    if (guessB.ToLower() == word.ToLower())
                    {
                        Console.WriteLine("Correct Word! Congrats!!!!");
                        pointsA++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Good Trial!!!!!!");
                    }


                }
                double percentageA = (double)pointsA / wordToGuess.Length * 100;
                double percentageB = (double)pointsB / wordToGuess.Length * 100;

                Console.WriteLine($"\nRound {currentRound} Scores:");
                Console.WriteLine($"Player A {percentageA:F2}%");
                Console.WriteLine($"Player B {percentageB:F2}%");

                currentRound++;
            }
            Console.ReadKey();
        }
    }
}

