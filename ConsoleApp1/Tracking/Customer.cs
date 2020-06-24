using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tracking
{
    public class Customers : ICustomers
    {

        #region Properties

        private UserModel userModel;
        private Restaurant restaurant;
        public Restaurant Restaurant
        {
            get { return restaurant; }
            set { restaurant = value; }
        }

        #endregion

        public Customers(UserModel userModel)
        {
            this.userModel = userModel;
        }

        #region Methods
        public void Update(FoodDelivery foodDelivery)
        {
            Console.WriteLine("Notified Restaurant ID {0} of Order ID {1}'s Food Delivery Status: {2}", foodDelivery.RestaurantId,
                foodDelivery.OrderId, foodDelivery.DeliveryStatus);
            Console.WriteLine("Date Time: {0}", foodDelivery.DeliveryTime);
        }

        #endregion

    }
}

