using System;
using System.IO;

namespace Hangman
{
    public class WordList
    {
        public WordList()
        {
            
        }

        public string ChooseRandomWord()
        {
            string path = @"Words.txt";
            string[] lines = File.ReadAllLines(path);
            Random rand = new Random();
            return lines[rand.Next(lines.Length)];

        }
    }
}