using System;

namespace Hangman
{
    public class WordList
    {

        string[] words = new string[] { "that", "have", "with", "this", "from", "they", "will", "would", "there", "their", "what", "about", "which", "when", "make", "like", "time", "just", "know", "take", "person", "into", "year", "your", "good", "some", "could", "them", "other", "than", "then", "look", "only", "come", "over", "think", "also", "back", "after", "work", "first", "well", "even", "want", "because", "these", "give", "most" , "aboard", "absorb", "afghan", "assign", "cement", "chorus", "cleave", "cornea", "crunch", "debris", "delved", "drawer", "duress", "easily", "embryo", "exotic", "eyelet", "fedora", "genius", "giggle", "gossip", "helmet", "heroic", "kidney", "loathe", "mallet", "mortar", "murmur", "nephew", "parody", "peruse", "ponder", "racial", "ransom", "rascal", "realty", "reason", "reckon", "relish", "rugged", "scythe", "sequel", "shovel", "simmer", "sourly", "stench", "talons", "tiring", "tissue", "virtue", "weasel", "widget", "wizard", "wombat" };

        public WordList()
        {
            
        }

        public string ChooseRandomWord()
        {

            Random rnd = new Random();
            int arrayindex = rnd.Next (0, 47);
            string chosenword = words[arrayindex];
            return chosenword;

        }
    }
}