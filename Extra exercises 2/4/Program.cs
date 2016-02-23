using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        public static bool CheckCondition(int x, int y, int z, bool flag)
        {
            bool Checked = false;
            if (z > 10 && z < 20 && flag == true) { Checked = true; }
            if (y > 10 && y < 20 && z == 0 && flag == true) { Checked = true; }
            if (x == 5 && y == 3 && z > 99 && flag == false) { Checked = true; }

            return Checked;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Write in nr:X");
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Write in nr:Y");
            int y;
            int.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Write in nr:Z");
            int z;
            int.TryParse(Console.ReadLine(), out z);
            while (true)
            {
                Console.WriteLine("Put your bool type: true or false");
                string setFlag = Console.ReadLine();
                if (setFlag == "true") { flag = true; break; }
                if (setFlag == "false") { flag = false; break; }
                else { Console.WriteLine("write false or true"); }
            }

            bool flagReturn = CheckCondition(x, y, z, flag);
            if (flagReturn) { Console.WriteLine("True!"); }
            if (!flagReturn) { Console.WriteLine("False!"); }
            Console.ReadKey();
        }
    }
}
