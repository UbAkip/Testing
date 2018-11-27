using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTestProject1")]

namespace ConsoleApp1
{
    class Calc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
