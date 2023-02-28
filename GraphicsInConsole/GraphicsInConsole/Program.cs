using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x_mult = 4;
            int y_mult = 4;
            Console.SetBufferSize(Int16.MaxValue-1, Int16.MaxValue-1);
            for (int j = -50*y_mult; j < 50*y_mult; j++)
            {
                for (int i = -50*x_mult; i < 50*x_mult; i++)
                {
                    if(CheckCoord(i, j, 1, 0.2))
                    {
                        Console.SetCursorPosition((int)(50*x_mult+i), (int)(100*y_mult - j));
                        Console.Write("W");
                    }
                }
            }
            Console.ReadLine();
        }
        static double F(double x)
        {
            return Math.Sin(x);
        }
        static bool CheckCoord(double x, double y, int deepness, double error)
        {
            double max = Math.Pow(10, deepness);
            for (double i = 0; i < max; i++)
            {
                for (double j = 0; j < max; j++)
                {
                    if(y + j/max + error > F(x + i/max) && y + j / max - error < F(x + i / max))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
