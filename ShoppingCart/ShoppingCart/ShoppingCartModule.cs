namespace ShoppingCart.ShoppingCart
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class ShoppingCartModule : NancyModule
    {
        public ShoppingCartModule()//(IShoppingCartStore shoppingCartStore) : base("/shoppingcart")
        {
            // Get<ShoppingCart>("/{userid:int}", parameters =>
            // {
            //     var userId = (int)parameters.userid;
                
            //     var result = shoppingCartStore.Get(userId);
            //     return result;
            // });

            Post("/{userid:int}/items",
                async (parameters, _) =>
                {
                    var productCatalogueIds = this.Bind<int[]>();
                  //  var userId = (int) parameters.userid;
                    
                   // var shoppingCart = shoppingCartStore.Get(userId);


                    
                    return productCatalogueIds[0].ToString();
                });
        }
    }
}