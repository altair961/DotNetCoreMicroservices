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
            shoppingCartItemsDatabase.Add(new ShoppingCartItem(1, "Engine", "A rocket engine", new Money("eur", 2000)));
            shoppingCartItemsDatabase.Add(new ShoppingCartItem(2, "Chip", "ARM chip", new Money("eur", 1)));
            shoppingCartItemsDatabase.Add(new ShoppingCartItem(3, "Display", "256 color display", new Money("eur", 5)));
            shoppingCartItemsDatabase.Add(new ShoppingCartItem(4, "Board", "A board for embedded system", new Money("eur", 3)));
        }
        private static readonly IList<ShoppingCartItem> shoppingCartItemsDatabase =
            new List<ShoppingCartItem>();

        public async Task<IList<ShoppingCartItem>> GetShoppingCartItems(int[] productCatalogueIds)
        {
            return shoppingCartItemsDatabase.Where(x => productCatalogueIds.Any(y => y == x.ProductCatalogueId)).ToList();
        }
    }
}