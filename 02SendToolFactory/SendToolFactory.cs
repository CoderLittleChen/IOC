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
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["AssemblyString"]);
        }

        public static string GetObjectType()
        {
            return ConfigurationManager.AppSettings["TypeString"];
        }

        public static ISendable GetInstance()
        {
            try
            {
                //加载程序集
                Assembly assembly = Assembly.LoadFile(GetAssembly());
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
