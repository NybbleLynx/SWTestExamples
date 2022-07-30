namespace Shapes.Extensions
{
    /// <summary>
    /// Static class providing extensions for math equations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Squares a number.
        /// </summary>
        /// <param name="value">The number to be squared.</param>
        /// <returns>The squared value of the given number.</returns>
        public static double Squared(this double value)
        {
            return value * value;
        }
    }
}