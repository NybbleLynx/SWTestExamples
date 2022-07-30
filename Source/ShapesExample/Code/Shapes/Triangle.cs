using System;
using Shapes.Extensions;

namespace Shapes
{
    /// <summary>
    /// Defines an isosceles triangle in a basic format.
    /// </summary>
    public class Triangle : IShape
    {
        /// <inheritdoc />
        /// <remarks>This is the base of the triangle.</remarks>
        public double Length { private get; set; }

        /// <inheritdoc />
        public double Height { private get; set; }

        /// <inheritdoc />
        public double CalculateCircumference()
        {
            double adjacent = Length / 2;
            double opposite = Height;

            var hypotenuse = Math.Sqrt(opposite.Squared() + adjacent.Squared());
            return Math.Round(hypotenuse, MidpointRounding.AwayFromZero);
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            return (Length/2) * Height;
        }
    }
}