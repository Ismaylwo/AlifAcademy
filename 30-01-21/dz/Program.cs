using System;
namespace dz
{
        class Program
    {     static void Main(string[] args)
        {
            DocumentWorker document = new DocumentWorker();
            string pro = "2332";
            string exp = "23332";
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            if ( key == "") {
                document = new DocumentWorker();
            }
            else if ( key == pro){
                document = new ProDocumentWorker();
            }
            else if ( key == exp) {
                document = new ExpertDocumentWorker();
            }
            else {
                Console.WriteLine("Ключ не совпадает вы можете исползовать демо версия");
            }
            Console.WriteLine("Введите команды для работы с документом: 1-Открыть документ, 2-Редактировать документ, 3-Сохранить");
            int command = int.Parse(Console.ReadLine()); 
            switch (command)
            {
                 case 1:{
                    document.OpenDocument(); 
                 }break;
                case 2:{
                     document.EditDocument();
                }break;
                case 3:{
                    document.SaveDocument();
                    }break;
                default:{
                    Console.WriteLine("Неправильная команда"); 
                } break;
            }
            iPlayable play = new Player();
            iRecodable rec = new Player();
            play.Play();
            play.Pause();
            play.Stop();
            rec.Record();
            rec.Pause();
            rec.Stop();
        }
    }   
}   


