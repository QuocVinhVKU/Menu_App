using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            int width = 5;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        DrawTriangle(width);
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        DrawSquare(width);
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        DrawRectangle(width, 10);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }

        }
        private static void DrawTriangle(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void DrawSquare(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void DrawRectangle(int width, int height)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
