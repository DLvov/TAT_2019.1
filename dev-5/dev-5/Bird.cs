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
            return 0;
        }
    }
}