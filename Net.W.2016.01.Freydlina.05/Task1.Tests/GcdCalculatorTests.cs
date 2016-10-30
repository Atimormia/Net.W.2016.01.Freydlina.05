using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using Task1;

namespace Task1.Tests
{
    [TestFixture]
    public class GcdCalculatorTests
    {

        #region Test method: public static int GcdEuclid(int a, int b)
        public static IEnumerable<TestCaseData> TestCasesForGcdEuclid
        {
            get
            {
                yield return new TestCaseData(18, 48).Returns(6);
                yield return new TestCaseData(18, 18).Returns(18);
                yield return new TestCaseData(1, 0).Returns(1);
                yield return new TestCaseData(0,1).Returns(1);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdEuclid))]
        public int TestGcdEuclid(int a, int b)
        {
            Debug.WriteLine($"Euclid with {a} and {b} calculates {GcdCalculator.TimeForCalculationEuclidGcd(a,b)}");
            return GcdCalculator.GcdEuclid(a, b);

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdEuclidThrows
        {
            get
            {
                yield return new TestCaseData(-18, 48);
                yield return new TestCaseData(18, -48);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdEuclidThrows))]
        public void TestGcdEuclidThrows(int a, int b)
        {
            Assert.That(() => GcdCalculator.GcdEuclid(a, b), Throws.TypeOf<ArgumentException>());

        }
        #endregion

        #region Test method: public static int GcdEuclid(params int[] values)
        public static IEnumerable<TestCaseData> TestCasesForGcdEuclidParams
        {
            get
            {
                yield return new TestCaseData(new int[] { 18, 48 }).Returns(6);
                yield return new TestCaseData(new int[] { 18, 48, 6 }).Returns(6);
                yield return new TestCaseData(new int[] { 18, 48, 6, 1 }).Returns(1);
                yield return new TestCaseData(new int[] { 18, 48, 6, 0, 1 }).Returns(1);
                yield return new TestCaseData(new int[] { 0, 18, 48, 6 }).Returns(6);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdEuclidParams))]
        public int TestGcdEuclidParams(int[] values)
        {
            return GcdCalculator.GcdEuclid(values);

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdEuclidParamsThrows
        {
            get
            {
                yield return new TestCaseData(new int[] { 18, -48, 6 });
                yield return new TestCaseData(new int[] { 18, 48, 6, 0, -1 });
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdEuclidParamsThrows))]
        public void TestGcdEuclidParamsThrows(int[] values)
        {
            Assert.That(() => GcdCalculator.GcdEuclid(values), Throws.TypeOf<ArgumentException>());

        }
        #endregion

        #region Test method: public static int GcdStein(int a, int b)
        public static IEnumerable<TestCaseData> TestCasesForGcdStein
        {
            get
            {
                yield return new TestCaseData(18, 48).Returns(6);
                yield return new TestCaseData(18, 18).Returns(18);
                yield return new TestCaseData(1, 0).Returns(1);
                yield return new TestCaseData(0, 1).Returns(1);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdStein))]
        public int TestGcdStein(int a, int b)
        {
            Debug.WriteLine($"Stein with {a} and {b} calculates {GcdCalculator.TimeForCalculationSteinGcd(a, b)}");
            return GcdCalculator.GcdStein(a, b);

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdSteinThrows
        {
            get
            {
                yield return new TestCaseData(-18, 48);
                yield return new TestCaseData(18, -48);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdSteinThrows))]
        public void TestGcdSteinThrows(int a, int b)
        {
            Assert.That(() => GcdCalculator.GcdStein(a, b), Throws.TypeOf<ArgumentException>());

        }
        #endregion

        #region Test method: public static int GcdStein(params int[] values)
        public static IEnumerable<TestCaseData> TestCasesForGcdSteinParams
        {
            get
            {
                yield return new TestCaseData(new int[] { 18, 48 }).Returns(6);
                yield return new TestCaseData(new int[] { 18, 48, 6 }).Returns(6);
                yield return new TestCaseData(new int[] { 18, 48, 6, 1 }).Returns(1);
                yield return new TestCaseData(new int[] { 18, 48, 6, 0, 1 }).Returns(1);
                yield return new TestCaseData(new int[] { 0, 18, 48, 6 }).Returns(6);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdSteinParams))]
        public int TestGcdSteinParams(int[] values)
        {
            return GcdCalculator.GcdStein(values);

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdSteinParamsThrows
        {
            get
            {
                yield return new TestCaseData(new int[] { 18, -48, 6 });
                yield return new TestCaseData(new int[] { 18, 48, 6, 0, -1 });
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdSteinParamsThrows))]
        public void TestGcdSteinParamsThrows(int[] values)
        {
            Assert.That(() => GcdCalculator.GcdStein(values), Throws.TypeOf<ArgumentException>());

        }
        #endregion

    }
}
