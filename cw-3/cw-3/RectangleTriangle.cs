﻿namespace cw_3
{
    /// <summary>
    /// This class is rectangle triangle.
    /// </summary>
    class RectangleTriangle : Triangle
    {
        /// <summary>
        /// This constructor call base constructor and initialize description of the triangle.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        public RectangleTriangle(Point a, Point b, Point c) : base(a, b, c)
        {
            Description = "I am rectangle triangle!";
        }

        /// <summary>
        /// This method returns sqare of the triangle.
        /// </summary>
        /// <returns>Sqaure of the triangle</returns>
        public override double GetSquare()
        {
            if (AB > BC && AB > CA)
            {
                return BC * CA / 2;
            }
            else if (BC > AB && BC > CA)
            {
                return AB * CA / 2;
            }
            else 
            {
                return AB * BC / 2;
            }
        }
    }
}