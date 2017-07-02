using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut61_ConsoleApplication1
{
   public partial class PartialCustomer
    {
       public string GetFullName()
       {
           return _firstName + " " + _lastName;
       }
    }
}
