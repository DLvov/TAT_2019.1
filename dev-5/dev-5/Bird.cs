using System;

namespace dev_5
{
    /// <summary>
    /// This class corresponds to the bird.
    /// Speed for bird will be measured in km/h.
    /// </summary>
    class Bird : FlyingEntity
    {
        /// <summary>
        /// This constructor initialize Name.
        /// </summary>
        public Bird()
        {
            Name = "Bird"; 
        }

        /// <summary>
        /// This method returns bird last flight time at random speed in the range of (0-20).
        /// </summary>
        /// <returns>Time of the last flight in seconds</returns>
        public override double GetFlyTime()
        {
            int secondsInHour = 3600;
            var random = new Random();
            Speed = random.Next(0, 20);
            return CurrentPoint.getDistance(PrevPoint) / Speed * secondsInHour;
        }
    }
}