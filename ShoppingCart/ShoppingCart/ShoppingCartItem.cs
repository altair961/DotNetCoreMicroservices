namespace ShoppingCart.ShoppingCart
{
    public class ShoppingCartItem
    {
        public string ProductName { get; }
        public string Desscription { get; }
        public Money Price { get; }

        public ShoppingCartItem(string productName, string description, Money price)
        {
            this.ProductName = productName;
            this.Desscription = description;
            this.Price = price;
        }
    }
}