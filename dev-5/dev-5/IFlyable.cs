namespace dev_5
{
    interface IFlyable
    {
        void FlyTo(Point newPoint);
        string WhoAmI();
        double GetFlyTime();
    }
}