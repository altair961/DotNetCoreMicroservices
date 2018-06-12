namespace ShoppingCart.ShoppingCart
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class ShoppingCartModule : NancyModule
    {
        public ShoppingCartModule(IShoppingCartStore shoppingCartStore,
            IProductCatalogueClient productCatalogue) : base("/shoppingcart")
        {
            // See specified user's shopping cart object
            Get("/{userid:int}", parameters =>
            {
                var userId = (int)parameters.userid;
                
                return shoppingCartStore.Get(userId);
            });
            
            // Add (or assign) specified items 
            // available in products store to the shopping cart
            Post("/{userid:int}/items", async (parameters, _) =>
            {
                var productCatalogueIds = this.Bind<int[]>();
                var userId = (int) parameters.userid;
                
                var shoppingCart = shoppingCartStore.Get(userId);

                var shoppingCartItems = await
                    productCatalogue
                    .GetShoppingCartItems(productCatalogueIds)
                    .ConfigureAwait(false);
                
                shoppingCart.AddItems(shoppingCartItems);//, eventStore);
                // shoppingCartStore.Save(shoppingCart);

                return shoppingCart;
            });
        }
    }
}