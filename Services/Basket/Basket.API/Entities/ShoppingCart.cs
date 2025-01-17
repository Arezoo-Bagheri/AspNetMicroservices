﻿namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Item { get; set; } = new List<ShoppingCartItem>();


        public ShoppingCart()
        {
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Item)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }


    }
}
