using System;
using Shapes.Extensions;

namespace Shapes
{
    /// <summary>
    /// Defines a circle in a basic format.
    /// </summary>
    public class Circle : IShape
    {
        /// <inheritdoc />
        public double Length { private get; set; }

        /// <inheritdoc />
        public double Height { private get; set; }

        /// <inheritdoc />
        public double CalculateCircumference()
        {
            ValidateCircle();
            var diameter = Length;

            var circumference = Math.PI * diameter;
            return Math.Round(circumference, MidpointRounding.AwayFromZero);
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            ValidateCircle();
            var radius = Length/2;

            var radiusSqr = radius.Squared();

            var area = Math.PI * radiusSqr;
            return Math.Round(area, MidpointRounding.AwayFromZero);
        }

        private void ValidateCircle()
        {
            // Assume that shape is a circle. If dimensions aren't exact, change height to equal length.
            if (Math.Abs(Length - Height) != 0)
            {
                Height = Length;
            }
        }
    }
}