using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    /// <summary>
    /// Sorting algorithm in method gets delegate <see cref="Compare"/>
    /// </summary>
    public class BubbleSort2
    {
        /// <summary>
        /// Sorts jugged array by Bubble Algorithm with some comparator
        /// </summary>
        /// <param name="array">jugged array</param>
        /// <param name="comparator">implements comparation way</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SortJuggedArray(int[][] array, IComparer<int[]> comparator)
        {
            CheckParameters(array, comparator);

            SortJuggedArray(array, comparator.Compare);
        }

        /// <summary>
        /// Sorts jugged array by Bubble Algorithm with some delegate-comparer
        /// </summary>
        /// <param name="array">jugged array</param>
        /// <param name="compare">comparation method delegate <see cref="Compare"/></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SortJuggedArray(int[][] array, Compare compare)
        {
            CheckParameters(array, compare);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (compare(array[i], array[j]) <= 0) continue;
                    Swap(array, i, j);
                }
            }
        }

        private static void CheckParameters(object a, object b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
        }

        private static void Swap(int[][] a, int i, int j)
        {
            var tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
