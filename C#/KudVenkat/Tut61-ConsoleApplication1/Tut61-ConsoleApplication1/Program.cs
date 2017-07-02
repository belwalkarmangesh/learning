using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut61_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer {
                FirstName="Mangesh",
                LastName="Belwalkar"
            };

            string fullName = cust.GetFullName();

            Console.WriteLine(fullName);

            PartialCustomer partCust = new PartialCustomer { FirstName = "Mangesh", LastName = "Belwalkar" };

            string fullName1 = partCust.GetFullName();

            Console.WriteLine("From Partial class {0}", fullName1);
            Console.Read();
        }
    }
}
