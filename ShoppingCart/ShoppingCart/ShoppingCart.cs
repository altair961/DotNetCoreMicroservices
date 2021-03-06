using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.ShoppingCart
{
    public class ShoppingCart
    {
        public int UserId { get; }
        public HashSet<ShoppingCartItem> Items { get { return items; } }
        private HashSet<ShoppingCartItem> items = new HashSet<ShoppingCartItem>();
        public ShoppingCart(int userId)
        {
            this.UserId = userId;
        }

        public void AddItems(IEnumerable<ShoppingCartItem> shoppingCartItems) //, IEventStore eventStore)
        {
            foreach (var item in shoppingCartItems)
                if (this.items.Add(item));
                    //then generate event
                    // eventStore.Raise("ShoppingCartItemAdded", new { UserId, item });
        }

        public void RemoveItems(int[] productCatalogueIds) //, IEventStore eventStore)
        {
            items.RemoveWhere(i => productCatalogueIds.Contains(i.ProductCatalogueId));
        }
    }
}