namespace dev_5
{
    /// <summary>
    /// This class corresponds to the plane.
    /// Speed for plane will be measured in km / h.
    /// </summary>
    class Plane : FlyingEntity
    {
        private const int INITIAL_SPEED = 200;

        /// <summary>
        /// This constructor inicialize name and speed.
        /// </summary>
        public Plane()
        {
            Name = "Plane";
            Speed = INITIAL_SPEED;
        }

        /// <summary>
        /// This method returns plane flight time. Plane speed increases by 10 km/h every 10 km.
        /// After the flight the speed of the plane becomes the initial.
        /// </summary>
        /// <returns>Time of the flight</returns>
        public override double GetFlyTime()
        {
            double time = 0;
            double remainingDistance = currentPoint.getDistance(prevPoint);
            int acceleration = 10;
            int accelerationDistance = 10;

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