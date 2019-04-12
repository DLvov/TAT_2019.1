using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_7
{
    class Car : Vehicle
    {
        public Car(string brand, string model, int amount, int price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Amount = amount;
            this.Price = price;
        }
    }
}
