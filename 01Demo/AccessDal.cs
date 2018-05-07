using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    public class AccessDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("在Access数据库中添加一条记录");
        }
    }
}
