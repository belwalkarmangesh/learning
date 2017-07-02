using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut63_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SamplePartialClass class1=new SamplePartialClass();

            class1.PublicMethod();

            Console.Read();
        }
    }
}
