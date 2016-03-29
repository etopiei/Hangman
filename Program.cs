using System;

namespace Hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");

            Game newgame = new Game();
            newgame.ChooseWord();
        }
    }

    class Game
    {

        public void ChooseWord()
        {

            WordList words = new WordList();
            string chosenword = words.ChooseRandomWord();
            ConvertWordToArray(chosenword);

        }

        public void ConvertWordToArray(string chosenword)
        {

            // Use ToCharArray to convert string to array.
            char[] lettersarray = chosenword.ToCharArray();
            int numberofletters = lettersarray.Length;

            bool[] guessed = new bool[numberofletters];

            int numberofincorrectguessesremaining = 8;

            PrintWord(lettersarray, guessed, numberofletters);

            AcceptGuess(lettersarray, guessed, numberofincorrectguessesremaining);

        }

        public void PrintWord(char[] lettersarray, bool[] guessed, int numberofletters)
        {

            for (int i = 0; i < numberofletters; i++)
            {
                if (guessed[i] == false)
                {
                    // Display each blank space.
                    Console.Write("_ ");
                }
                else
                {
                    char letter = lettersarray[i];
                    Console.Write(letter);

                }
            }

        }

        public void AcceptGuess(char[] lettersarray, bool[] guessed, int numberofincorrectguessesremaining)
        {
            Console.WriteLine("\n{0} Incorrect guesses remaining", numberofincorrectguessesremaining);
            Console.WriteLine("\nPlease enter a letter to guess:");
            string guess = Console.ReadLine();
            ParseInputData(guess, lettersarray, guessed, numberofincorrectguessesremaining);
        }

        public void ParseInputData(string guess, char[] lettersarray, bool[] guessed, int numberofincorrectguessesremaining)
        {

            //check input is only one letter

            if (guess.Length == 1)
            {
                    char letterguess = guess[0];
                    letterguess = Char.ToLower(letterguess);
                    CheckGuess(letterguess, lettersarray, guessed, numberofincorrectguessesremaining);


            }
            else
            {
                
                Console.WriteLine("Please enter only one letter.");
                AcceptGuess(lettersarray, guessed, numberofincorrectguessesremaining);
            
            }

        }

        public void CheckGuess(char letterguess, char[] lettersarray, bool[] guessed, int numberofincorrectguessesremaining)
        {

            bool correctguess = false;
            int numberofletters = lettersarray.Length;
            //compare guess to elements in array
            for (int i = 0; i < numberofletters; i++)
            {

                if (letterguess == lettersarray[i])
                {

                    guessed[i] = true;
                    correctguess = true;
                    bool Won = CheckIfYouWon(guessed, numberofletters, lettersarray);

                    if (Won == true)
                    {
                        Console.WriteLine("Play Again? Enter 'y' for yes and 'n' for no.");
                        string answer = Console.ReadLine();
                        PlayAgain(answer);
                    }

                }
                else
                {
                    continue;

                }

            }

            if (correctguess == false)
            {

                numberofincorrectguessesremaining = numberofincorrectguessesremaining - 1;

            }  

            if (numberofincorrectguessesremaining > 0)
            {

                PrintWord(lettersarray, guessed, numberofletters);
                AcceptGuess(lettersarray, guessed, numberofincorrectguessesremaining);

            }
            else
            {

                Console.WriteLine("Out of guesses!");
                string word = new string(lettersarray);
                Console.WriteLine("The word was: {0}", word);
                Console.WriteLine("Play Again? Enter 'y' for yes and 'n' for no.");
                string answer = Console.ReadLine();
                PlayAgain(answer);

            }
        }

        public bool CheckIfYouWon(bool[] guessed, int numberofletters, char[] lettersarray)
        {

            for (int i = 0; i < numberofletters; i++)
            {

                if (guessed[i] == false)
                {

                    break;

                }
                else
                {

                    if (i == numberofletters - 1)
                    {
                        Console.Clear();
                        PrintWord(lettersarray, guessed, numberofletters);
                        Console.WriteLine("\nYou Win!");
                        return true;

                    }
                    else
                    {

                        continue;

                    }

                }

            }

            return false;

        }

        public void PlayAgain (string answer)

        {
           
            if (answer == "y")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hangman!");
                ChooseWord();

            }
            else if (answer == "n")
            {

                Console.Clear();
                Environment.Exit(0);
              
            }
            else
            {

                Console.WriteLine("Please enter 'y' or 'n' in lowercase.");
                string answer2 = Console.ReadLine();
                PlayAgain(answer2);
            }

        }

    }
}