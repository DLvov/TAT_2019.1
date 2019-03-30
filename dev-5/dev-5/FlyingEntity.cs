namespace dev_5
{
    abstract class FlyingEntity : IFlyable
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Point currentPoint { get; set; }
        public Point prevPoint { get; set; }
        public abstract double GetFlyTime();

        public virtual string WhoAmI()
        {
            return "I am a " + Name;
        }

        public virtual void FlyTo(Point newPoint)
        {
            prevPoint = currentPoint;
            currentPoint = newPoint;
        }
    }
}