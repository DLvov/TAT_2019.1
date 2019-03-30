namespace dev_5
{
    abstract class FlyingEntity : IFlyable
    {
        public int Speed { get; set; }
        public abstract void FlyTo();
        public abstract void WhoAmI();
        public abstract double GetFlyTime();
    }
}