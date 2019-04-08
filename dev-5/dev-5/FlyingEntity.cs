namespace dev_5
{
    /// <summary>
    /// This abstract class represents the flying entity, and implements the interface IFlyable.
    /// </summary>
    abstract class FlyingEntity : IFlyable
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Point CurrentPoint { get; set; }
        public Point PrevPoint { get; set; }

        /// <summary>
        /// This method will return flight time after override.
        /// </summary>
        /// <returns>Flight time</returns>
        public abstract double GetFlyTime();

        /// <summary>
        /// This method returns a string describing the object.
        /// </summary>
        /// <returns>string describing the object</returns>
        public virtual string WhoAmI()
        {
            return "I am a " + Name;
        }

        /// <summary>
        /// This method change the current point of flying entity.
        /// </summary>
        /// <param name="newPoint">Point to which the object will move</param>
        public virtual void FlyTo(Point newPoint)
        {
            PrevPoint = CurrentPoint;
            CurrentPoint = newPoint;
        }
    }
}