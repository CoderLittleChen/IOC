using _02ISendable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02WeChat
{
    public class WeChat : ISendable
    {
        public void Send(string message)
        {
            Console.WriteLine("WeChat：" + message);
        }
    }
}
