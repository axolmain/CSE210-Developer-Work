using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Unit03.game
{
    public class TerminalService
    {
        public void UserInput()
        {
            /// Import what I need to create lists for updating here
            Words sendWordThings = new Words();
            Jumper jumperMan = new Jumper();
            sendWordThings.sendWord();
            List<string> _RealWord = sendWordThings.ChosenWord;
            List<string> _HiddenWord = sendWordThings.guessingWord;

            do
            {
                /// Printing and getting player input
                Console.WriteLine($"The word is: {string.Join("", _HiddenWord)}");
                Console.WriteLine("Please guess a letter:");
                char PlayersGuessChar = Console.ReadKey().KeyChar;
                string PlayersGuess = PlayersGuessChar.ToString();
                if (_HiddenWord.Contains(PlayersGuess))
                {
                    Console.WriteLine("You've already guessed this");
                }
                if (_RealWord.Contains(PlayersGuess))
                {
                    int index = _RealWord.IndexOf(PlayersGuess);
                    _HiddenWord[index] = PlayersGuess;
                }
                else
                {
                    jumperMan.wrongGuess();
                    Console.WriteLine("\nWRONG");
                }
                Console.WriteLine();
                jumperMan.createJumper();
                if (jumperMan.Player.Count < 4)
                {
                    Console.WriteLine("You lost");
                    break;
                }

                if (!_HiddenWord.Contains("_"))
                {
                    Console.WriteLine("Congrats! You won :)");
                    Console.WriteLine($"The world was {string.Join("", _RealWord)} :)");
                }
                Console.WriteLine();
            } while (_HiddenWord.Contains("_"));
        }
    }
}
