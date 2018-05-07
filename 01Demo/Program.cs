using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 手动实现依赖注入
            //通过这样实现，当更换数据库的时候
            //在外部创建依赖对象
            //SqlServerDal dal = new SqlServerDal();
            //AccessDal dal = new AccessDal();
            ////通过构造函数注入依赖
            //Order order = new Order(dal);
            //order.Add();
            //Console.ReadKey();
            #endregion

            #region 通过IOC 容器 Ninject实现

            //创建IOC容器
            StandardKernel kernel = new StandardKernel();
            //注册依赖
            kernel.Bind<IDataAccess>().To<SqlServerDal>();
            //获取目标对象
            Order order = kernel.Get<Order>();
            order.Add();
            Console.ReadKey();

            #endregion

        }
    }
}
