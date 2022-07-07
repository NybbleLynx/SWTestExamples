namespace Shapes
{
    /// <summary>
    /// Defines a generic shape with basic properties and methods.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Length of shape i.e. horizontal size.
        /// </summary>
        int Length { set; }

        /// <summary>
        /// Height of shape i.e. vertical size.
        /// </summary>
        int Height { set; }

        /// <summary>
        /// Calculates the circumference of the given shape using appropriate equation.
        /// </summary>
        /// <returns>The circumference of the shape.</returns>
        double CalculateCircumference();

        /// <summary>
        /// Calculates the area of the given shape using appropriate equation.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        double CalculateArea();
    }
}