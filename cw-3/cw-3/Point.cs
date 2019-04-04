using System;

namespace cw_3
{
    /// <summary>
    /// This struct is point in two-dimensional space
    /// </summary>
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// This constructor initialize x and y coordinates.
        /// </summary>
        /// <param name="x">x-coordinate</param>
        /// <param name="y">y-coordinate</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// This method returns the distance between the this point and the transmitted one.
        /// </summary>
        /// <param name="p">Point to which the distance will be calculated</param>
        /// <returns>Distance between points</returns>
        public double GetDistance(Point p)
        {
            return Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));
        }
    }
}