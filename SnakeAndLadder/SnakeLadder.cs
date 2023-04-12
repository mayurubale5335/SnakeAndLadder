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
        int playerPosition = 0; // starting position
        // UC-2
        Random random = new Random();
        public void DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine(die);
            
        }
        
    }
}
