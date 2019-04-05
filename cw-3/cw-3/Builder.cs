namespace cw_3
{
    /// <summary>
    /// This class is abstract builder.
    /// </summary>
    abstract class Builder
    {
        public Builder Successor { get; set; }
        public abstract Triangle CreateTriangle(Point a, Point b, Point c);
    }
}