namespace Command
{
    public class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Close();
        }
    }
}