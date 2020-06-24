using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FoodDeliveryDriver
{
    public class FoodMenuModel
    {
        private string restaurantId;
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }

        private string foodId;
        public string FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }

        private string foodname;
        public string FoodName
        {
            get { return foodname; }
            set { foodname = value; }
        }

        private string cuisine;
        public string Cuisine
        {
            get { return cuisine; }
            set { cuisine = value; }
        }

        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
