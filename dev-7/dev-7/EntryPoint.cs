using System;

namespace dev_7
{
    /// <summary>
    /// Entry point of the programm.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This method reads two XML files, requests vehicle type and command from user.
        /// </summary>
        /// <param name="args">Two names of XML files. The first XML file must be with cars, second - with trucks</param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new FormatException("The program must accept two XML file names!");
                }
                var vehicleTypeHandler = new VehicleTypeHandler();
                int vehicleType = vehicleTypeHandler.RequestVehicleType();
                VehicleCatalog catalog;

                switch (vehicleType)
                {
                    case (int)VehicleTypes.Car:
                        catalog = new VehicleCatalog(VehicleGetterFromXML.GetCarsFromXML(args[(int)TypesOfXML.Car]));
                        break;
                    case (int)VehicleTypes.Truck:
                        catalog = new VehicleCatalog(VehicleGetterFromXML.GetTrucksFromXML(args[(int)TypesOfXML.Truck]));
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
