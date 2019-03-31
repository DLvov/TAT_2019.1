namespace dev_5
{
    /// <summary>
    /// This class corresponds to the space ship.
    /// Speed for space ship will be measured in km/s.
    /// </summary>
    class SpaceShip : FlyingEntity
    {
        /// <summary>
        /// This construcor initialize name and speed.
        /// </summary>
        public SpaceShip()
        {
            Name = "SpaceShip";
            Speed = 8000;
        }

        /// <summary>
        /// This method returns space ship last flight time. Speed of the space ship constant and equals 8000 km/s
        /// </summary>
        /// <returns>Time of the last flight in seconds</returns>
        public override double GetFlyTime()
        {
            return CurrentPoint.getDistance(PrevPoint) / Speed;
        }
    }
}