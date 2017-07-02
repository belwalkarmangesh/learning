using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="\"Mangesh\"";
            string one = "One\nTwo\nThree";
            string path = "c:\\dir\\folder\\newfolder";
            string verbatimnPath = @"c:\dir\folder\newfolder";
            Console.WriteLine(name);
            Console.WriteLine(one);
            Console.WriteLine(path);
            Console.WriteLine(verbatimnPath);
            Console.Read();
        }
    }
}
