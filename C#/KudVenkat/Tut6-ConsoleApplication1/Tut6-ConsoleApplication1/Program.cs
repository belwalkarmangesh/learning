using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? areYouAMajor = null;

            if (areYouAMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (areYouAMajor==false)
            {
                Console.WriteLine("You are not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }

            Console.Read();
        }
    }
}
