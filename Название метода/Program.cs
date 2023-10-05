using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Название_метода
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int SetNumber(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
    }
}
