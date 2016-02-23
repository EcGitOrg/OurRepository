using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    public class GameMethods
    {

        Random random = new Random();
        /// <summary>
        /// Sätter Spelarens Val På Plats
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="GameBoard"></param>
        /// <param name="mark"></param>
        public void PutInXY(int X, int Y, int[,] GameBoard, bool mark)
        {
            if (mark && GameBoard[X, Y] == 1) { Console.Clear(); Console.WriteLine("GAMEOVER"); Console.ReadKey(); Environment.Exit(-1); }
            else if (mark && GameBoard[X, Y] == 0|| mark && GameBoard[X, Y] == -2) { GameBoard[X, Y] = -1; }

            else if (!mark && GameBoard[X, Y] == 1) { GameBoard[X, Y] = 99; }
            else { Console.Clear(); Console.WriteLine("GAMEOVER"); Console.ReadKey(); Environment.Exit(-1); }

        }
        /// <summary>
        /// Sätter Random Nr 1 (Bad spotts)
        /// </summary>
        /// <param name="GameBoard"></param>
        ///     
        public void PutNumbers(int[,] GameBoard)
        {

            int go = 0;
            while (go < 6)
            {
                int x = random.Next(1, 6);
                int y = random.Next(1, 6);
                GameBoard[x, y] = 1;
                go++;
            }

        } 
        /// <summary>
        /// Count Result around user choice
        /// </summary>
        /// <param name="GameBoard"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public int ReadNumber(int[,] GameBoard, int X, int Y)
        {
            int result = 0;

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (X - 1 == x && Y - 1 == y && GameBoard[x, y] == 1) { result++; }

                    if (X + 1 == x && Y + 1 == y && GameBoard[x, y] == 1) { result++; }

                    if (X - 1 == x && Y + 1 == y && GameBoard[x, y] == 1) { result++; }

                    if (X + 1 == x && Y - 1 == y && GameBoard[x, y] == 1) { result++; }


                    if (X == x && Y + 1 == y && GameBoard[x, y] == 1) { result++; }

                    if (X == x && Y - 1 == y && GameBoard[x, y] == 1) { result++; }

                    if (X + 1 == x && Y == y && GameBoard[x, y] == 1) { result++; }

                    if (X - 1 == x && Y == y && GameBoard[x, y] == 1) { result++; }
                }
            }
            return result;
        } 
        /// <summary>
        /// Prints Gameboard
        /// </summary>
        /// <param name="GameBoard"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void WriteGameBoard(int[,] GameBoard, int X, int Y)
        {
            string a;
            string b = "  #  ";
            int index = 1;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (GameBoard[x, y] == -1) { Console.BackgroundColor = ConsoleColor.Red; a = " -$- "; Console.Write(a); Console.BackgroundColor = ConsoleColor.Black; }
                    else if (GameBoard[x, y] == -2) { Console.Write("  O  "); }
                    else if (x == 0 || y == 0 || x == 6 || y == 6) { Console.BackgroundColor = ConsoleColor.Blue; Console.Write(b); Console.BackgroundColor = ConsoleColor.Black; }
                    else if (GameBoard[x, y] == 1)
                    {
                        Console.Write("  ?  ");
                    }
                    else if (GameBoard[x, y] == 0)
                    {
                        Console.Write("  ?  ");
                    }
                    else if (GameBoard[x, y] == 99) { Console.BackgroundColor = ConsoleColor.Yellow; Console.Write("  1  "); Console.BackgroundColor = ConsoleColor.Black; }

                }
                index++;
                Console.Write("\n");
            }
        }
        /// <summary>
        /// Get X and Y from user
        /// </summary>
        /// <returns></returns>
        public int GetXY()
        {
            int XY;

            while (!int.TryParse(Console.ReadLine(), out XY) || XY > 5 || XY < 1) { Console.WriteLine("Must write number for a 5x5 array so.... 1-5"); }

            return XY;
        }
        /// <summary>
        /// Changes value around user choice
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="GameBoard"></param>
        /// <returns></returns>
        public int[,] ReviealGameBoard(int X, int Y, int[,] GameBoard)
        {
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (X-- == x && Y-- == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X++ == x && Y++ == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X-- == x && Y++ == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X++ == x && Y-- == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }


                    if (X == x && Y++ == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X == x && Y-- == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X++ == x && Y == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }

                    if (X-- == x && Y == y && GameBoard[x, y] == 0) { GameBoard[x, y] = -2; }
                }
            }
            return GameBoard;
        }
        /// <summary>
        /// Put a frame around Gameboard
        /// </summary>
        /// <param name="GameBoard"></param>
        /// <returns></returns>
        public int[,] SetFrame(int[,] GameBoard)
        {
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (y == 0 || y == 6 || x == 0 || x == 6) { GameBoard[x, y] = 10; }
                }
            }
            return GameBoard;
        }
    }
}

