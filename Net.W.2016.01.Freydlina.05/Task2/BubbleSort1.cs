using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public delegate int Compare(int[] a, int[] b);

    /// <summary>
    /// Sorting algorithm in method gets <see cref="IComparer{T}"/>
    /// </summary>
    public class BubbleSort1
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

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparator.Compare(array[i], array[j]) <= 0) continue;;
                    Swap(array,i,j);
                }
            }
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

            IComparer<int[]> comparator = compare.Target as IComparer<int[]>;
            SortJuggedArray(array, comparator);
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
