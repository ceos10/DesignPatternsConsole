namespace DesignPatternsConsole.Models.Command
{
    public class OpenCommand : ICommand
    {
        private readonly Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public void Execute() => document.Open();
    }
}
