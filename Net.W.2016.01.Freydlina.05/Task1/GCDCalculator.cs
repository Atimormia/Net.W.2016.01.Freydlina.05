using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    /// <summary>
    /// Contains a value of GCD and Time(<see cref="TimeSpan"/>) for calculating 
    /// </summary>
    public struct ReturnGcdAndCalutationTime
    {
        public int Gcd;
        public TimeSpan Time;
    }

    /// <summary>
    /// Delegate for concrete GCD calculation algorithm
    /// </summary>
    /// <param name="a">first value</param>
    /// <param name="b">second value</param>
    /// <returns>GCD of two values</returns>
    public delegate int GcdAlgorithm(int a, int b);

    public class GcdCalculator
    {
        /// <summary>
        /// Calculates GCD of two values by Euclid algorithm
        /// </summary>
        /// <returns>GCD of two values</returns>
        public static int GcdEuclid(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            var result = CheckParameters(a, b);
            if (result != null) return (int)result;

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            return GcdEuclid(a, b - a);
        }

        /// <summary>
        /// Calculates GCD of two values by Stein algorithm
        /// </summary>
        /// <returns>GCD of two values</returns>
        public static int GcdStein(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            var result = CheckParameters(a, b);
            if (result != null) return (int)result;

            int shift;
            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }
            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)
                    b >>= 1;
                if (a > b)
                {
                    int t = b;
                    b = a;
                    a = t;
                }
                b = b - a;
            } while (b != 0);
            return a << shift;
        }

        /// <summary>
        /// Calculates GCD of values by specified algorithm
        /// </summary>
        /// <param name="algorithm">delegate to method represented the algorithm</param>
        /// <param name="values"></param>
        /// <returns>GCD of values</returns>
        public static int Gcd(GcdAlgorithm algorithm, params int[] values)
        {
            if (algorithm == null) throw new ArgumentNullException(nameof(algorithm));

            if (values.Length == 0) throw new ArgumentException("Array is empty");

            int gcd = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                gcd = algorithm(values[i], gcd);
                if (gcd == 1)
                {
                    return gcd;
                }
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two values by specified algorithm
        /// </summary>
        /// <param name="algorithm">delegate to method represented the algorithm</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>GCD of values</returns>
        public static int Gcd(GcdAlgorithm algorithm, int a, int b)
        {
            if (algorithm == null) throw new ArgumentNullException(nameof(algorithm));

            return algorithm(a, b);
        }

        /// <summary>
        /// Calculates GCD of values by specified algorithm
        /// </summary>
        /// <param name="algorithm">delegate to method represented the algorithm</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>struct <see cref="ReturnGcdAndCalutationTime"/></returns>
        public static ReturnGcdAndCalutationTime GcdWithTimeCalculation(GcdAlgorithm algorithm, int a, int b)
        {
            if (algorithm == null) throw new ArgumentNullException(nameof(algorithm));

            ReturnGcdAndCalutationTime result = new ReturnGcdAndCalutationTime();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            result.Gcd = algorithm(a, b);
            stopWatch.Stop();
            result.Time = stopWatch.Elapsed;

            return result;
        }
        
        private static int? CheckParameters(int a, int b)
        {
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
            return null;
        }
    }
}
