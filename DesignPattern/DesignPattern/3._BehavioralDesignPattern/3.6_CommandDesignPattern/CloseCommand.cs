using DesignPattern.BehavioralDesignPattern.CommandDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralDesignPattern.CommandDesignPattern
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
