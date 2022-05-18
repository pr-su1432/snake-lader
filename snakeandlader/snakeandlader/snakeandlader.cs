using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakeandlader
{
    internal class Snakeandlader
    {

        int startpositon = 0, playerposition = 0;
        Random random = new Random();
        public void diceroll()
        {
            int diceno = random.Next(1, 6);
            Console.WriteLine("dice value of player is " + diceno);

        }


    }
}



