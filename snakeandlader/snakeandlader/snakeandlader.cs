using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandlader
{
    internal class Snakeandlader
    {

        public int startpositon = 0, playerposition = 0;
        const int noPlay = 0, snake = 1, ladder = 2;
        Random random = new Random();
        public void diceroll()
        {
            int diceNo = random.Next(1, 6);
                switch (random.Next(0, 3))
                {
                case noPlay:
                    playerposition += 0;
                    Console.WriteLine("Player got noPlay Option");
                    break;
                case snake:
                   playerposition -= diceNo;
                    break;
                case ladder:
                    playerposition += diceNo;
                    break;
                default:
                    break;
                }
            Console.WriteLine("dice value of player is{0} with position at {1} " , diceNo,playerposition);

        }


    }
}



