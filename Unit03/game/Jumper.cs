using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit03.game
{
    public class Jumper
    {
        /// <summary>
        ///  creates the jumper and two functions, one for initial creation and one for removing top layer
        /// </summary>
        public List<string> Player = new List<string>()
            {" ___", @"/___\", @"\   /", @" \ /", "  0", @" /|\", @" / \"};
        public void createJumper()
        {
            foreach (var row in Player)
            {
                Console.WriteLine(row);
            }
        }

        public void wrongGuess()
        {
            Player.RemoveAt(0);
        }
    }
}
