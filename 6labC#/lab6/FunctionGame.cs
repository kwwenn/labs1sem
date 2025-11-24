using System;

namespace _3lab
{
    public static class FunctionGame
    {
        public static double CalculateFunction(int a, int b)
        {
            const double pi = Math.PI;
            return (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) /
                   Math.Pow(Math.Sin((pi / 2) + a), 2);
        }
    }
}