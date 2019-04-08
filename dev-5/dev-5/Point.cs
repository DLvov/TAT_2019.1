using System;

namespace dev_5
{
    /// <summary>
    /// This structure represents a point in three-dimensional space.
    /// </summary>
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// This constructor initializes three point coordinates with input parameters.
        /// </summary>
        /// <param name="x">X-coordinate</param>
        /// <param name="y">Y-coordinate</param>
        /// <param name="z">Z-coordinate</param>
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// This method returns distance between two points.
        /// </summary>
        /// <param name="p">The point to which the distance from the this will be measured</param>
        /// <returns>Distance between two points</returns>
        public double getDistance(Point p)
        {
            return Math.Sqrt( (X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y) + (Z - p.Z) * (Z - p.Z));
        }
    }
}