using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv 3 tal");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int minsta = Numbers.NrGetSMalest(a, b, c);
            int största = Numbers.NrGetBiggest(a, b, c);

            Console.WriteLine($"Misnat talet: {minsta}");
            Console.WriteLine($"Största talet: {största}");
            Console.ReadLine();
        }
    }
}
