using DesignPattern.BehavioralDesignPattern.CommandDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.CommandDesignPattern
{
    public class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Save();
        }
    }
}
