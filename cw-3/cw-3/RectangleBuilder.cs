using System;

namespace cw_3
{
    /// <summary>
    /// This class is builder for rectangle triangle.
    /// </summary>
    class RectangleBuilder : Builder
    {
        /// <summary>
        /// This constructor initialize successor.
        /// </summary>
        /// <param name="builder">Builder which will be a successor</param>
        public RectangleBuilder(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// This method creates a RectangleTriangle if the points satisfy the condition.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        /// <returns>Triangle</returns>
        public override Triangle CreateTriangle(Point a, Point b, Point c)
        {
            if (a.X == b.X && b.Y == c.Y)
            {
                return new RectangleTriangle(a, b, c);
            }
            else if (Successor != null)
            {
                return Successor.CreateTriangle(a, b, c);
            }
            else
            {
                throw new FormatException("No one of successors can't do this!");
            }
        }
    }
}