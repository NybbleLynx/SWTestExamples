using System.Collections.Generic;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCaseSource(nameof(CircleCircumferenceTestCases))]
        public void GivenAShapeAsACircle_WhenCalculatingCircumference_ExpectedValueIdReturned(int diameter, double expectedCircumference)
        {
            var circle = new Circle
            {
                Length = diameter,
                Height = 1
            };

            Assert.That(circle.CalculateCircumference(), Is.EqualTo(expectedCircumference));
        }

        private static IEnumerable<TestCaseData> CircleCircumferenceTestCases()
        {
            yield return new TestCaseData(3, 9);
            yield return new TestCaseData(7, 22);
            yield return new TestCaseData(15, 47);
        }

        [TestCaseSource(nameof(CircleAreaTestCases))]
        public void GivenAShapeAsACircle_WhenCalculatingArea_ExpectedValueIdReturned(int diameter, double expectedArea)
        {
            var circle = new Circle
            {
                Length = diameter,
                Height = 1
            };

            Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea));
        }

        private static IEnumerable<TestCaseData> CircleAreaTestCases()
        {
            yield return new TestCaseData(3, 7);
            yield return new TestCaseData(7, 38);
            yield return new TestCaseData(15, 177);
        }
    }
}