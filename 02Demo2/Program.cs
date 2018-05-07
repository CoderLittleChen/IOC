using _02GreetMessageService;
using _02ISendable;
using _02SendToolFactory;
using _02Telephone;
using _02WeChat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message = "新年快乐！！";
            //ISendable sendable = new WeChat();
            //GreetMessageService service = new GreetMessageService(sendable);
            //service.Greet(message);
            //Console.ReadKey();

            //拿到的是exe或者dll文件的所在路径
            //Console.WriteLine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            //Console.ReadKey();


            //使用工厂模式创建实例
            string message = "新年快乐";
            ISendable greetTool = SendToolFactory.GetInstance();
            GreetMessageService service = new GreetMessageService(greetTool);
            service.Greet(message);
            Console.ReadKey();
        }
    }
}
