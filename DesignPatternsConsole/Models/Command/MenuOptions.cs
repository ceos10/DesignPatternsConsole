namespace DesignPatternsConsole.Models.Command
{
    public class MenuOptions
    {
        private readonly ICommand _openCommand;
        private readonly ICommand _saveCommand;
        private readonly ICommand _closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            _openCommand = open;
            _saveCommand = save;
            _closeCommand = close;
        }
        public void ClickOpen()
        {
            _openCommand.Execute();
        }
        public void ClickSave()
        {
            _saveCommand.Execute();
        }
        public void ClickClose()
        {
            _closeCommand.Execute();
        }
    }
}
