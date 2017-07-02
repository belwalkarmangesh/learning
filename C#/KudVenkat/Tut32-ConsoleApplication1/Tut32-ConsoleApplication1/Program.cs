using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut32_ConsoleApplication1
{
    public abstract class Customer
    {
        public abstract void Print();

    }
    public interface ICustomer
    {

    }

    
    class Program:Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }

        static void Main(string[] args)
        {
            Customer c = new Program();
            c.Print();
            Console.Read();
        }
    }
}
