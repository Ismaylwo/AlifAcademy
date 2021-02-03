using System;
namespace dz {

    class Converter

    {
        public double Usd{get; set;}
        public double Eur{get; set;}
        public double Rub{get; set;}
        public double Tjs{get; set;}
        public int money{get; set;}
        public int Vibor{get; set;}
        public Converter(double usd, double eur, double rub)
        {
            this.Usd = usd;
            this.Eur = eur;
            this.Rub = rub;
        }

        public double toUsd()
        {
            return Tjs * Usd ;
        }
        public double toEur()
        {
            return Tjs * Eur;
        }
        public double toRub ()
        {
            return Tjs * Rub;
        }
        public double fromUsd()
        {
            return  Tjs / Usd;
        }

        public double fromEur()
        {
            return Tjs / Eur;
        }
        public double fromRub()
        {
            return Tjs / Rub;

        }
        public void Kurs()
        {
            Console.WriteLine($"Курси к сомони на сегодня {DateTime.Now} : Usd - {Usd} , Eur - {Eur} , Rub - {Rub} ");
        }
        public void GetSom(){
             switch (Vibor)
                {
                    case 1: {
                        Console.Write($"Сумма конвертация {toUsd()}");
                    }break;
                    case 2: {
                        Console.Write($"Сумма конвертация {toEur()}");
                    }break;
                    case 3: {
                        Console.Write($"Сумма конвертация {toRub()}");
                    }break;
                    default: {
                        Console.Write("Вы не вибрали ни один вариант");

                    }break;
        }
        }
        public void GetMoney()
        {
            if (money == 1)
            {
                Console.Write($"Сумма конвертация {fromUsd()}");
            }
             else if (money == 2)

            {
                Console.Write($"Сумма конвертация {fromEur()}");
            }
            else if (money == 3)
            {
                Console.Write($"Сумма конвертация {fromRub()}");
            }
            else if (money == 4){
 switch (Vibor)
                {
                    case 1: {
                        Console.Write($"Сумма конвертация {toUsd()}");
                    }break;
                    case 2: {
                        Console.Write($"Сумма конвертация {toEur()}");
                    }break;
                    case 3: {
                        Console.Write($"Сумма конвертация {toRub()}");
                    }break;
                    default: {
                        Console.Write("Вы не вибрали ни один вариант");

                    }break;
                   
            }
            }
            
        }
        
}
}