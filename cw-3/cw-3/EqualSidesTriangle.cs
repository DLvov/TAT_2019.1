using System;

namespace cw_3
{
    /// <summary>
    /// This class is equal sides triangle.
    /// </summary>
    class EqualSidesTriangle : Triangle
    {
        /// <summary>
        /// This constructor call base constructor and initialize description of the triangle.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        public EqualSidesTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
            Description = "I am equal sides triangle!";
        }

        /// <summary>
        /// This method returns sqare of the triangle.
        /// </summary>
        /// <returns>Sqaure of the triangle</returns>
        public override double GetSquare()
        {
            return Math.Sqrt(3.0) * AB / 4;
        }
    }
}