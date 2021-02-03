using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "D", "Z", "Z", "Z" , "D"};
            int[] newArray1 = { 2, 3, 3, 3, 3};
            double[] newArray2 = { 2.3, 3.3, 3.3, 3.2 };
            decimal[] newArray3 = { 3.3m, 3.3m, 3.3m, 3.2m };
            Console.Write("Элементи массива :");
            foreach (var item in newArray)
            {
                Console.Write($" {item} ");
            }
            Console.Write("\n");
            Console.WriteLine($"Элемент {ArrayHelper.Pop(ref newArray)} удален из массива");
            Console.Write("Элементи массива : ");
            foreach (var item in newArray1)
            {
                Console.Write($" {item} "); 

            }
            Console.Write("\n");
            Console.WriteLine("Длина массива : " + newArray1.Length);
            Console.WriteLine($"Добавляем новый элемент и выводим новый длина массива");
            Console.Write("Новый массив");
            foreach (var item in newArray1)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine($"Длина массива: {ArrayHelper.Push(ref newArray1, + 2)}");
            Console.Write("Элементи массива : ");
            foreach (var item in newArray2)
            {
                Console.Write($" {item} ");
            }
            Console.Write("\n");
            Console.WriteLine($" Элемент {ArrayHelper.Shift(ref newArray2)} удален из массива");
            Console.Write("Новый массив");
            foreach (var item in newArray2)
            {
                Console.Write($" {item} ");
            }
            Console.Write("\n");
            Console.Write("Элементи массива");
            foreach (var item in newArray3)
            {
                Console.Write($" {item} ");
            } 
            Console.WriteLine($" Длина массива : {newArray3.Length}");
            Console.Write("Новый массив");
            foreach (var item in newArray3)
            {
                Console.Write($" {item} ");
            }
                        Console.WriteLine($"Новый длина массива: {ArrayHelper.UnShift(ref newArray3,+ 2.2m)}");
        }  
    }

}

