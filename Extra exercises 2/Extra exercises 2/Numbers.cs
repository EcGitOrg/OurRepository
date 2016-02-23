using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercises_2
{
    public static class Numbers
    {
        public static int NrGetSMalest(int a, int b, int c)
        {
            int smalest = 0;

            if (a < b && a < c) { smalest = a; }
            if (b < a && b < c) { smalest = b; }
            if (c < a && c < b) { smalest = c; }
            return smalest;
        }
        public static int NrGetBiggest(int a, int b, int c)
        {
            int biggest = 0;

            if (a > b && a > c) { biggest = a; }
            if (b > a && b > c) { biggest = b; }
            if (c > a && c > b) { biggest = c; }
            return biggest;
        }

    }
}
