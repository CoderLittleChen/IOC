using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    public class SqlServerDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("在数据库添加一条订单");
        }
    }
}
