using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过这样实现，当更换数据库的时候

            //在外部创建依赖对象
            //SqlServerDal dal = new SqlServerDal();
            AccessDal dal = new AccessDal();
            //通过构造函数注入依赖
            Order order = new Order(dal);
            order.Add();
            Console.ReadKey();
        }
    }
}
