using System;
using System.Collections.Generic;

namespace dev_5
{
    /// <summary>
    /// This class is entry point of programm.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This programm :
        ///     creates objects: Bird, Plane, SpaceShip
        ///     calls methods FlyTo() and GetFlyTime() for each one
        ///     and add flight times into list results
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            try
            {
                var destinationPoint = new Point(100, 200, 800);
                var flyableEntities = new IFlyable[3];
                flyableEntities[0] = new Bird();
                flyableEntities[1] = new Plane();
                flyableEntities[2] = new SpaceShip();
                var results = new List<double>();

                foreach (var item in flyableEntities)
                {
                    item.FlyTo(destinationPoint);
                    results.Add(item.GetFlyTime());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong!");
            }
        }
    }
}
