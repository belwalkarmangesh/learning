using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6_ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? ticketsOnsale = null;

            int availableTickets=ticketsOnsale ?? 0;

            Console.WriteLine("Available tickets : {0}",availableTickets);

            Console.Read();
        }
    }
}
