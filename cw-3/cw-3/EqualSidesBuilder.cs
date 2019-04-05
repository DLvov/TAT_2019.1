using System;

namespace cw_3
{
    /// <summary>
    /// This class is builder for equal sides triangle.
    /// </summary>
    class EqualSidesBuilder : Builder
    {
        /// <summary>
        /// This constructor initialize successor.
        /// </summary>
        /// <param name="builder">Builder which will be a successor</param>
        public EqualSidesBuilder(Builder builder)
        {
            Successor = builder;
        }

        /// <summary>
        /// This method creates a EqualSidesTriangle if the points satisfy the condition.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        /// <returns>Triangle</returns>
        public override Triangle CreateTriangle(Point a, Point b, Point c)
        {
            double epsilon = 0.000001;
            if (a.GetDistance(b) - b.GetDistance(c) < epsilon && b.GetDistance(c) - c.GetDistance(a) < epsilon)
            {
                return new EqualSidesTriangle(a, b, c);
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