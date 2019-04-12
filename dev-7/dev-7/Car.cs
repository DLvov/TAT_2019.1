namespace dev_7
{
    class Car : Vehicle
    {
        public Car(string brand, string model, int amount, int price)
        {
            this.Brand = brand.ToUpper();
            this.Model = model.ToUpper();
            this.Amount = amount;
            this.Price = price;
        }
    }
}
