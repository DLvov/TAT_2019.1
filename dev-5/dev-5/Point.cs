using System;

namespace dev_5
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public double getDistance(Point p)
        {
            return Math.Sqrt( (X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y) + (Z - p.Z) * (Z - p.Z));
        }
    }
}