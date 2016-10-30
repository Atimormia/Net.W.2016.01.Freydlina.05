using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    public class GcdCalculator
    {
        public static int GcdEuclid(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("The numbers must be positive");
            }
            if (a == 0 || a == b)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            if (a == 1 || b == 1)
            {
                return 1;
            }
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            return GcdEuclid(a, b - a);
        }

        public static int GcdEuclid(params int[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int gcd = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                gcd = GcdEuclid(values[i], gcd);
                if (gcd == 1)
                {
                    return gcd;
                }
            }

            return gcd;
        }

        public static TimeSpan TimeForCalculationEuclidGcd(int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            GcdEuclid(a, b);
            stopWatch.Stop();

            return stopWatch.Elapsed;
        }

        public static int GcdStein(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("The numbers must be positive");
            }
            if (a == 0 || a == b)
            {
                return b;
            }
            if (b == 0)
            {
                return a;
            }
            if (a == 1 || b == 1)
            {
                return 1;
            }
            if (a%2L == 0L && b%2L == 0L)
            {
                return 2*GcdStein(a/2, b/2);
            }
            if (a%2L == 0L && b%2L != 0L)
            {
                return GcdStein(a/2, b);
            }
            if (a%2L != 0L && b%2L == 0L)
            {
                return GcdStein(a, b/2);
            }
            if (a < b)
            {
                return GcdStein((b - a)/2, a);
            }
            return GcdStein((a - b)/2, b);
        }

        public static int GcdStein(params int[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int gcd = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                gcd = GcdStein(values[i], gcd);
                if (gcd == 1)
                {
                    return gcd;
                }
            }

            return gcd;
        }

        public static TimeSpan TimeForCalculationSteinGcd(int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            GcdStein(a, b);
            stopWatch.Stop();

            return stopWatch.Elapsed;
        }
    }
}
