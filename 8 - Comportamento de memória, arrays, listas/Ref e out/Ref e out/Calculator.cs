using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_e_out
{
    internal class Calculator
    {
        public static int Triple(ref int x) {
            x = x * 3;
            return x;

        }
    }
}
