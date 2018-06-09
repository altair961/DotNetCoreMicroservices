namespace ShoppingCart
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ShoppingCart;

    public class ProductCatalogueClient : IProductCatalogueClient
    {
        public ProductCatalogueClient()
        {
            shoppingCartItems.Add(new ShoppingCartItem(1, "Engine", "A rocket engine", new Money("eur", 2000)));
            shoppingCartItems.Add(new ShoppingCartItem(2, "Chip", "ARM chip", new Money("eur", 1)));
            shoppingCartItems.Add(new ShoppingCartItem(3, "Display", "256 color display", new Money("eur", 5)));
            shoppingCartItems.Add(new ShoppingCartItem(4, "Board", "A board for embedded system", new Money("eur", 3)));
        }
        private IList<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();

        public async Task<IList<ShoppingCartItem>> GetShoppingCartItems(int[] productCatalogueIds)
        {
            return shoppingCartItems.Where(x => productCatalogueIds.Any(y => x.ProductCatalogueId == y)).ToList();
        }
    }
}