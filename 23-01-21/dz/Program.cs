using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ 1.a
           /* int A , B;
            int Summa = 0;
            Console.Write("Введите А - ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B - ");
            B = int.Parse(Console.ReadLine());
            for (int i = A + 1; i < B; i++) {
                Summa+=i;
            }
            Console.WriteLine($"Сумма чисел от А до B {Summa}"); 
            */
            // ДЗ 1.б
            /*int A , B;
            int nechet = 0;
            Console.Write("Введите А - ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите B - ");
            B = int.Parse(Console.ReadLine());
            for (int i = A + 1; i < B; i++) {
                if (i % 2 != 0) {
                    nechet=i;
                    Console.Write($"{nechet}   "); 
                }
            }
            */
            // ДЗ 2.а
            /* int A , B;
            Console.Write("Введите сторону прямоугольника (а) - ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону прямоугольника (b) - ");
            B = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= A ; i++){
                Console.Write("*");
            }
            Console.Write("\n");

            for (int j = 1; j <= B; j++){
                Console.Write("*");
                for (int i = 2; i < A; i++){
                    Console.Write(" ");
                }
                Console.Write("*" + "\n");
            }
            for (int i = 1 ; i <= A ; i++){
                Console.Write("*");
            }
            Console.Write("\n");
            */
            // ДЗ 2.b
            /*int A ;
            Console.Write("Введите длину треугольника - ");
            A = int.Parse(Console.ReadLine());
            for (int i = 1; i <= A; i++){
                for (int j = 1; j <= A; j++) {
                    if (j==1 || i==j || i==A) {
                       Console.Write("*");   
                    }
                    else Console.Write(" ");
                } 
                Console.Write("\n");
            }
           */
            // ДЗ 2.c
            /*int C;     
            Console.Write("Введите число - ");  
            C = int.Parse(Console.ReadLine());
            int a = C, b = C;
            for (int i = 1; i <= C; i++){
                for (int j = 1; j <= C*2; j++){
                    if (j==a || j==b || i == C) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                a--;
                b++;
                Console.Write("\n");
            }
            */
            // ДЗ 2.d
            /* int C;     
            Console.Write("Введите число - ");  
            C = int.Parse(Console.ReadLine());
            int a = C/2+1;
            for (int i = 1; i <= C; i++){
                for (int j = 1; j <= C; j++){
                    if (j == a || j == C - a + 1) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                if (i <= C / 2){
                    a--;
                }
                else
                {
                    a++;
                }
                Console.Write("\n");
            } */
            // ДЗ 3
            /*double balance = 1000 ;
            int K = 0 ;
            double P , prosent = 0 , S = 0; 
            while (balance <= 1100) {
                     Console.WriteLine("На сколько % увеличит сумму - ");
                     P = int.Parse(Console.ReadLine());
                     if (P > 0 && P < 25){
                         prosent = (balance * P) / 100;
                         balance+=prosent;
                     }
                     K++;   
                     S=balance;               
            }
            Console.WriteLine($"Количество месяцев - {K}");
            Console.WriteLine($"Итоговой сумма - {S}");
            */
            //Massive Д.З 1
            /*int N, Max , Min , Summa , Sred ;
            Console.Write("Введите N - ");
            N =int.Parse(Console.ReadLine());
            int[] arrN = new int[N];
            for (int i = 0; i < N; i++) {
                Console.Write("Введите элементы массива - ");
                arrN[i] =int.Parse(Console.ReadLine());
            }
            Max = arrN[0];
            Min = arrN[0];
            Summa = 0;
            Sred = 0;
            for (int j = 0 ;j < N; j++){
                if (Max < arrN[j]) {
                    Max = arrN[j];
                }
                if (Min > arrN[j]) {
                    Min = arrN[j];
                }
                if (arrN[j] % 2 == 1) {
                   
                Console.Write($"{arrN[j]} ");
                } 

                Summa+=arrN[j];
                Sred = Summa / N;

            }
            Console.Write("\n");
            Console.WriteLine($"Max - {Max} , Min - {Min}");
            Console.WriteLine($"Сумма элементов массива - {Summa}");
            Console.WriteLine($"Среднее арифметическое значение - {Sred}");    
            */
            // ДЗ 3.2
            /*int N;
            Console.Write("Введите N - ");
            N =int.Parse(Console.ReadLine());
            int[] arrN = new int[N];
            for (int i = 0; i < N; i++) {
                Console.Write("Введите элементы массива - ");
                arrN[i] =int.Parse(Console.ReadLine());
            }
            Array.Reverse(arrN);
            foreach (var obr in arrN)
            {
                Console.Write(obr + " ");
            }
            */
            // ДЗ 3.3
           int N , Count , Index;
          Console.Write("Введите N - ");
          N = int.Parse(Console.ReadLine());
          int[] arrN = new int[N];
          for (int i = 0 ; i < arrN.Length; i++) {
              Console.Write($"Введите {i}-й элемент массива  ");
              arrN[i] = int.Parse(Console.ReadLine());
          }
          foreach (var itemsArr in arrN)
          {
              Console.Write($" {itemsArr} ");
          }
          Console.Write("\n");
          Console.Write("Введите Count - ");
          Count = int.Parse(Console.ReadLine());
          Console.Write("Введите Index - ");
          Index = int.Parse(Console.ReadLine());
          int[] newArrN = new int[Count];
          for (int i = 0; i < Count; i++) {
              if (i+Index < arrN.Length)
              {
                  newArrN[i] = arrN[i+Index];
              }
              else
              {
                  newArrN[i] = 1;
              }
          }
            Console.Write("Новый массив");
            foreach (var item in newArrN)
            {
                Console.Write($" {item} ");
            }
           
        }
    }
}
