using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    class ComparatorByAscendingMax : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null) return int.MaxValue - b.Max();
            if (b == null) return int.MaxValue;
            return a.Max() - b.Max();
        }
    }

    class ComparatorByAscendingSum : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null) return int.MaxValue - b.Sum();
            if (b == null) return int.MaxValue;
            return a.Sum() - b.Sum();
        }
    }
    class ComparatorByDescendingMax : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null) return int.MinValue + b.Max();
            if (b == null) return int.MinValue;
            return b.Max() - a.Max();
        }
    }
    class ComparatorByDescendingSum : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a == null) return int.MinValue + b.Sum();
            if (b == null) return int.MinValue;
            return b.Sum() - a.Sum();
        }
    }
}
