using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMethods game = new GameMethods();
            int[,] GameBoard = new int[7, 7];
            game.PutNumbers(GameBoard);
            int X = 0;
            int Y = 0;
            int result;
            while (true)
            {
                Console.WriteLine("1-pick a spot\n2-Mark a bad spot");
                bool mark = true;
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        mark = true;
                        break;
                    case '2':
                        mark = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Write y:");
                X = game.GetXY();
                Console.WriteLine("Write x:");
                Y = game.GetXY();
                result = game.ReadNumber(GameBoard, X, Y);
                game.PutInXY(X, Y, GameBoard,mark);


                Console.Clear();

                GameBoard = game.ReviealGameBoard(X, Y, GameBoard);
                game.SetFrame(GameBoard);
                game.WriteGameBoard(GameBoard, X, Y);
                GameBoard[X, Y] = 0;


            }
        }
    }
}
