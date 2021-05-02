using DesignPatternsConsole.Models.Command;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class CommandPattern : IPattern
    {
        public void RunExample()
        {
            Document document = new Document();
            
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
            
            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();
        }
    }
}
