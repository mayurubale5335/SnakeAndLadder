using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        // UC-1
        const int No_Play = 0, Ladder = 1, Snake = 2; 

        int playerPosition = 0; // starting position
        // UC-2
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            return die;
        }

        // UC-3

        public void Game()
        {
            int option = random.Next(0, 3);

            switch (option)
            {
                case No_Play:
                    break;
                case Ladder:
                    this.playerPosition += DieRoll();
                    break;
                case Snake:
                    this.playerPosition += DieRoll();
                    break;
            }
        }
    }
}
