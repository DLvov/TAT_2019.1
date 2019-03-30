using System;

namespace dev_5
{
    class Bird : FlyingEntity
    {
        public Bird()
        {
            Name = "Bird"; 
        }

        public override double GetFlyTime()
        {
            var random = new Random();
            Speed = random.Next(0, 20);
            return currentPoint.getDistance(prevPoint) / Speed;
        }
    }
}