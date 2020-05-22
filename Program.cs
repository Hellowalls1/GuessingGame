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

            //prompting user to guess a difficulty

            Console.WriteLine ("Select difficulty: Easy, Medium, Hard, Cheater");

            //difficulty is equal to whatever user typees into command line

            string difficulty = Console.ReadLine ();

            //if block redifining guessLimit's value based on the difficulty entered

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

            //this bypassses guessLimit's difficulty defined in the if block about and as long as the difficulty is cheater you are allowed to guess until the answer is correct

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

            //saying while the guess limit is greater than 0(guessesGiven's default value) run this logic

            while (guessLimit > guessesGiven) {

                //message to the user on the command line informing them how many guesses are left 

                Console.WriteLine ($"Guess the secret number. Your guess ({guessesGiven + 1})");

                //prompts user to guess a number

                string userGuess = Console.ReadLine ();

                //turns the userGuess back into  an integer
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