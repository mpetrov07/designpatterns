using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tracking
{
    public class Restaurant : FoodDelivery
    {
        public Restaurant(string restaurantId, string orderId, string deliveryStatus) : base(restaurantId, orderId, deliveryStatus) { }
    }
}
