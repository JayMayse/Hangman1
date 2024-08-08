using System.Diagnostics.Tracing;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXATTEMPTS= 10;
            int nullify = 0;
            const int Y = 9;
            const int YO = 8;
            const int YOU = 7;
            const int YOUA = 6;
            const int YOUAR = 5;
            const int YOUARE = 4;
            const int YOUAREH = 3;
            const int YOUAREHU = 2;
            const int YOUAREHUN = 1;

            Console.WriteLine("Wanna Play a Game?");

            string[] hangman = { "power", "drive", "crime", "riden", "human" };


            Random random = new Random();
            string selectWord = hangman[random.Next(hangman.Length)];
            char[] wordToGuess = selectWord.ToCharArray();
            char[] word = wordToGuess;
            char[] guessedLetters = new char[wordToGuess.Length];

            for (int i = nullify; i < guessedLetters.Length; i++)
            {
                guessedLetters[i] = '_';
            }

            int attemptsLeft = MAXATTEMPTS;

            while (attemptsLeft > nullify)
            {
                Console.WriteLine("Current word: " + new string(guessedLetters));
                Console.WriteLine("Guess a Letter: ");
                char guess = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); 

                bool correctGuess = false;

                for (int i = nullify; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedLetters[i] = guess;
                        correctGuess = true;
                    }
                }
 

                if (!correctGuess)
                {
                    attemptsLeft--;
                    Console.WriteLine("Incorrect!  Attempts left: " + attemptsLeft);

                    if (attemptsLeft == Y)
                        Console.WriteLine("\n     Y\n");
                    if (attemptsLeft == YO)
                        Console.WriteLine("\n     YO\n");
                    if (attemptsLeft == YOU)
                        Console.WriteLine("\n     YOU\n");
                    if (attemptsLeft == YOUA)
                        Console.WriteLine("\n     YOU A\n");
                    if (attemptsLeft == YOUAR)
                        Console.WriteLine("\n     YOU AR\n");
                    if (attemptsLeft == YOUARE)
                        Console.WriteLine("\n     YOU ARE\n");
                    if (attemptsLeft == YOUAREH)
                        Console.WriteLine("\n     YOU ARE H\n");
                    if (attemptsLeft == YOUAREHU)
                        Console.WriteLine("\n     YOU ARE HU\n");
                    if (attemptsLeft == YOUAREHUN)
                        Console.WriteLine("\n     YOU ARE HUN\n");


                }

                if (new string(guessedLetters) == selectWord)
                {
                    Console.WriteLine("Congratulations! You guessed the word: " + selectWord);
                    break;
                }


                if (attemptsLeft == nullify)
                {
                    Console.WriteLine("Sorry, you have run out of attempts");
                    Console.WriteLine("\n     YOU ARE HUNG\n");

                }
            }
        }
    }
}