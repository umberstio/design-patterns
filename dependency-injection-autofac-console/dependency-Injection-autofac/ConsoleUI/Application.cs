using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;
        public Application(IBusinessLogic businnesLogic)
        {
            _businessLogic = businnesLogic;
        }
        public void Run()
        {
            _businessLogic.ProcesseData();
        }

    }
}
