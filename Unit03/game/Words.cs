using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit03.game
{
    public class Words
    {
        /// <summary>
        /// creates single word and function to send that word into the world
        /// </summary>
        public List<string> ChosenWord = new List<string>() 
            { "w", "o", "r", "d", "l", "e" };
        public List<string> guessingWord = new List<string>();
        public void sendWord()
        {
            int WordLength = ChosenWord.Count;
            foreach (var letter in Enumerable.Range(0, WordLength))
            {
                guessingWord.Add("_");
            }
            
        }
    }
}
