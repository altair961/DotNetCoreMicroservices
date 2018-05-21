namespace ShoppingCart.ShoppingCart
{
    public class ShoppingCart
    {
        public int UserId { get; set; }
        public string HelloVariable { get; set; }
        public ShoppingCart(int userId)
        {
            this.UserId = userId;
            this.HelloVariable = "Hey!!!";

        }
        public ShoppingCart()
        {
        }
    }
}
