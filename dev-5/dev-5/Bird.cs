using System;

namespace dev_5
{
    /// <summary>
    /// This class corresponds to the bird.
    /// Speed for bird will be measured in km / h.
    /// </summary>
    class Bird : FlyingEntity
    {
        /// <summary>
        /// This constructor inicialize Name.
        /// </summary>
        public Bird()
        {
            Name = "Bird"; 
        }

        /// <summary>
        /// This method returns bird flight time at random speed in the range of (0-20).
        /// </summary>
        /// <returns>Time of the flight</returns>
        public override double GetFlyTime()
        {
            var random = new Random();
            Speed = random.Next(0, 20);
            return currentPoint.getDistance(prevPoint) / Speed;
        }
    }
}