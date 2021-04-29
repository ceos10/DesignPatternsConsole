namespace DesignPatternsConsole.Models.Command
{
    public class CloseCommand : ICommand
    {
        private readonly Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        public void Execute() => document.Close();
    }
}
