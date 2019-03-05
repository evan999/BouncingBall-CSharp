using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    public class BouncingBall
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            int seen = 0; // number of times the boy's mother sees the ball
            double rebound;

            if (h <= 0 || bounce <= 0 || bounce >= 1 || window > h )
            {
                // Invalid inputs
                return -1;
            }

            if (h > window)
            {
                seen++;
            }

            rebound = h;

            while (rebound > window)
            {
                rebound *= bounce;
                seen++;            
            }

            return seen;
        }
    }
}
