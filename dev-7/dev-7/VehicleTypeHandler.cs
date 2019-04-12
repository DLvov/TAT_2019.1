using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    class VehicleTypeHandler
    {
        private enum VehicleTypes
        {
            Car = 1,
            Truck
        }

        public string RequestVehicleType()
        {
            DisplayInfo();
            bool exit = false;
            int vehicleType;

            while (!exit)
            {
                if(int.TryParse(Console.ReadLine(), out vehicleType))
                {
                    
                }
            }

            return vehicleType;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Enter type of car(1-2):\n" + $"1. Car\n" + $"2. Truck");
        }
    }
}
