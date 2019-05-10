namespace dev_7
{
    /// <summary>
    /// This class is a truck.
    /// </summary>
    class Truck : Vehicle
    {
        /// <summary>
        /// This constructor sets brand, model, amount and price properties.
        /// </summary>
        /// <param name="brand">Brand name</param>
        /// <param name="model">Model name</param>
        /// <param name="amount">Amount</param>
        /// <param name="price">Price</param>
        public Truck(string brand, string model, int amount, int price)
        {
            this.Brand = brand.ToUpper();
            this.Model = model.ToUpper();
            this.Amount = amount;
            this.Price = price;
        }
    }
}
