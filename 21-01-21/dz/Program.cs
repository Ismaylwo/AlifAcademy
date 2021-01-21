using System;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  // ДЗ - 1.1
            int A, B ;
            Console.Write("Введите А - ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B - ");
            B = Convert.ToInt32(Console.ReadLine());
            if ( A != B) {
                    if (A > B) {
                       B = A;
                       Console.Write($"A - {A} , B - {B}");
                    }
                    else {
                        A = B;
                        Console.Write($"A - {A} , B - {B}");
                    }
            }
            else if ( A == B) {
                A = 0;
                B = 0;
                Console.Write($"A - {A} , B - {B}");
            } 
                  
            */
            // ДЗ - 1.2
           /* double operand1, operand2, result;
            string sign;
            Console.Write("Введите число  ");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число  ");
            operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак арифметической операции ");
            sign = Console.ReadLine();
            switch(sign){
                case "+": {
                    result = operand1 + operand2;
                    Console.WriteLine("Результат = " + result);
                }break;
                case "-": {
                    result = operand1 - operand2;
                    Console.WriteLine("Результат = " + result);
                }break;
                case "*": {
                    result = operand1 * operand2;
                    Console.WriteLine("Результат = " + result);
                }break;
                case "/": {
                    if ((operand1 == 0) || (operand2 == 0)){
                        Console.WriteLine("Деления на 0 не возможно");
                    }
                    else {
                        result = operand1 / operand2;
                    Console.WriteLine("Результат = " + result);  
                    }
                }break;
            } 
            */
            // ДЗ - 1.3
            /*int o;
            Console.Write("Введите промежуток - ");
            o = int.Parse(Console.ReadLine());
            if (o >= 0 && o <= 14) Console.WriteLine("Число входит в промежуток от 0 до 14");
            else if (o >= 15 && o <= 35 ) Console.WriteLine("Число входит в промежуток от 15 до 35");
            else if (o >= 36 && o <= 50 ) Console.WriteLine("Число входит в промежуток от 36 до 50");
            else if (o >= 51 && o <= 100 ) Console.WriteLine("Число входит в промежуток от 51 до 100");
            else Console.WriteLine("Число не входит ни в одной промежуток");
            
            */
            /* ДЗ 2.1
            int Sale1 = 3, Sale2 = 5;
            int Result;
            Console.Write("Введите сумму покупки - ");
            bool Parsed = int.TryParse(Console.ReadLine() , out var payment);
            if (payment > 0) {
                 if (payment > 500 && payment <=1000) {
                    Result = (payment * Sale1) / 100;
                    payment-=Result;
                    Console.WriteLine("Вы совершали покупку на сумму 500 больше и получили 3% скидку , сумма покупки: " + payment );
            }
            else if (payment > 1000) {
                    Result = (payment * Sale2) / 100;
                    payment-=Result;
                    Console.WriteLine("Вы совершали покупку на сумму 1000 больше и получили 5% скидку , сумма покупки: " + payment );
            }
            else {
                Console.WriteLine("Вы совершали покупку на сумму " + payment);
            }
            }
            else {
                 Console.WriteLine("Пожалуйста введите cоответсвующий число");
            }
            if (!Parsed) {
                Console.WriteLine("Пожалуйста введите cумму");
            }
            */
            // ДЗ 2.2
            /*int A , B , C , D;
            int proiz = 1;
            Console.Write("Введите А , B , C , D - ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            if ((A < B && B < C) && (C < D)) {
                Console.WriteLine("Число расположены по возрастанию");
            }
            else if ((A == B && B == C ) && (C == D)){
                    proiz = A * B * C * D;
                    Console.WriteLine(proiz);
            }
            else if ((A < B) && (A < C) && (A < D)) Console.WriteLine(A);
            else if ((B < A) && (B < C) && (B < D)) Console.WriteLine(B);
            else if ((C < A) && (C < B) && (C < D)) Console.WriteLine(C);
            else Console.WriteLine(D);
            */
            int A , B , C;
            Console.Write("Введите А , B , C  - ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            int res1 , res2, res3;
            if (A >= B) res1 = A;
            else res1 = B;
            if ( C >= res1) res1 = C;
            if (A<=B) res2 = A;
            else res2 = B;
            if (C <=res2) res2 = C;
            res3 = A + B + C - res1 - res2;
            A = res1;
            B = res3;
            C = res2;
            Console.WriteLine($"Число А - {A} , Число B - {B} , Число C - {C} ");
            // Пришлось использоват интернет чтобы найти Оптимальное Решение!!! )
            // Повторения SWITCH EXPRESSION
            // Повторения загрузка проекта в GitHub через vscode...

        }
    }
}
