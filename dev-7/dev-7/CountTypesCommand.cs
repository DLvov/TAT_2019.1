using System;

namespace dev_7
{
    class CountTypesCommand : Command
    {
        public CountTypesCommand(VehicleCatalog catalog)
        {
            Catalog = catalog;
        }

        public override void Execute()
        {
            Console.WriteLine(Catalog.GetBrandCount());
        }
    }
}