namespace ShoppingCart.ShoppingCart
{
    public class ShoppingCart
    {
        public int UserId { get; }
        public ShoppingCart(int userId)
        {
            this.UserId = userId;
        }
    }
}