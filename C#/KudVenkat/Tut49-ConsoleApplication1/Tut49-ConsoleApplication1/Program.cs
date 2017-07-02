using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut49_ConsoleApplication1
{
    /// <summary>
    /// Access modifiers tuts
    /// </summary>
    public class Customer
    {
        //public int ID;

        protected int ID;
    }

    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            base.ID = 5;

            Console.WriteLine(base.ID);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer cus = new Customer();
            //cus.ID = 5; cannot access protected member outside


            CorporateCustomer corCus = new CorporateCustomer();
            corCus.PrintID();

            Console.Read();
        }
    }
}
