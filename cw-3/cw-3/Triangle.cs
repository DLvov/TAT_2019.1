namespace cw_3
{
    /// <summary>
    /// This class is abstract triangle.
    /// </summary>
    public abstract class Triangle
    {
        public string Description { get; set; }
        public Point[] points = new Point[3];
        public double[] sides = new double[3];

        /// <summary>
        /// This constructor initialize points and sides of triangle.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        public Triangle(Point a, Point b, Point c)
        {
            points[0] = a;
            points[1] = b;
            points[2] = c;
            sides[0] = points[0].GetDistance(points[1]);
            sides[1] = points[1].GetDistance(points[2]);
            sides[2] = points[2].GetDistance(points[0]);
        }

        public abstract double GetSquare();
    }
}