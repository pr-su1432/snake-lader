using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandlader
{
    internal class Snakeandlader
    {
        int position1 = 0, position2 = 0, count = 0;
        int Player1, Player2;
        public void rollDice()
        {

            Random random = new Random();
            while (position1 != 100 && position2 != 100)
            {
                Player1 = random.Next(0, 7);
                Player2 = random.Next(0, 7);
                int check1 = random.Next(0, 3);
                int check2 = random.Next(0, 3);
                count++;

                switch (check1)
                {
                    case 0:
                        break;
                    case 1:
                        position1 += Player1;
                        break;
                    case 2:
                        position1 -= Player1;
                        break;
                }

                if (position1 < 0)
                    position1 = 0;
                if (position1 > 100)
                    position1 -= Player1;

                switch (check2)
                {
                    case 0:
                        break;
                    case 1:
                        position2 += Player2;
                        break;
                    case 2:
                        position2 -= Player2;
                        break;
                }

                if (position2 < 0)
                    position2 = 0;
                if (position2 > 100)
                    position2 -= Player2;

                Console.WriteLine("Dice roll: " + count + " Position of Player 1: " + position1);
                Console.WriteLine("Dice roll: " + count + " Position of Player 2: " + position2);
            }
            if (position1 == 100)
                Console.WriteLine("Player 1 won the match.");
            else
                Console.WriteLine("Player 2 won the match.");
            Console.WriteLine("Dice rolled for " + count + " no. of time.");

        }
    }
}








