using System.Diagnostics.Tracing;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 10;
            int nullify = 0;
            int y = 9;
            int yo = 8;
            int you = 7;
            int youa = 6;
            int youar = 5;
            int youare = 4;
            int youareh = 3;
            int youarehu = 2;
            int youarehun = 1;

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

            int attemptsLeft = maxAttempts;

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

                    if (attemptsLeft == y)
                        Console.WriteLine("\n     Y\n");
                    if (attemptsLeft == yo)
                        Console.WriteLine("\n     YO\n");
                    if (attemptsLeft == you)
                        Console.WriteLine("\n     YOU\n");
                    if (attemptsLeft == youa)
                        Console.WriteLine("\n     YOU A\n");
                    if (attemptsLeft == youar)
                        Console.WriteLine("\n     YOU AR\n");
                    if (attemptsLeft == youare)
                        Console.WriteLine("\n     YOU ARE\n");
                    if (attemptsLeft == youareh)
                        Console.WriteLine("\n     YOU ARE H\n");
                    if (attemptsLeft == youarehu)
                        Console.WriteLine("\n     YOU ARE HU\n");
                    if (attemptsLeft == youarehun)
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