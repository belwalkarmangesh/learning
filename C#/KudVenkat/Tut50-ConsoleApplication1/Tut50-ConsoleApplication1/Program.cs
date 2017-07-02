using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut50_ConsoleApplication1
{
    class Program:Assembly1.Assembly1Class1
    {
        static void Main()
        {
            Assembly1.Assembly1Class1 a1 = new Assembly1.Assembly1Class1();
            Program p = new Program();
            p.Print();

            Console.Read();
        }

        public void Print()
        {
            base.ID = 100;

            Console.WriteLine(base.ID);
        }
    }
}
