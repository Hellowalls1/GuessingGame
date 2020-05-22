using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {

            //random number variable defined
            Random rand = new Random ();

            //random number redefined as a secretNumber defined within these parametersgit 
            int secretNumber = rand.Next (1, 101);

            int guessesGiven = 0;

            int guessLimit = 0;

            Console.WriteLine ("Select difficulty: Easy, Medium, Hard, Cheater");

            string difficulty = Console.ReadLine ();

            if (difficulty == "Easy") {
                guessLimit = 8;
            } else if (difficulty == "Medium") {
                guessLimit = 6;
            } else if (difficulty == "Hard") {
                guessLimit = 4;
            } else if (difficulty == "Cheater") {
                guessLimit = 1;
            } else {
                difficulty = Console.ReadLine ();
            }

            if (difficulty == "Cheater") {
                while (true) {
                    Console.WriteLine ($"Guess the secret number. Your guess ({guessesGiven + 1})");
                    string userGuess = Console.ReadLine ();
                    int userGuessInt = Int32.Parse (userGuess);
                    if (userGuessInt == secretNumber) {
                        Console.WriteLine ("Yea! You guessed it!");
                        break;
                    } else if (userGuessInt > secretNumber) {
                        Console.WriteLine ("Secret number is less than your number");
                    } else if (userGuessInt < secretNumber) {
                        Console.WriteLine ("Secret number is more than your number");
                    }
                    guessesGiven++;
                }
            }
            while (guessLimit > guessesGiven) {

                Console.WriteLine ($"Guess the secret number. Your guess ({guessesGiven + 1})");
                string userGuess = Console.ReadLine ();
                int userGuessInt = Int32.Parse (userGuess);

                if (userGuessInt == secretNumber) {
                    Console.WriteLine ("Yea! You guessed it!");
                    break;

                } else {
                    Console.WriteLine ("Nope! That's not it");
                    if (userGuessInt > secretNumber) {
                        Console.WriteLine ("Secret Number is less than your number");
                    } else {
                        Console.WriteLine ("Secret Number is higher than your number");
                    }
                }

                guessesGiven++;
            }
        }
    }
}