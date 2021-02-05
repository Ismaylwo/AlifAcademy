using System;
using System.Data.SqlClient;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data source=localhost; initial catalog=AlifAcademy; integrated security=true";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Подключено!");
                }
                var a = int.Parse(ConsoleReadLineWithText("Что вы хотите делать добавлять - 1 , Удалят по id - 2 , выбрат по id - 3 , Выбрат всё - 4 , Обновлять - 5"));
                if ( a == 1) {
                var firstname = ConsoleReadLineWithText("Введите FirstName ");
                var lastname = ConsoleReadLineWithText("Введите LastName ");
                var middlename = ConsoleReadLineWithText("Введите MiddleName ");
                var dateOfBirth = ConsoleReadLineWithText("Введите DateOfBirth ");      
                command.CommandText = "Insert into table2(" +
                    "FirstName," +
                    "LastName," +
                    "MiddleName," +
                    "DateOfBirth) Values(" +
                    $"'{firstname}'," +
                    $"'{lastname}'," +
                    $"'{middlename}'," +
                    $"'{dateOfBirth}')";
                var reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    SetConsoleColor(ConsoleColor.Green);
                    Console.WriteLine("Person added!");
                    SetConsoleColor(ConsoleColor.White);
                }
                }
                if ( a == 2) {
                var Id = int.Parse(ConsoleReadLineWithText("Введите id "));        
                command = connection.CreateCommand();
                command.CommandText = $"DELETE FROM table2 WHERE ID = {Id}";
                var reader = command.ExecuteNonQuery();
                if (reader > 0){
                    SetConsoleColor(ConsoleColor.Green);
                    Console.WriteLine($"Person deleted with {Id}!");
                    SetConsoleColor(ConsoleColor.White);
                }
                }
                if (a == 3) {
                var Id = int.Parse(ConsoleReadLineWithText("Введите id "));        
                command = connection.CreateCommand();
                command.CommandText = $"SELECT FROM table2 WHERE ID = {Id}";
                var reader = command.ExecuteNonQuery();
                    
                    if (reader > 0){
                    SetConsoleColor(ConsoleColor.Green);
                    Console.WriteLine($"Person selected with {Id}!");
                    SetConsoleColor(ConsoleColor.White);
                    }
                }
                if ( a == 4) {
                command.CommandText = $"SELECT * FROM table2";
                var reader = command.ExecuteReader();                 
                    if (reader > 0){
                    SetConsoleColor(ConsoleColor.Green);
                    Console.WriteLine($"Persons selected table2");
                    SetConsoleColor(ConsoleColor.White);
                    }
                }
                if ( a == 5) {
                    var firstname = ConsoleReadLineWithText("Введите FirstName ");
                    var lastname = ConsoleReadLineWithText("Введите LastName ");
                    var middlename = ConsoleReadLineWithText("Введите MiddleName ");
                    var dateOfBirth = ConsoleReadLineWithText("Введите DateOfBirth ");      
                    command.CommandText = "UPDATE table2 SET(LastName = '{lastname}' , FirstName = '{firstname}' , MiddleName = '{middlename}', DateOfBirth = '{dateOfBirth}')";
                    var reader = command.ExecuteNonQuery(); 
                    if (reader > 0){
                    SetConsoleColor(ConsoleColor.Green);
                    Console.WriteLine($"Persons Updated!");
                    SetConsoleColor(ConsoleColor.White);
                    }
                }
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine($"" +
                    $"Id:{read["Id"]}, \t" +
                    $"FirstName:{read["FirstName"]}, \t" +
                    $"LastName:{read["LastName"]}, \t" +
                    $"MiddleName:{read["MiddleName"]}, \t" +
                    $"DateOfBirth:{read["DateOfBirth"]}");
                }

        }
        
        public static string ConsoleReadLineWithText(string text)
        {
            Console.Write($"{text}:");
            return Console.ReadLine();
        }
         public static void SetConsoleColor (System.ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

    }
    
}
