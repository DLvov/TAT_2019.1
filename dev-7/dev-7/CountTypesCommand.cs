using System;

namespace dev_7
{
    /// <summary>
    /// This class is a command for showing the number of vehicle brands in the catalog.
    /// </summary>
    class CountTypesCommand : Command
    {
        /// <summary>
        /// This constructor sets catalog property.
        /// </summary>
        /// <param name="catalog">Catalog of vehicles</param>
        public CountTypesCommand(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// This method shows the number of vehicle brands in the catalog.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Catalog?.GetBrandCount());
        }
    }
}