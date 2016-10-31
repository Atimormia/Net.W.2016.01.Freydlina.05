using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        #region Test method: public static void SortJuggedArrayByMax(int[][] arr)
        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayByMax
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
                yield return new TestCaseData(arr, true).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] {3, 4};
                arr[1] = new int[] {2, 3, 3, 2};
                arr[2] = new int[] {1, 2, 5};
                arrRet = new int[3][];
                arrRet[0] = new int[] { 1, 2, 5 };
                arrRet[1] = new int[] {3, 4};
                arrRet[2] = new int[] { 2, 3, 3, 2 };
                yield return new TestCaseData(arr, false).Returns(arrRet);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayByMax))]
        public int[][] TestSortJuggedArrayByMax(int[][] arr, bool ascending)
        {
            BubbleSort.SortJuggedArray(arr,BubbleSort.MaxParameter,ascending);
            return arr;

        }

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayByMin
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
                    new int[] {1, 2, 5},
                    new int[] {2, 3, 3, 2},
                    new int[] {3, 4},
                };
                yield return new TestCaseData(arr, true).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 3, 4 };
                arrRet[1] = new int[] { 2, 3, 3, 2 };
                arrRet[2] = new int[] { 1, 2, 5 };
                yield return new TestCaseData(arr, false).Returns(arrRet);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayByMin))]
        public int[][] TestSortJuggedArrayByMin(int[][] arr, bool ascending)
        {
            BubbleSort.SortJuggedArray(arr, BubbleSort.MinParameter, ascending);
            return arr;

        }

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayBySum
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
                    new int[] {3, 4},
                    new int[] {1, 2, 5},
                    new int[] {2, 3, 3, 2},
                };
                yield return new TestCaseData(arr, true).Returns(arrRet);

                arr = new int[3][];
                arr[0] = new int[] { 3, 4 };
                arr[1] = new int[] { 2, 3, 3, 2 };
                arr[2] = new int[] { 1, 2, 5 };
                arrRet = new int[3][];
                arrRet[0] = new int[] { 2, 3, 3, 2 };
                arrRet[1] = new int[] { 1, 2, 5 };
                arrRet[2] = new int[] { 3, 4 };
                yield return new TestCaseData(arr, false).Returns(arrRet);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayBySum))]
        public int[][] TestSortJuggedArrayBySum(int[][] arr, bool ascending)
        {
            BubbleSort.SortJuggedArray(arr, BubbleSort.SumParameter, ascending);
            return arr;

        }

        public static IEnumerable<TestCaseData> TestCasesForSortJuggedArrayByMaxThrows
        {
            get
            {
                yield return new TestCaseData(new int[3][],true);
                yield return new TestCaseData(null,true);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForSortJuggedArrayByMaxThrows))]
        public void TestSortJuggedArrayByMaxThrows(int[][] arr, bool ascending)
        {
            Assert.That(() => BubbleSort.SortJuggedArray(arr,null,ascending), Throws.TypeOf<ArgumentNullException>());

        }
        #endregion
    }
}
