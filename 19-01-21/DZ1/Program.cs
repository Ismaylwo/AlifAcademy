using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a , b , c;
            a = 16.80;
            b = 12.40;
            c = Math.Sqrt(a*b);          
            Console.WriteLine($"Резултать : {Math.Round(c,2)}");

        }
    }
}
