using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int Experience;
            Console.Write("Введите стаж работи - ");
            Experience = int.Parse(Console.ReadLine());
            Employee employee = new Employee("Ismoil" , "Shoev"){
    
                Salary = 700,
                position = "Programmer",
            };
            employee.Experience = Experience;
            employee.GetInfo2();
            employee.GetInfo();

        }
    }
}
