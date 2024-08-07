using DesignPattern.BehavioralDesignPattern.CommandDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.CommandDesignPattern
{
    public class ExampleCommandDesignPattern
    {
        public void Run()
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
