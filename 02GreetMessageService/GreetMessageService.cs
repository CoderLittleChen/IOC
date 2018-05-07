using _02Email;
using _02ISendable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GreetMessageService
{
    public class GreetMessageService
    {
        ISendable _sendTool;
        public GreetMessageService(ISendable sendTool)
        {
            _sendTool = sendTool;
        }

        public void Greet(string message)
        {
            _sendTool.Send(message);
        }
    }
}
