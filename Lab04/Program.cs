using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        const double StartX = 1.3;
        const double dX = 0.7;

        static double Function(double x)
        {
            double x1 = 2.76 * x, x2 = 0.5 * x;
            return Math.Sqrt((x2 * x2 + x1 / x2) / (16 * x1 * x2));
        }

        static void Main(string[] args)
        {
            double[] arr = new double[10];
            double x = StartX;

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); ++i)
            {
                arr[i] = Function(x);
                x += dX;
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); ++i)
            {
                Console.WriteLine("arr[{0:00}] = {1:0.00000}", i, arr[i]);
            }
            double aMin = arr[arr.GetUpperBound(0)];
            double aMax = arr[arr.GetLowerBound(0)];
            double aAvg = 0;

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); ++i)
            {
                aAvg += arr[i];
            }
            aAvg = aAvg / arr.GetLength(0);
            Console.WriteLine("Мiнiмальне значення масиву: {0:0.00000}", aMin);
            Console.WriteLine("Максимальне значення масиву: {0:0.00000}", aMax);
            Console.WriteLine("Середнє значення масиву: {0:0.00000}", aAvg);
            int avgCnt = 0;
            double lbound = 0.9 * aAvg, ubound = 1.1 * aAvg;
            foreach(double cnt in arr)
            {
                if (cnt >= lbound && cnt <= ubound) ++avgCnt;
            }

            Console.WriteLine("Кiлькiсть елементiв, що знаходяться в 10% вiд середнього значення: {0}", avgCnt);
            Console.ReadKey();
        }
    }
}
