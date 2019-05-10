using System;

namespace dev_7
{
    /// <summary>
    /// This class requests type of vehicle from user.
    /// </summary>
    class VehicleTypeHandler
    {
        /// <summary>
        /// This method requests type of vehicle from user and return it.
        /// </summary>
        /// <returns>Type of vehicle</returns>
        public int RequestVehicleType()
        {
            DisplayInfo();

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int vehicleTypeNumber))
                {
                    if ((int)VehicleTypes.Car == vehicleTypeNumber || (int)VehicleTypes.Truck == vehicleTypeNumber)
                    {
                        return (vehicleTypeNumber == (int)VehicleTypes.Car) ? (int)VehicleTypes.Car : (int)VehicleTypes.Truck;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number of vehicle!");
                        DisplayInfo();
                    }
                }
            }
        }

        /// <summary>
        /// This method displays information for user.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine("-----------------------------------\n" + "Enter type of vehicle(1-2):\n" + 
                $"1. Car\n" + $"2. Truck\n" + "-----------------------------------");
        }
    }
}
