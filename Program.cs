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

        }

        public void ConvertWordToArray()
        {



        }

        public void AcceptGuess()
        {



        }

        public void CheckGuess()
        {



        }

        public void OutputGuessResult()
        {



        }

    }
}
