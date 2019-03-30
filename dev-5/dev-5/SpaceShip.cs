namespace dev_5
{
    class SpaceShip : FlyingEntity
    {
        public SpaceShip()
        {
            Name = "SpaceShip";
            Speed = 8000;
            // speed == 8000 km/s
        }

        public override double GetFlyTime()
        {
            return currentPoint.getDistance(prevPoint) / Speed;
        }
    }
}