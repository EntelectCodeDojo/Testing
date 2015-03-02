using System;
using System.Collections;
using NUnit.Framework;

namespace NUnitCheatSheet
{
    /// <summary>
    /// Factory class for providing test data for tests with the TestCaseSource attribue.
    /// </summary>
    public class TestCaseDataFactory
    {
        /// <summary>
        /// TestCaseSource tests can consume IEnumerable properties which return TestCaseData
        /// </summary>
        public static IEnumerable TestCasesDataForTestCaseSourceTest
        {
            get
            {
                yield return new TestCaseData(1, "1").Returns(2); // Defines the test data and the expected return
                yield return new TestCaseData(2, "2").Returns(4);
                yield return new TestCaseData(0, "a").Throws(typeof(ArgumentException)); // Defines the test data and the expected throw exception
            }
        }
    }
}