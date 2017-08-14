using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingFigures
{
    class Program
    {
        public static void FullSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public static void NotFullSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 0 || row == 6) || (col == 0 || col == 6))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void FirstStrTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 0 || col == 0) || (row + col == 6))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void SecondStrTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 0 || col == 6) || (row == col))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void ThirdStrTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 6 || col == 0) || (row == col))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void FourthStrTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if ((row == 6 || col == 6) || (row + col == 6))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void FifthTriangle()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 || row == col || row + col == 6)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void SixthTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (col == 0 || row == col || row + col == 6)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void SeventhTriangle()
        {
            for (int row = 3; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row == 6 || row + col == 6 || row == col)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void EigthTriangle()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 3; col < 7; col++)
                {
                    if (col == 6 || row + col == 6 || row == col)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void CrossedLines()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (row + col == 6 || row == col)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void UtDSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(row + 1);
                }
                Console.WriteLine();
            }
        }

        public static void DtUSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(7 - row);
                }
                Console.WriteLine();
            }
        }

        public static void LtRSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(col + 1);
                }
                Console.WriteLine();
            }
        }

        public static void RtLSquare()
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(7 - col);
                }
                Console.WriteLine();
            }
        }

        static void  Main(string[] args)
        {
            FullSquare();
            Console.WriteLine();
            NotFullSquare();
            Console.WriteLine();
            FirstStrTriangle();
            Console.WriteLine();
            SecondStrTriangle();
            Console.WriteLine();
            ThirdStrTriangle();
            Console.WriteLine();
            FourthStrTriangle();
            Console.WriteLine();
            FifthTriangle();
            Console.WriteLine();
            SixthTriangle();
            Console.WriteLine();
            SeventhTriangle();
            Console.WriteLine();
            EigthTriangle();
            Console.WriteLine();
            CrossedLines();
            Console.WriteLine();
            UtDSquare();
            Console.WriteLine();
            DtUSquare();
            Console.WriteLine();
            LtRSquare();
            Console.WriteLine();
            RtLSquare();
        }
    }
}
