using System.Collections.Generic;
using NUnit.Framework;
using Shapes.Extensions;

namespace ShapesTests
{
    [TestFixture]
    public class MathExtensionsTests
    {
        [TestCaseSource(nameof(SquaredValueTestCases))]
        public void GivenANumber_WhenSquared_ExpectedValueIsReturned(double number, int expectedValue)
        {
            Assert.That(number.Squared(), Is.EqualTo(expectedValue));
        }

        private static IEnumerable<TestCaseData> SquaredValueTestCases()
        {
            yield return new TestCaseData(2, 4);
            yield return new TestCaseData(3, 9);
            yield return new TestCaseData(6, 36);
            yield return new TestCaseData(12, 144);
            yield return new TestCaseData(120, 14400);
        }
    }
}