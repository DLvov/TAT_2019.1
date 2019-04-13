using System;

namespace dev_7
{
    /// <summary>
    /// This class is a command for showing the total number of vehicles, the number of vehicle brands,
    /// the average price of vehicles and the average price of vehicles of a certain brand in the catalog.
    /// </summary>
    class ExcecuteCommand : Command
    {
        /// <summary>
        /// This constructor sets catalog property.
        /// </summary>
        /// <param name="catalog">Catalog of vehicles</param>
        public ExcecuteCommand(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// This method shows the total number of vehicles, the number of vehicle brands,
        /// the average price of vehicles and the average price of vehicles of a certain brand in the catalog.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Catalog?.GetAmountCount());
            Console.WriteLine(Catalog?.GetBrandCount());
            Console.WriteLine(Catalog?.GetAveragePrice());
            Console.WriteLine("Enter brand");
            Console.WriteLine(Catalog?.GetAveragePrice(Console.ReadLine()));
        }
    }
}
