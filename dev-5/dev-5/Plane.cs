namespace dev_5
{
    class Plane : FlyingEntity
    {
        public Plane()
        {
            Name = "Plane";
            Speed = 200;
            // starting speed == 200 km/h
        }

        public override double GetFlyTime()
        {
            return 0;
        }
    }
}