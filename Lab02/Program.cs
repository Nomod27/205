using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення X1min: ");
            string sx1Min = Console.ReadLine();
            double x1Min = double.Parse(sx1Min, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Введiть кiнцеве значення X1max: ");
            string sx1Max = Console.ReadLine();
            double x1Max = double.Parse(sx1Max, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Введiть прирiст dX1: ");
            string sdx1 = Console.ReadLine();
            double dx1 = double.Parse(sdx1, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Введiть початкове значення X2min: ");
            string sx2Min = Console.ReadLine();
            double x2Min = double.Parse(sx2Min, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Введiть кiнцеве значення X2max: ");
            string sx2Max = Console.ReadLine();
            double x2Max = double.Parse(sx2Max, System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Введiть прирiст dX2: ");
            string sdx2 = Console.ReadLine();
            double dx2 = double.Parse(sdx2, System.Globalization.CultureInfo.InvariantCulture);
            dx2 = (x2Max - x2Min) / dx2 > 8 ? (x2Max - x2Min) / 8 : dx2;
            double y;
            double x1 = x1Min;
            double x2 = x2Min;
            double resultVar = 1.0;
            
            Console.Write("\n   \\x2|\n x1 \\ |");
            for (double i = x2; i <= x2Max; i += dx2) { Console.Write("{0:0.0e+0}\t", i); }
            Console.Write("\n------|-------------------------------------------------------------------------");
            for (; x1 <= x1Max; x1 += dx1)
            {
                Console.Write("{0:0.0e+0}|",x1);
                x2 = x2Min;
                for (; x2 <= x2Max; x2 += dx2)
                {
                    y = Math.Sqrt((x2 * x2 + x1 / x2) / (16 * x1 * x2));
                    Console.Write("{0:0.0e+0}\t", y);
                    double cosine = Math.Cos(y);
                    if (cosine < 0) resultVar = resultVar * cosine;
                }
                Console.Write("\n");
            }
            Console.Write("\nResult variant 8 : {0:0.0000000000e+00}",resultVar);
            if (resultVar == 1.0) Console.WriteLine(" (no cosines less than 1)");    
            Console.ReadKey();
        }
    }
}
