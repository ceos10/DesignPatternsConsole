using DesignPatternsConsole.Models.Singleton;

namespace DesignPatternsConsole.Logic.Creational
{
    public class SingletonPattern
    {
        public void RunExample()
        {
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
