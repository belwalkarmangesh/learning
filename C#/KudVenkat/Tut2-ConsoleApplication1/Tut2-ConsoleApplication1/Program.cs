using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your FirstName: ");

            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your LastName :");            

            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName+" "+ lastName);//string concentanation

            Console.WriteLine("Hello {0} - {1}", firstName,lastName);// placeholder

            Console.ReadKey();
        }
    }
}
