using System;

namespace cw_3
{
    /// <summary>
    /// This class is simple triangle.
    /// </summary>
    class SimpleTriangle : Triangle
    {
        /// <summary>
        /// This constructor call base constructor and initialize description of the triangle.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        public SimpleTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
            Description = "I am simple triangle!";
        }

        /// <summary>
        /// This method returns sqare of the triangle.
        /// </summary>
        /// <returns>Sqaure of the triangle</returns>
        public override double GetSquare()
        {
            double perimeter = (AB + BC + CA) / 2;
            return Math.Sqrt(perimeter * (perimeter - AB) * (perimeter - BC) * (perimeter - CA));
        }
    }
}