namespace Shapes
{
    public class Triangle : IShape
    {
        /// <inheritdoc />
        public int Length { private get; set; }

        /// <inheritdoc />
        public int Height { private get; set; }

        /// <inheritdoc />
        public double CalculateCircumference()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            return (0.5 * Length) *Height;
        }
    }
}