using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Program
    {
        public delegate double Func (double x);

        public static double FuncIntegrate(double x)
        {
            double x1 = 2 * x, x2 = 5 * x;
            return Math.Cos(Math.Exp(x2 / x1)) / (4 + x2);
        }

        static void Main(string[] args)
        {
            Func Function = FuncIntegrate;
            Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
                string sa = Console.ReadLine();
                double a = double.Parse(sa, System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
                string sb = Console.ReadLine();
                double b = double.Parse(sb, System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Введiть кiлькiсть дiлянок n: ");
                string sn = Console.ReadLine();
                int n = int.Parse(sn, System.Globalization.CultureInfo.InvariantCulture);
            double dx = (b - a) / n;
            double intgrl = 0;
            Console.WriteLine("\n\n*******Метод трапецiй:*******");
            for (double i = a; i < b; i += dx)
            {
                double x1 = Function(i);
                double x2 = Function(i);
                double mid = dx * (x1 + x2) / 2;
                intgrl += mid;
            }
            Console.WriteLine("Результат обчислень: {0:0.000000}", intgrl);
            Console.ReadKey();
        }
    }   
}
