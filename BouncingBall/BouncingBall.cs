using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    public class BouncingBall
    {
        /*
        private bool isValidExperiment(double height, double bounceRate)
        {
            return height > 0 && bounceRate > 0 && bounceRate < 1;
        }
        */

        public static int bouncingBall(double height, double bounceRate, double window)
        {
            int ballSeen = 1; // number of times the boy's mother sees the ball
            // If the ball bounces, the ball will be seen at least once
            double reboundHeight;

            if (height <= 0 || bounceRate <= 0 || bounceRate >= 1 || window > height)
            {
                // Invalid inputs
                return -1;
            }

            // Keep track of rebounding height
            reboundHeight = height;

            /*
            if (isValidExperiment(height, bounceRate))
            {
                while (reboundHeight > window)
                {
                    reboundHeight *= bounceRate;
                    ballSeen++;
                }
            }
            */

            while (reboundHeight > window)
            {
                reboundHeight *= bounceRate;
                ballSeen++;
            }

            return ballSeen;
        }
    }
}
