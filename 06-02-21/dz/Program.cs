using System;
using System.Collections.Generic;
namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] animals = new string[] { "Ant" , "bison" , "camel" , "duck" , "elephant"};
            Console.Write("Виберите метод: 1 - Pop , 2 - Push , 3 - Shift , 4 - unShift , 5 - SliceBeg, 6 - SliceBegEnd - ");
            int a = int.Parse(Console.ReadLine());
            if ( a == 1) {
                Console.WriteLine("Метод Pop");
                Console.WriteLine(ArrayHelper.Pop<string>(ref animals));
            }
            else if ( a == 2) {
                Console.WriteLine("Метод Push");
                Console.WriteLine("Введите новый элемент");
                string push = Console.ReadLine();
                Console.WriteLine(ArrayHelper.Push<string>(ref animals , push));
            }
            else if ( a == 3) {
                 Console.WriteLine("Метод Shift");
                 Console.WriteLine(ArrayHelper.Shift<string>(ref animals));
            }
            else if ( a == 4) {
                Console.WriteLine("Метод UnShift");
                Console.WriteLine("Введите новый элемент");
                string unShift = Console.ReadLine();
                Console.WriteLine(ArrayHelper.UnShift<string>(ref animals, unShift));
            }
            else if ( a == 5) {
                Console.WriteLine("Метод SliceBegin");
                Console.WriteLine("Введите Beg Index");
                int Begin = int.Parse(Console.ReadLine());
                foreach (var item in ArrayHelper.Slice<string>(ref animals , Begin))
                {
                    Console.Write($" {item} ");
                }
            }
            else if ( a == 6) {
                Console.WriteLine("Метод SliceBegin");
                Console.WriteLine("Введите Beg Index");
                int Begin = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите End Index");
                int End = int.Parse(Console.ReadLine());
                foreach (var item in ArrayHelper.Slice<string>(ref animals , Begin , End))
                {
                    Console.Write($" {item} ");
                }
            }
            else {
                Console.WriteLine("Вы ввели неверную команду !");
            }
        }
    }
}

