using System.Collections.Generic;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCaseSource(nameof(TriangleCircumferenceTestCases))]
        public void GivenAShapeAsATriangle_WhenCalculatingCircumference_ExpectedValueIdReturned(int length, int height, double expectedCircumference)
        {
            var triangle = new Triangle
            {
                Length = length,
                Height = height
            };

            Assert.That(triangle.CalculateCircumference(), Is.EqualTo(expectedCircumference));
        }

        private static IEnumerable<TestCaseData> TriangleCircumferenceTestCases()
        {
            yield return new TestCaseData(6, 3, 4);
            yield return new TestCaseData(10, 7, 9);
            yield return new TestCaseData(12, 15, 16);
        }

        [TestCaseSource(nameof(TriangleAreaTestCases))]
        public void GivenAShapeAsATriangle_WhenCalculatingArea_ExpectedValueIdReturned(int length, int height, double expectedArea)
        {
            var triangle = new Triangle
            {
                Length = length,
                Height = height
            };

            Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea));
        }

        private static IEnumerable<TestCaseData> TriangleAreaTestCases()
        {
            yield return new TestCaseData(6, 3, 9);
            yield return new TestCaseData(10, 7, 35);
            yield return new TestCaseData(12, 15, 90);
        }
    }
}