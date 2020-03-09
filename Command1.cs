using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Command
{
    class Command1 : ICommand
    {
        private Receiver receiver;
        public Command1()
        {
            receiver = new Receiver();
        }

        public void Execute()
        {
            Console.WriteLine("Command is being executed from Command1...");
            receiver.Action1();
        }
    }
}
