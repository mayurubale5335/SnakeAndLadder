using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to SnakeAndLadder Game");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.DieRoll();
            snakeLadder.Game();
            Console.ReadLine();
        }
       
        
    }
}
