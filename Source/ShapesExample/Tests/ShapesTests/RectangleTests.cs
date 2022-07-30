using System.Collections.Generic;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class RectangleTests
    {
        [TestCaseSource(nameof(RectangleCircumferenceTestCases))]
        public void GivenAShapeAsARectangle_WhenCalculatingCircumference_ExpectedValueIdReturned(int length, int height, double expectedCircumference)
        {
            var rectangle = new Rectangle
            {
                Length = length,
                Height = height
            };

            Assert.That(rectangle.CalculateCircumference(), Is.EqualTo(expectedCircumference));
        }

        private static IEnumerable<TestCaseData> RectangleCircumferenceTestCases()
        {
            yield return new TestCaseData(5, 3, 16);
            yield return new TestCaseData(10, 7, 34);
            yield return new TestCaseData(12, 15, 54);
        }

        [TestCaseSource(nameof(RectangleAreaTestCases))]
        public void GivenAShapeAsARectangle_WhenCalculatingArea_ExpectedValueIdReturned(int length, int height, double expectedArea)
        {
            var rectangle = new Rectangle
            {
                Length = length,
                Height = height
            };

            Assert.That(rectangle.CalculateArea(), Is.EqualTo(expectedArea));
        }

        private static IEnumerable<TestCaseData> RectangleAreaTestCases()
        {
            yield return new TestCaseData(5, 3, 15);
            yield return new TestCaseData(10, 7, 70);
            yield return new TestCaseData(12, 15, 180);
        }

        [Test]
        public void GivenAShapeAsASquare_IsSquareReturnsTrue()
        {
            var rectangle = new Rectangle
            {
                Length = 10,
                Height = 10
            };

            Assert.That(rectangle.IsSquare, Is.True);
        }
    }
}