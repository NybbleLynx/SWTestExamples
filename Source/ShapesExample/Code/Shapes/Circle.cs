using System;

namespace Shapes
{
    /// <summary>
    /// Defines a circle in a basic format.
    /// </summary>
    public class Circle : IShape
    {
        /// <inheritdoc />
        public int Length { private get; set; }

        /// <inheritdoc />
        public int Height { private get; set; }

        /// <inheritdoc />
        public double CalculateCircumference()
        {
            ValidateCircle();
            var diameter = Length;

            return Math.PI * diameter;
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            ValidateCircle();
            var radius = Length/2;

            return Math.PI * (radius * radius);
        }

        private void ValidateCircle()
        {
            // Assume that shape is a circle. If dimensions aren't exact change height to equal length.
            if (Length != Height)
            {
                Height = Length;
            }
        }
    }
}