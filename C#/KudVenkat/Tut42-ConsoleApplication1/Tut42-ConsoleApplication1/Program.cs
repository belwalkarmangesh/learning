using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut42_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new UserAlreadyLoggedInException("Hello u just created custom class");
                }
                catch (UserAlreadyLoggedInException ex)
                {
                    throw new UserAlreadyLoggedInException("Hello u just created custom class", ex);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {

        }

        public UserAlreadyLoggedInException(string message)
            : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
