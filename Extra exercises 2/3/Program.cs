using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = new int[10];
            int a = 1;
            for (int i = 0; i < numberArr.Length; i++)
            {
                Console.Clear();
                Console.Write($"Write nr {a} :");
                int index;
                int.TryParse(Console.ReadLine(), out index);
                numberArr[i] = index;
                a++;
            }
            Console.Clear();
            int small = Class1.NumberChangerGetSmall(numberArr);
            int big = Class1.NumberChangerGetBig(numberArr);
            int average = Class1.NumberChangerGetAverage(numberArr);
            Console.WriteLine($"Smallest nr: {small}\nBiggest: {big}\nAverage: {average}");
            Console.ReadKey();
        }
    }
}
