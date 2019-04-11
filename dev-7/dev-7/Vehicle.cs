using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
