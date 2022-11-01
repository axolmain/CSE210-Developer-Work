using System;
using Unit03.game;

namespace Unit03
{
    class Director
    {
        public void startGame()
        {
            Jumper createMan = new Jumper();
                TerminalService userInputs = new TerminalService();
                createMan.createJumper();
                char playAgain = 'y';
                /// While loop that deals with inputs and changes the output accordingly
                do
                {
                    userInputs.UserInput();
                    Console.WriteLine("Play again? (y/n)");
                    playAgain = Console.ReadKey().KeyChar;
                } while (playAgain == 'y');
                Console.WriteLine("Thanks for playing!");
        }
    }
}
