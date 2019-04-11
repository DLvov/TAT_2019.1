using System;

namespace dev_7
{
    class AveragePriceTypeCommand : Command
    {
        public string Brand;

        public AveragePriceTypeCommand(VehicleCatalog catalog, string brand)
        {
            Catalog = catalog;
            Brand = brand;
        }

        public override void Execute()
        {
            Console.WriteLine(Catalog.GetAveragePrice(Brand));
        }
    }
}