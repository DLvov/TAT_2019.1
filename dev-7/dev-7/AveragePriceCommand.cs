using System;

namespace dev_7
{
    class AveragePriceCommand : Command
    {
        public AveragePriceCommand(VehicleCatalog catalog)
        {
            Catalog = catalog;
        }

        public override void Execute()
        {
            Console.WriteLine(Catalog.GetAveragePrice());
        }
    }
}