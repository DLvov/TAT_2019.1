namespace cw_3
{
    /// <summary>
    /// This class is abstract triangle.
    /// </summary>
    public abstract class Triangle
    {
        public string Description { get; set; }
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public double AB { get; set; }
        public double BC { get; set; }
        public double CA { get; set; }

        /// <summary>
        /// This constructor initialize points and sides of triangle.
        /// </summary>
        /// <param name="a">Point a</param>
        /// <param name="b">Point b</param>
        /// <param name="c">Point c</param>
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            AB = A.GetDistance(B);
            BC = B.GetDistance(C);
            CA = C.GetDistance(A);
        }

        public abstract double GetSquare();
    }
}