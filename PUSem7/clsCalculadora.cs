using System;
using System.Collections.Generic;
using System.Text;

namespace PUSem7
{
    public class clsCalculadora
    {
        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int resta(int a, int b)
        {
            return a - b;
        }

        public static int multi(int a, int b)
        {
            return a * b;
        }

        public static int div(int a, int b)
        {
            return (b == 0) ? -1 : a / b;           
        }
    }
}
