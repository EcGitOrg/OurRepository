using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class _2dvektor
    {

        Random random = new Random();
      
       

        public void PrintArray(int[,]arr)
        {
            for (int y = 0; y < 50; y++) { 
                for (int x = 0; x < 50; x++) {
                    if (arr[x, y] > 0) { Console.Write("*"); }
                    else { Console.Write(" "); }
                }
            }
        }
        public void AddRandom(int[,] arr)
        {
            int a = 0;
            while (a < 100)
            { 
            int x = random.Next(0, 50);
            int y = random.Next(0, 50);
            arr[x, y] = random.Next();
                a++;
        }
        }
    }
}
