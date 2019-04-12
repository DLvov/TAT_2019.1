using System;

namespace dev_7
{
    class ExcecuteCommand : Command
    {
        public ExcecuteCommand(VehicleCatalog catalog)
        {
            Catalog = catalog;
        }

        public override void Execute()
        {
            Console.WriteLine(Catalog.GetAmountCount());
            Console.WriteLine(Catalog.GetBrandCount());
            Console.WriteLine(Catalog.GetAveragePrice());
            Console.WriteLine(Catalog.GetAveragePrice("volvo"));
        }
    }
}
