using _02ISendable;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02SendToolFactory
{
    public abstract class SendToolFactory
    {
        public static string GetAssembly()
        {
            //拿到的是exe或者dll文件的所在路径 
            //return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["AssemblyString"]);
            return ConfigurationManager.AppSettings["AssemblyString"];
        }

        public static string GetObjectType()
        {
            return ConfigurationManager.AppSettings["TypeString"];
        }

        public static ISendable GetInstance()
        {
            try
            {
                //先加载程序集  然后通过程序集中的指定的类名称  获取到该类对象
                //加载程序集 
                Assembly assembly = Assembly.Load(GetAssembly());
                //创建类的实例 
                object obj = assembly.CreateInstance(GetObjectType());
                return obj as ISendable;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
