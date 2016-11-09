using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class BubbleSortTests
    {

        #region Test method: public static void SortJuggedArray(int[][] array, IComparer<int[]> comparator)
        
        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayWithInterface
        {
            get
            {
                int[][] arr =
                {
                    new int[] {3, 4},
                    new int[] {2, 3, 3, 2},
                    new int[] {1, 2, 5},
                };
                int[][] arrRet =
                {
                    new int[] {2, 3, 3, 2},
                    new int[] {3, 4},
                    new int[] {1, 2, 5},
                };
                yield return new TestCaseData(arr, new ComparatorByAscendingMax()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 1, 2, 5 };
                arrRet[1] = new int[] { 3, 4 };
                arrRet[2] = new int[] { 2, 3, 3, 2 };
                yield return new TestCaseData(arr, new ComparatorByDescendingMax()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] {3, 4};
                arrRet[1] = new int[] {1, 2, 5};
                arrRet[2] = new int[] {2, 3, 3, 2};
                yield return new TestCaseData(arr, new ComparatorByAscendingSum()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 2, 3, 3, 2 };
                arrRet[1] = new int[] { 1, 2, 5 };
                arrRet[2] = new int[] { 3, 4 };
                yield return new TestCaseData(arr, new ComparatorByDescendingSum()).Returns(arrRet);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithInterface))]
        public int[][] TestSortJuggedArrayWithInterface1(int[][] arr, IComparer<int[]> comparator)
        {
            BubbleSort1.SortJuggedArray(arr, comparator);
            return arr;

        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithInterface))]
        public int[][] TestSortJuggedArrayWithInterface2(int[][] arr, IComparer<int[]> comparator)
        {
            BubbleSort2.SortJuggedArray(arr, comparator);
            return arr;

        }

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayWithInterfaceThrows
        {
            get
            {
                yield return new TestCaseData(new int[3][], null);
                yield return new TestCaseData(null, null);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithInterfaceThrows))]
        public void TestSortJuggedArrayWithInterfaceThrows1(int[][] arr, Comparer<int[]> comparator)
        {
            Assert.That(() => BubbleSort1.SortJuggedArray(arr, comparator), Throws.TypeOf<ArgumentNullException>());

        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithInterfaceThrows))]
        public void TestSortJuggedArrayWithInterfaceThrows2(int[][] arr, Comparer<int[]> comparator)
        {
            Assert.That(() => BubbleSort2.SortJuggedArray(arr, comparator), Throws.TypeOf<ArgumentNullException>());

        }
        #endregion

        #region Test method: public static void SortJuggedArray(int[][] array, Compare compare)

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayWithDelegate
        {
            get
            {
                int[][] arr =
                {
                    new int[] {3, 4},
                    new int[] {2, 3, 3, 2},
                    new int[] {1, 2, 5},
                };
                int[][] arrRet =
                {
                    new int[] {2, 3, 3, 2},
                    new int[] {3, 4},
                    new int[] {1, 2, 5},
                };
                yield return new TestCaseData(arr, new ComparatorByAscendingMax()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 1, 2, 5 };
                arrRet[1] = new int[] { 3, 4 };
                arrRet[2] = new int[] { 2, 3, 3, 2 };
                yield return new TestCaseData(arr, new ComparatorByDescendingMax()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 3, 4 };
                arrRet[1] = new int[] { 1, 2, 5 };
                arrRet[2] = new int[] { 2, 3, 3, 2 };
                yield return new TestCaseData(arr, new ComparatorByAscendingSum()).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 2, 3, 3, 2 };
                arrRet[1] = new int[] { 1, 2, 5 };
                arrRet[2] = new int[] { 3, 4 };
                yield return new TestCaseData(arr, new ComparatorByDescendingSum()).Returns(arrRet);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithDelegate))]
        public int[][] TestSortJuggedArrayWithDelegate1(int[][] arr, IComparer<int[]> comparator)
        {
            BubbleSort1.SortJuggedArray(arr, comparator.Compare);
            return arr;

        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithDelegate))]
        public int[][] TestSortJuggedArrayWithDelegate2(int[][] arr, IComparer<int[]> comparator)
        {
            BubbleSort2.SortJuggedArray(arr, comparator.Compare);
            return arr;

        }

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayWithDelegateThrows
        {
            get
            {
                yield return new TestCaseData(new int[3][], null);
                yield return new TestCaseData(null, null);
                Compare compare = new ComparatorByDescendingSum().Compare;
                yield return new TestCaseData(null,compare);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithDelegateThrows))]
        public void TestSortJuggedArrayWithDelegateThrows1(int[][] arr, Compare compare)
        {
            Assert.That(() => BubbleSort1.SortJuggedArray(arr, compare), Throws.TypeOf<ArgumentNullException>());

        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayWithDelegateThrows))]
        public void TestSortJuggedArrayWithDelegateThrows2(int[][] arr, Compare compare)
        {
            Assert.That(() => BubbleSort2.SortJuggedArray(arr, compare), Throws.TypeOf<ArgumentNullException>());

        }
        #endregion
    }
}
