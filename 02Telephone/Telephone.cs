using _02ISendable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Telephone
{
    public class Telephone : ISendable
    {
        public void Send(string message)
        {
            Console.WriteLine("Telephone:" + message);
        }
    }
}
