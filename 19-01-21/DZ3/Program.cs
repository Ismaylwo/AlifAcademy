using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 , y1 , x2 , y2 , z;
            x1 = -6.20;
            y1 = 5.20;
            x2 = 2.10;
            y2 = 9.80;
            z = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine($"Резултать = {Math.Round(z,2)}");

        }
    }
}
