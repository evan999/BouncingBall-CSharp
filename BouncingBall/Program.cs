using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class Program
    {
        static void Main(string[] args)
        {
            // BouncingBall ball = new BouncingBall();
            double result = BouncingBall.bouncingBall(3.00, 0.66, 1.50);
            Console.WriteLine("Mother has seen the ball " + result + " times.");
            Console.ReadKey();
        }
    }
}
