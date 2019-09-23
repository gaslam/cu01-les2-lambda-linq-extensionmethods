using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLinq.Book.Domain
{
    public static class IntExtension
    {
        public static float DivideByTwo(this int number)
        {
            return (float)number / 2;
        }

        public static int multiply(this int number, int multiplier)
        {
            return number * multiplier;
        }
    }
}
