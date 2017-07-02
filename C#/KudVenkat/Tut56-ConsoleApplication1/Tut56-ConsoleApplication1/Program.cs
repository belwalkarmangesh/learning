using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut56_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual("AB", "AB");

            if (equal == true)
            {
                Console.WriteLine("Equal");

            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.Read();
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);

        }

    }
}
