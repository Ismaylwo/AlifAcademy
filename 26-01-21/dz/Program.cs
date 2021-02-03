using System;


namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            //ДЗ 1
            /*double side1 , side2;
            Console.Write("Введите side1 - ");
            side1 09 double.Parse(Console.ReadLine());
            Console.Write("Введите side2 - ");
            side2 = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(side1 , side2);
            Console.WriteLine($"Площадь прямоугольника = {rect.AreaCalc()}");
            Console.WriteLine($"Периметер прямоугольника = {rect.PerCalc()}");
            */
            // ДЗ 2
            /*string nameBook , nameAuthor , nameTitle, nameContent;
            Console.Write("Введите имя книги - ");
            nameBook = Console.ReadLine();
            Console.Write("Введите имя автора - ");
            nameAuthor = Console.ReadLine();
            Console.Write("Введите имя титулки - ");
            nameTitle = 'Console.ReadLine();
            Console.Write("Введите контент книги - ");
            nameContent = Console.ReadLine();
            Book book = new Book(nameBook);
            Author author = new Author(nameAuthor);
            Title title = new Title(nameTitle);
            Content content = new Content(nameContent);
            book.ShowNameBook();
            author.ShowNameAuthor();
            title.ShowNameTitle();
            content.ShowNameContent();*/
            //ДЗ 3
            //Laptop laptop = new Laptop("Dell" , "XPS 15" , "Intel Cori9 10Gen" , "Samsung" , 16 , "Toshiba" , 1000 , "GeForce GTX 1650 Ti");
            //laptop.GetLaptopInfo();

            Converter converter = new Converter(0.1100, 0.1200, 0.150);
            converter.Kurs();     
            int money , Vibor;
            double Tjs; 
            Console.WriteLine("Какую валюту хотите поменьят ?");
            Console.WriteLine($"1 - Usd , 2 - Eur , 3 - Rub , 4 - Som ");
            money = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму - ");
            Tjs = double.Parse(Console.ReadLine());
            if (money == 4)

            {
                Console.WriteLine($"Выберите на какую валюту 1 - Usd , 2 - Eur , 3 - Rub ");
                Vibor = int.Parse(Console.ReadLine());
                converter.Vibor = Vibor;
    
            }
            converter.money = money;
            converter.Tjs = Tjs; 
            converter.GetMoney();



           
        }
    }
    /*class Rectangle{
        public double side1, side2;

        public Rectangle(double side1 , double side2){

                    this.side1 = side1;
                    this.side2 = side2;
        }
        public double AreaCalc(){

            return side1 * side2;
        }
        public double PerCalc(){
            
            return (side1 + side2) * 2;
        }
        public double Area { get; }
        public double Per { get; }
    }*/
    /*class Book{
            public string nameBook{ get; set;}
            public Book(string nameBook){
                this.nameBook = nameBook;
            }
            public void ShowNameBook(){
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Имя книги : {nameBook}");
            } 
    }
        class Author{
            public string nameAuthor{ get; set;}
            public Author(string nameAuthor){
                this.nameAuthor = nameAuthor;
            }
            public void ShowNameAuthor(){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Имя автора книги : {nameAuthor}");
            }
        }
        class Title{
            public string nameTitle {get; set;}
            public Title(string nameTitle){
                    this.nameTitle = nameTitle;
            }
            public void ShowNameTitle(){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Имя титулки : {nameTitle}");
            }
        }
        class Content{
            public string nameContent {get; set;}
            public Content(string nameContent){
                    this.nameContent = nameContent;
            }
            public void ShowNameContent(){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Контент : {nameContent}");
            }
        }
    */
    /*class Laptop{
        public string model{get; set;}
        public string name{ get; set;}
        public string cpu {get; set;}
        public string ram {get; set;}
        public int sizeram {get; set;}
        public string hd{get; set;}
        public int sizehd{get; set;}
        public string vram{get; set;}
        public Laptop(string model , string name , string cpu , string ram ,int sizeram ,  string hd , int sizehd , string vram){
                    this.model = model;
                    this.name = name;
                    this.cpu = cpu;
                    this.ram = ram;
                    this.sizeram = sizeram;
                    this.hd = hd;
                    this.sizehd = sizehd;
                    this.vram = vram;
        }
        public void GetLaptopInfo(){
            Console.WriteLine($"Модель : {model} , Имя : {name} , Процессор : {cpu} , RAM : {ram} , Объём RAM : {sizeram} , Hard Disk : {hd} , Объём Hard Disk : {sizehd} , VideoRAM : {vram}");
        }
    }*/

}
