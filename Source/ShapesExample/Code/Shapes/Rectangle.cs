namespace Shapes
{
    /// <summary>
    /// Defines a rectangle in a basic format.
    /// </summary>
    public class Rectangle : IShape
    {
        /// <inheritdoc />
        public double Length { private get; set; }

        /// <inheritdoc />
        public double Height { private get; set; }

        /// <inheritdoc />
        public double CalculateCircumference()
        {
            return (2 * Length) + (2 * Height);
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            return Height * Length;
        }

        public bool IsSquare()
        {
            return Length == Height;
        }
    }
}