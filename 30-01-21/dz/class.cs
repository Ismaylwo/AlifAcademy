using System;
namespace dz {
  class DocumentWorker {  
    public virtual void OpenDocument(){
        Console.WriteLine("Документ окрыть");
    }  
    public virtual void EditDocument(){
                Console.WriteLine("Редактирование документа доступно в версии Про");
    }
    public virtual void SaveDocument(){
         Console.WriteLine("Сохранение документа доступно в версии Про");
    }  
  }    
  class ProDocumentWorker : DocumentWorker{
         public override void EditDocument(){
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument(){
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    sealed class ExpertDocumentWorker : ProDocumentWorker{
        public override void SaveDocument(){
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    public interface iPlayable{
        public void Play(){}
        public void Pause();
        public void Stop();
    }
    public interface iRecodable{
        public void Record(){}
        public void Pause();
        public void Stop();
    }
    class Player : iPlayable, iRecodable{
        void iPlayable.Play(){
            Console.WriteLine("Проигрывается");
        }
        void iPlayable.Pause(){
            Console.WriteLine("На паузе");
        }
        void iPlayable.Stop(){
            Console.WriteLine("Остановленно");
        }
        void iRecodable.Record(){
            Console.WriteLine("Записывает");
        }
        void iRecodable.Pause(){
            Console.WriteLine("На паузе");
        }
        void iRecodable.Stop(){
            Console.WriteLine("Остановленно");
        }

    }
}