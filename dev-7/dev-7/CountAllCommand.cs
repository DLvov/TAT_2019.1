using System;

namespace dev_7
{
    /// <summary>
    /// This class is a command for showing the total number of vehicles in the catalog.
    /// </summary>
    class CountAllCommand : Command
    {
        /// <summary>
        /// This constructor sets catalog property.
        /// </summary>
        /// <param name="catalog">Catalog of vehicles</param>
        public CountAllCommand(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// This method shows the total number of vehicles in the catalog.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Catalog?.GetAmountCount());
        }
    }
}