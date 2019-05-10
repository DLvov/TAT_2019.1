using System;
using System.Collections.Generic;
using System.Linq;

namespace dev_7
{
    /// <summary>
    /// This class is catalog of vehicles.
    /// </summary>
    class VehicleCatalog
    {
        public IEnumerable<Vehicle> Catalog { get; set; }

        /// <summary>
        /// This constructor sets the catalog property.
        /// </summary>
        /// <param name="vehicles">Collection of vehicle</param>
        public VehicleCatalog(IEnumerable<Vehicle> vehicles)
        {
            this.Catalog = vehicles;
        }

        /// <summary>
        /// This method returns the number of brands in the catalog.
        /// </summary>
        /// <returns>Number of brands in the catalog</returns>
        public int GetBrandCount()
        {
            return Catalog.Select(vehicle => vehicle.Brand).Distinct().Count();
        }

        /// <summary>
        /// This method returns the total number of vehicles in the catalog.
        /// </summary>
        /// <returns>Total number of vehicles in the catalog</returns>
        public int GetAmountCount()
        {
            return Catalog.Select(vehicle => vehicle.Amount).Sum();
        }

        /// <summary>
        /// This method returns the average price of vehicles in the catalog.
        /// </summary>
        /// <returns>Average price of vehicles in the catalog</returns>
        public double GetAveragePrice()
        {
            return Catalog.Select(vehicle => vehicle.Price).Average();
        }

        /// <summary>
        /// This method returns the average price of vehicles of a certain brand in the catalog.
        /// </summary>
        /// <param name="brand">Brand for which the average price will be calculated</param>
        /// <returns>Average price of vehicles of a certain brand in the catalog</returns>
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
