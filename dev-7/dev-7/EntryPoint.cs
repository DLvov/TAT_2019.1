using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new FormatException("The program must accept two XML file names!");
                }
                var vehicleTypeHandler = new VehicleTypeHandler();
                string vehicleType = vehicleTypeHandler.RequestVehicleType();
                VehicleCatalog catalog;
                switch (vehicleType)
                {
                    case "car":
                        catalog = new VehicleCatalog(VehicleGetterFromXML.GetCarsFromXML(args[0]));
                        break;
                    case "truck":
                        catalog = new VehicleCatalog(VehicleGetterFromXML.GetTrucksFromXML(args[1]));
                        break;
                    default:
                        throw new Exception("Incorrect work of VehicleGetterFromXML or wrong switch logic!");
                }
                var commandHandler = new UserCommandHandler(catalog);
                commandHandler.RequestUserCommand();

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong!");
            }
        }
    }
}
