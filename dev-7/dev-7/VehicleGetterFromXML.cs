using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace dev_7
{
    /// <summary>
    /// This class for parsing XML file
    /// </summary>
    static class VehicleGetterFromXML
    {
        /// <summary>
        /// This method loads XML file and gets cars from it.
        /// </summary>
        /// <param name="fileName">Name of XML file with cars</param>
        /// <returns>Collection of cars</returns>
        public static IEnumerable<Car> GetCarsFromXML(string fileName)
        {
            var Doc = new XDocument();
            Doc = XDocument.Load($"../../{fileName}.xml");

            return Doc.Element("cars").Elements("car").Select(c => new Car
            (
                c.Element("brand").Value != string.Empty ? c.Element("brand").Value.ToLower() : throw new FormatException("Brand cannot be Empty!"),
                c.Element("model").Value != string.Empty ? c.Element("model").Value.ToLower() : throw new FormatException("Model cannot be Empty!"),
                int.TryParse(c.Element("amount").Value, out int amount) ? amount : throw new FormatException("Amount cannot be negative!"),
                int.TryParse(c.Element("price").Value, out int price) ? price : throw new FormatException("Price cannot be negative!")
             ));
        }

        /// <summary>
        /// This method loads XML file and gets trucks from it.
        /// </summary>
        /// <param name="fileName">Name of XML file with trucks</param>
        /// <returns>Collection of trucks</returns>
        public static IEnumerable<Truck> GetTrucksFromXML(string fileName)
        {
            var Doc = new XDocument();
            Doc = XDocument.Load($"../../{fileName}.xml");

            return Doc.Element("trucks").Elements("truck").Select(t => new Truck
            (
                t.Element("brand").Value != string.Empty ? t.Element("brand").Value.ToLower() : throw new FormatException("Brand cannot be Empty!"),
                t.Element("model").Value != string.Empty ? t.Element("model").Value.ToLower() : throw new FormatException("Model cannot be Empty!"),
                int.TryParse(t.Element("amount").Value, out int amount) ? amount : throw new FormatException("Amount cannot be negative!"),
                int.TryParse(t.Element("price").Value, out int price) ? price : throw new FormatException("Price cannot be negative!")
             ));
        }
    }
}
