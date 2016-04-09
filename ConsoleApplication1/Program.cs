using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 3;
            int num3 = (num1 + num2);

            try
            {
                if (num3 > 0 && num3 < 5)
                {
                    throw new NumberNotFiveException("Message goes here?");
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            catch (NumberNotFiveException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }                      
    }


    class NumberNotFiveException : Exception
    {
        public NumberNotFiveException()
            : base() { }

        public NumberNotFiveException(string MyMessage)
            : base(MyMessage) { }

        public NumberNotFiveException(string message,
            Exception innerException)
            : base(message, innerException) { }
    }
}
    
