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
        const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Position=100;

        int playerPosition = 0, count = 0; // starting position
        // UC-2
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            count++;
            return die;
        }

        // UC-3

        public void Game()
        {
            while (this.playerPosition < Winning_Position)
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
                        int dieroll = DieRoll();
                        if (this.playerPosition - dieroll > 0)
                        {
                            this.playerPosition += DieRoll();

                        }
                        break;
                }
                            Console.WriteLine("Player Position : " + playerPosition);
                        
                        if (this.playerPosition == Winning_Position)
                        {

                            Console.WriteLine("Player Position : " + playerPosition);
                            Console.WriteLine("Die Count : " + count);
                        }

                  
            }
           
        }
    }
}
