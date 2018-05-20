namespace ShoppingCart.ShoppingCart
{
    using System;
    using Nancy;
    using Nancy.ModelBinding;

    public class ShoppingCartModule : NancyModule
    {
        public ShoppingCartModule() : base("/shoppingcart")
        {
            Get<string>("/{userid:int}", parameters =>
            {
                var userId = (int)parameters.userid;
                return "l";
            });
        }
    }
}