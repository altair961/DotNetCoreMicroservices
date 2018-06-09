using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingCart;
using ShoppingCart.ShoppingCart;

namespace ShoppingCart
{
    public interface IProductCatalogueClient
    {
        Task<IList<ShoppingCartItem>> GetShoppingCartItems(int[] productCatalogueIds);
    }
}