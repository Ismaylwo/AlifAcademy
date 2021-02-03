using System;
namespace Employee{
    class Employee{
        public string Name{get; set;}
        public string Surname{get; set;}
        public string position{get; set;}
        public int Salary {get; set;}
        public int Experience{get; set;}
        public Employee(string name , string surname){

                this.Name = name;
                this.Surname = surname;
        }
        public void GetInfo(){
          if (Experience > 10) {
                
                 Console.WriteLine("Налог от зарплати - " + (((Salary * 2) * 13 ) / 100) + " " + "Пенсионий Фонд - " + (((Salary * 2) * 1) / 100));
            }
          else  {
                
                 Console.WriteLine("Налог от зарплати - " + ((Salary * 13) / 100) + "  " + "Пенсионий Фонд - " + ((Salary * 1) / 100));
            }
        }
        public void GetInfo2(){
            Console.WriteLine($"Имя : {Name} \n Фамилия : {Surname} \n Дольжност : {position} \n Зарплата : {Salary}");
        }

    }
}