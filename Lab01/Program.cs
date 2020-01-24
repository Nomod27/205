using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Варiант 8\nВведiть початкове значення Xmin: ");
            string sx = Console.ReadLine();
            double xMin = Double.Parse(sx, System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Введiть кiнцеве значення Xmax: ");
            sx = Console.ReadLine();
            double xMax = double.Parse(sx, System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Введiть прирiст dX: ");
            sx = Console.ReadLine();
            double dx = double.Parse(sx, System.Globalization.CultureInfo.InvariantCulture);
            double x1 = xMin;
            double y;
            double res = 1;
            Console.WriteLine();
            for(; x1 <= xMax; x1 += dx)
            {
                double x2 = 3 * x1;
                y = Math.Cos(Math.Sqrt(x2) + 34 * x1) - 4 * Math.Sin(x2);
                double midres = Math.Cos(y);
                res *= midres;
               Console.WriteLine("x = {0:0.000}\t y = {1:0.000}\tCos = {2:0.00000}", x1, y, midres);
            }
            Console.WriteLine("\n\nResult = {0:0.000000e00}.", res);
            Console.ReadKey();
        }
    }
}
