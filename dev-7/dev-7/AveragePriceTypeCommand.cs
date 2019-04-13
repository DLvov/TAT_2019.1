using System;

namespace dev_7
{
    /// <summary>
    /// This class is a command for showing the average price of vehicles of a certain brand in the catalog.
    /// </summary>
    class AveragePriceTypeCommand : Command
    {
        public string Brand;

        /// <summary>
        /// This constructor sets catalog and brand properties.
        /// </summary>
        /// <param name="catalog">Catalog of vehicles</param>
        /// <param name="brand">Brand for which the average price will be calculated</param>
        public AveragePriceTypeCommand(VehicleCatalog catalog, string brand)
        {
            this.Catalog = catalog;
            this.Brand = brand;
        }

        /// <summary>
        /// This method shows average price of vehicles of a certain brand in the catalog.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Catalog?.GetAveragePrice(Brand));
        }
    }
}