using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly1Class1
    {
       protected internal int ID = 101;
    }

    public class Assembly1Class2
    {
        public void SampleMethod()
        {
            Assembly1Class1 a1 = new Assembly1Class1();
            Console.WriteLine(a1.ID);

            Console.Read();
        }
    }
}
