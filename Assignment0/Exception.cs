using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment0
{
    class Exception
    {
        public static void CheckPossitive(int num)
        {
            if(num < 0)
            {
                throw new ArithmeticException("The number should be positive");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
    }
}
