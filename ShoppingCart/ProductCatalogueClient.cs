namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ShoppingCart;

    public class ProductCatalogueClient : IProductCatalogueClient
    {
        public ProductCatalogueClient()
        {
            shoppingCartItemsDatabase.Add(1, new ShoppingCartItem("Engine", "A rocket engine", new Money("eur", 2000)));
            shoppingCartItemsDatabase.Add(2, new ShoppingCartItem("Chip", "ARM chip", new Money("eur", 1)));
            shoppingCartItemsDatabase.Add(3, new ShoppingCartItem("Display", "256 color display", new Money("eur", 5)));
            shoppingCartItemsDatabase.Add(4, new ShoppingCartItem("Board", "A board for embedded system", new Money("eur", 3)));
        }
        private static readonly Dictionary<int, ShoppingCartItem> shoppingCartItemsDatabase =
            new Dictionary<int, ShoppingCartItem>();

        public async Task<IList<ShoppingCartItem>> GetShoppingCartItems(int[] productCatalogueIds)
        {
            return shoppingCartItemsDatabase.Where(x => productCatalogueIds.Any(y => x.Key == y))
                .Select(x => new ShoppingCartItem(x.Value.ProductName, x.Value.Desscription, x.Value.Price)).ToList();
        }
    }
}