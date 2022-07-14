using System;

namespace LearnProject.DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
            {
                return 10;
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(1, 2) + Math.Pow(5, 2))
            {
                return 5;
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(5, 2) + Math.Pow(10, 2))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
