using System;
using System.Collections.Generic;
using System.Linq;

namespace dev_7
{
    class VehicleCatalog
    {
        public IEnumerable<Vehicle> Catalog { get; set; }

        public VehicleCatalog(IEnumerable<Vehicle> vehicleList)
        {
            Catalog = vehicleList;
        }

        public int GetBrandCount()
        {
            return Catalog.Select(vehicle => vehicle.Brand).Distinct().Count();
        }

        public int GetAmountCount()
        {
            return Catalog.Select(vehicle => vehicle.Amount).Sum();
        }

        public double GetAveragePrice()
        {
            return Catalog.Select(vehicle => vehicle.Price).Average();
        }

        public double GetAveragePrice(string brand)
        {
            if (Catalog.Select(vehicle => vehicle.Brand).Contains(brand.ToUpper()))
            {
                return Catalog.Where(vehicle => vehicle.Brand == brand.ToUpper()).Select(vehicle => vehicle.Price).Average();
            }
            else
            {
                throw new FormatException("Brand not found!");
            }
        }
    }
}
