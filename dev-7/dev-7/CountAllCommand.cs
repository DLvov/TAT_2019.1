using System;

namespace dev_7
{
    class CountAllCommand : Command
    {
        public CountAllCommand(VehicleCatalog catalog)
        {
            Catalog = catalog;
        }

        public override void Execute()
        {
            Console.WriteLine(Catalog.GetAmountCount());
        }
    }
}