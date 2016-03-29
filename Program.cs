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

        string chosenword = "";

        public void ChooseWord()
        {

            WordList words = new WordList();
            chosenword = words.ChooseRandomWord();

        }

        public void ConvertWordToArray()
        {

            // Use ToCharArray to convert string to array.
            char[] lettersarray = chosenword.ToCharArray();

            for (int i = 0; i < lettersarray.Length; i++)
            {
                // Display each blank space.
                Console.Write("_");
            }

        }

        public void AcceptGuess()
        {

            Console.WriteLine("Please enter a letter to guess:");
            string guess = Console.ReadLine();

        }

        public void ParseInputData()
        {

            //check input is only one letter

        }

        public void CheckGuess()
        {

            //compare guess to elements in array

        }

        public void OutputGuessResult()
        {

            //output dashes and letters where they have been guessed

        }

    }
}
