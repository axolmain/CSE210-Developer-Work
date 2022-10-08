using System;

namespace Unit02.game
{
    public class Card
    {
        /// <summary>
        /// Creates initial cards
        /// </summary>
        public int firstCard = 0;
        public int secondCard = 0;
        
        /// <summary>
        /// Function to create the new random cards
        /// </summary>
        public void getCards()
        {

            Random rnd = new Random();
            firstCard = rnd.Next(14);
            secondCard = rnd.Next(14);
        }

    } 
}