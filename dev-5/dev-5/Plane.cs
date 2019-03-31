namespace dev_5
{
    class Plane : FlyingEntity
    {
        private const int INITIAL_SPEED = 200; // km/h

        public Plane()
        {
            Name = "Plane";
            Speed = INITIAL_SPEED;
        }

        public override double GetFlyTime()
        {
            double time = 0;
            double remainingDistance = currentPoint.getDistance(prevPoint);
            int acceleration = 10;
            int accelerationDistance = 10; // speed raising each 10 km

            while(remainingDistance > 0)
            {
                if (remainingDistance > accelerationDistance)
                {
                    time += accelerationDistance / Speed;
                    Speed += acceleration;
                    remainingDistance -= accelerationDistance;
                }
                else
                {
                    time += remainingDistance / Speed;
                    remainingDistance = 0;
                    Speed = INITIAL_SPEED;
                }
            }

            return time;
        }
    }
}