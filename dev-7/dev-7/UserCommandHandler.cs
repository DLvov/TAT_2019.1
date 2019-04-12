using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    class UserCommandHandler
    {
        private enum UserCommands
        {
            CountTypes = 1,
            CountAll,
            AveragePrice,
            AveragePriceType,
            Execute,
            Exit
        }

        public VehicleCatalog Catalog { get; set; }

        public UserCommandHandler(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        public void RequestUserCommand()
        {

        }
    }
}
