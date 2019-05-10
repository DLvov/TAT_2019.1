namespace dev_7
{
    /// <summary>
    /// This class is a car.
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// This constructor sets brand, model, amount and price properties.
        /// </summary>
        /// <param name="brand">Brand name</param>
        /// <param name="model">Model name</param>
        /// <param name="amount">Amount</param>
        /// <param name="price">Price</param>
        public Car(string brand, string model, int amount, int price)
        {
            this.Brand = brand.ToUpper();
            this.Model = model.ToUpper();
            this.Amount = amount;
            this.Price = price;
        }
    }
}
