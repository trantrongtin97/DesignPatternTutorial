
using DesignPattern.BehavioralDesignPattern.CommandDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.CommandDesignPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Open();
        }
    }
}
