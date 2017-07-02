using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut21_ConsoleApplication1
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }
    }
    public class FullTimeEmployee : Employee
    {
        float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        float HourlyRate;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee FTE = new FullTimeEmployee();
            FTE.Email = "m@m.com";
            FTE.Firstname="Mangesh";
            FTE.Lastname="Belwalkar";
            FTE.PrintFullName();

            Console.Read();
        }
    }
}
