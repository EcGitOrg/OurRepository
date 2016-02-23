using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program // Hampus been here!
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[50, 50];
            _2dvektor dvektor = new _2dvektor();
            DateTime soon = new DateTime();
            soon = DateTime.Now;
            dvektor.AddRandom(arr);
            while (true)
            {
                while (soon < DateTime.Now)
                {
                    soon = DateTime.Now.AddMilliseconds(150);
                    
                    dvektor.PrintArray(arr);// shirzads comment2
                }
            }
           
        }
    }
}
