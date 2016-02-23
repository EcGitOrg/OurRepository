using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public static class Class1
    {
        public static int NumberChangerGetSmall(int[] numberArr)
        {
            int small = 9999999;
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] < small) { small = numberArr[i]; }
            }
            return small;
        }
        public static int NumberChangerGetBig(int[] numberArr)
        {
            int big = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] > big) { big = numberArr[i]; }
            }
            return big;
        }
        public static int NumberChangerGetAverage(int[] numberArr)
        {
            int average = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                average += numberArr[i];
            }
            average /= numberArr.Length;
            return average;
        }
    }
}
