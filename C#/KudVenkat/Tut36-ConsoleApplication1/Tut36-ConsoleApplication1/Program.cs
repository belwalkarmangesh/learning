using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string message);
namespace Tut36_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hello");
            Console.Read();
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
