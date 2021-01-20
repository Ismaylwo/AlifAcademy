using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int K , A , B;
            K = 202;
            A = 1;
            B = (((K + A - 2) % 7) + 1 );
            Console.WriteLine($"Номер дня недели: {B}");
        }
    }
}
