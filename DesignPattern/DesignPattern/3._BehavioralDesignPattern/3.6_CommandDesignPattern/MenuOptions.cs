using DesignPattern.BehavioralDesignPattern.CommandDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.CommandDesignPattern
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}
