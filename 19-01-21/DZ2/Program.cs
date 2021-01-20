using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A , B , C , X1 , X2;
            A = 1.40;
            B = -5.50;
            C = 0.60;
            X1 = Math.Abs(A - C);
            X2 = Math.Abs(B - C);
            Console.WriteLine($"AC = {Math.Round(X1,2)}");
            Console.WriteLine($"BC = {Math.Round(X2,2)}");
            Console.WriteLine("AC+BC = " + (Math.Round(X1+X2,2)));
        }
    }
}
