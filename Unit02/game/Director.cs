using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;
using static Unit02.game.Card;

namespace Unit02.game // Note: actual namespace depends on the project name.
{
    public class Director
    {
        public void Game()
        {
            int score = 300;
            Random rnd = new Random();
            char keepPlaying = 'y';
            Card cards = new Card();
            cards.getCards();
            int playerCard = cards.firstCard;

            do
            {
                Console.WriteLine($"The card is: {playerCard}");
                Console.WriteLine("Higher or lower? [h/l] ");
                char higherLower = Console.ReadKey().KeyChar;
                Console.WriteLine($"\nThe next card was:  {cards.secondCard}");

                /// Change score
                if (higherLower == 'h' & score != 0)
                {
                    if (playerCard < cards.secondCard)
                    {
                        score += 100;
                    }
                    else
                    {
                        score -= 75;
                    }
                }
                if (higherLower == 'l' & score != 0)
                {
                    if (playerCard > cards.secondCard)
                    {
                        score += 100;
                    }
                    else
                    {
                        score -= 75;
                    }
                }

                /// print bottom half of screen
                Console.WriteLine($"Your score is: {score}");
                Console.WriteLine("Play again? [y/n] ");
                keepPlaying = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if (keepPlaying == 'y')
                {
                    playerCard = cards.secondCard;
                    cards.getCards();
                    while (playerCard == cards.secondCard)
                    {cards.getCards();}
                }
            } while (keepPlaying == 'y' & score != 0);

            Console.WriteLine("Thanks for playing :)");
        }
    }
}