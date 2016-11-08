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
        #region Test method: public static int Gcd(GcdAlgorithm algorithm, params int[] values)

        public static IEnumerable<TestCaseData> TestCasesForGcdParams
        {
            get
            {
                GcdAlgorithm[] algorithms = new GcdAlgorithm[2];
                algorithms[0] = GcdCalculator.GcdEuclid;
                algorithms[1] = GcdCalculator.GcdStein;
                foreach (GcdAlgorithm algorithm in algorithms)
                {
                    yield return new TestCaseData(algorithm, new int[] { 18, 48 }).Returns(6);
                    yield return new TestCaseData(algorithm, new int[] { 18, 48, 6 }).Returns(6);
                    yield return new TestCaseData(algorithm, new int[] { 18, 48, 6, 1 }).Returns(1);
                    yield return new TestCaseData(algorithm, new int[] { 18, 48, 6, 0, 1 }).Returns(1);
                    yield return new TestCaseData(algorithm, new int[] { 0, 18, 48, 6 }).Returns(6);
                    yield return new TestCaseData(algorithm, new int[] { -18, 48, -6 }).Returns(6);
                }
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdParams))]
        public int TestGcdParams(GcdAlgorithm algorithm, int[] values)
        {
            return GcdCalculator.Gcd(algorithm, values);

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdParamsThrows
        {
            get
            {
                yield return new TestCaseData(null, new int[] { 18, -48, 6 });
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdParamsThrows))]
        public void TestGcdParamsThrows(GcdAlgorithm algorithm, int[] values)
        {
            Assert.That(() => GcdCalculator.Gcd(algorithm, values), Throws.TypeOf<ArgumentNullException>());

        }
        #endregion
        
        #region Test method: public static int GcdEuclid(int a, int b)
        public static IEnumerable<TestCaseData> TestCasesForGcdEuclid
        {
            get
            {
                yield return new TestCaseData(18, 48).Returns(6);
                yield return new TestCaseData(18, 18).Returns(18);
                yield return new TestCaseData(1, 0).Returns(1);
                yield return new TestCaseData(0, 1).Returns(1);
                yield return new TestCaseData(-18, 48).Returns(6);
                yield return new TestCaseData(18, -48).Returns(6);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdEuclid))]
        public int TestGcdEuclid(int a, int b)
        {
            return GcdCalculator.GcdEuclid(a, b);

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
                yield return new TestCaseData(-18, 48).Returns(6);
                yield return new TestCaseData(18, -48).Returns(6);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdStein))]
        public int TestGcdStein(int a, int b)
        {
            return GcdCalculator.GcdStein(a, b);

        }
        #endregion

        #region Test method: public static ReturnGcdAndCalutationTime GcdWithTimeCalculation(GcdAlgorithm algorithm, int a, int b)
        public static IEnumerable<TestCaseData> TestCasesForGcdWithTime
        {
            get
            {
                GcdAlgorithm[] algorithms = new GcdAlgorithm[2];
                algorithms[0] = GcdCalculator.GcdEuclid;
                algorithms[1] = GcdCalculator.GcdStein;
                foreach (GcdAlgorithm algorithm in algorithms)
                {
                    yield return new TestCaseData(algorithm, 18, 48).Returns(6);
                    yield return new TestCaseData(algorithm, 18, 18).Returns(18);
                    yield return new TestCaseData(algorithm, 1, 0).Returns(1);
                    yield return new TestCaseData(algorithm, 0, 1).Returns(1);
                    yield return new TestCaseData(algorithm, -18, 48).Returns(6);
                    yield return new TestCaseData(algorithm, 18, -48).Returns(6);
                }
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdWithTime))]
        public int TestGcdWithTime(GcdAlgorithm algorithm, int a, int b)
        {
            ReturnGcdAndCalutationTime result = GcdCalculator.GcdWithTimeCalculation(algorithm, a, b);
            Debug.WriteLine($"Algorithm {algorithm.Method.Name} with parameters {a} and {b} calculates during {result.Time.Ticks} ticks");
            return result.Gcd;

        }

        public static IEnumerable<TestCaseData> TestCasesForGcdWithTimeThrows
        {
            get
            {
                yield return new TestCaseData(null, 1, 48);
            }
        }

        [Test, TestCaseSource(nameof(TestCasesForGcdWithTimeThrows))]
        public void TestGcdWithTimeThrows(GcdAlgorithm algorithm, int a, int b)
        {
            Assert.That(() => GcdCalculator.GcdWithTimeCalculation(algorithm, a, b), Throws.TypeOf<ArgumentNullException>());

        }
        #endregion

    }
}
