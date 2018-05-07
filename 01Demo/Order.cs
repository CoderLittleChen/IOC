using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    public class Order
    {
        //private readonly SqlServerDal dal = new SqlServerDal();
        //private readonly AccessDal dal = new AccessDal();

        private IDataAccess _ida;
        public Order(IDataAccess ida)
        {
            _ida = ida;
        }

        public void Add()
        {
            _ida.Add();
        }
    }
}
