namespace ShoppingCart.ShoppingCart
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class ShoppingCartModule : NancyModule
    {          
        public ShoppingCartModule() : base("/shoppingcart")
        {
            Get("/{userid:int}", parameters => 
            { 
                return DateTime.UtcNow; 
            });
        }
        
    }
}