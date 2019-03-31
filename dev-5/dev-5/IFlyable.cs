namespace dev_5
{
    /// <summary>
    /// This interface requires you to create 3 methods: FLyTo, WhoAmI, GetFlyTime.
    /// </summary>
    interface IFlyable
    {
        void FlyTo(Point newPoint);
        string WhoAmI();
        double GetFlyTime();
    }
}