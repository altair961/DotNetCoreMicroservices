namespace ShoppingCart.ShoppingCart
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class ShoppingCartModule : NancyModule
    {
        //public ShoppingCartModule(IShoppingCartStore shoppingCartStore) : base("/shoppingcart")
        // {
        //     Get("/{userId:int}", parameters =>
        //     {
        //         var userId = (int) parameters.userId;
        //         //return shoppingCartStore.Get(userId);
        //         return 5;
        //     });        

        //     //Get("/", _ => DateTime.UtcNow);
        // }

        // public ShoppingCartModule()
        // {
        //     Get("/", _ => DateTime.UtcNow);
        // }
     /*   
        public ShoppingCartModule()
        {
            Get("/", parameters => 
            { 
                return DateTime.UtcNow; 
            });
        }
        */
          
        public ShoppingCartModule() : base("/shoppingcart")
        {
            Get("/{userid:int}", parameters => 
            { 
                return DateTime.UtcNow; 
            });
        }
        
    }
}