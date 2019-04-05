using System;

namespace cw_3
{
    /// <summary>
    /// This class is builder for simple triangle.
    /// </summary>
    class SimpleBuilder : Builder
    {
        /// <summary>
        /// This constructor initialize successor.
        /// </summary>
        /// <param name="builder">Builder which will be a successor</param>
        public SimpleBuilder(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// This method creates a SimpleTriangle if the points satisfy the condition.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        /// <returns>Triangle</returns>
        public override Triangle CreateTriangle(Point a, Point b, Point c)
        {
            if (!(a.X == b.X && b.X == c.X && c.X == a.X) && !(a.Y == b.Y && b.Y == c.Y && c.Y == a.Y))
            {
                return new SimpleTriangle(a, b, c);
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