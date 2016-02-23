using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        public static void fullAscci()
        {
            for (int i = 0; i <= 127; i++)

            {
                System.Console.Write("{0} = {1}", i, (char)i);
                
            }
        }
        public static void OneAscci()
        {
            bool go = true;
            while (go)
            {
                Console.Clear();
                Console.WriteLine("Menu\n\n-------------------------------------");

                int number;
                Console.WriteLine("-Write number \n-Type \"999\"to quit\n-------------------------------------");
                if (!int.TryParse(Console.ReadLine(), out number)) { Console.WriteLine("ERROR Write a number!"); }
               
                for (int i = 0; i <= 300; i++)
                {
                    if (number == i)
                    {
                        Console.Clear();
                        Console.WriteLine("Menu\n\n-------------------------------------");
                        Console.WriteLine("-Write number \n-Type \"999\"to quit\n-------------------------------------");
                        Console.Write("{0} = {1}", i, (char)i);
                    }
                }
                if(number == 999) { go = false; }
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu\n\n-------------------------------------\n1. Full ascci table\n2. Search on specific number\n3. Quit\n-------------------------------------");

                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        fullAscci();
                        break;
                    case '2':
                        OneAscci();
                        break;
                    case '3':
                        Environment.Exit(-1);
                        return;
                    default:
                        break;
                }
                Console.ReadKey();
            
            }
            
        }
    }
}
