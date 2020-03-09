using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Command
{
    class Client
    {
        ICommand command;

        public Client()
        {
            command = new Command1();
        }

        public void DoTheThing()
        {
            Console.WriteLine("Client executing command...");
            command.Execute();
            Console.ReadKey();
        }
    }
}
