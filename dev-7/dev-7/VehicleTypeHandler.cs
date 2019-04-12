using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    class VehicleTypeHandler
    {
        private Dictionary<int, string> vehicleTypes = new Dictionary<int, string> { {1, "car"}, {2, "truck"} };

        public string RequestVehicleType()
        {
            DisplayInfo();

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int vehicleTypeNumber))
                {
                    if (vehicleTypes.ContainsKey(vehicleTypeNumber))
                    {
                        return vehicleTypes[vehicleTypeNumber];
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number of vehicle!");
                        DisplayInfo();
                    }

                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Enter type of vehicle(1-2):\n" + $"1. Car\n" + $"2. Truck");
        }
    }
}
