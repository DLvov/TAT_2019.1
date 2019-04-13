using System;

namespace dev_7
{
    /// <summary>
    /// This class is a command for showing the average price of vehicles in the catalog.
    /// </summary>
    class AveragePriceCommand : Command
    {
        /// <summary>
        /// This constructor sets catalog property.
        /// </summary>
        /// <param name="catalog">Catalog of vehicles</param>
        public AveragePriceCommand(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// This method shows average price of vehicles in the catalog.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Catalog?.GetAveragePrice());
        }
    }
}