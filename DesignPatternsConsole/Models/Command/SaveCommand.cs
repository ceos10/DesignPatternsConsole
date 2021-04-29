namespace DesignPatternsConsole.Models.Command
{
    public class SaveCommand : ICommand
    {
        private readonly Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        public void Execute() => document.Save();
    }
}
