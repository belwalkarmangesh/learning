using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut63_ConsoleApplication1
{
   public partial class SamplePartialClass
    {
       partial void SamplePartialMethod();

       public void PublicMethod()
       {
           Console.WriteLine("PublicMethod Invoked");
           SamplePartialMethod();
       }
    }
}
