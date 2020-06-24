using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantWebService
{
    public class RestaurantService
    {
        public RestaurantService(string endPoint)
        {
            // TODO Initialize web service with the endpoint string.
        }

        public List<RestaurantModel> GetAllRestaurants()
        {
            List<RestaurantModel> restaurants = new List<RestaurantModel>();
            restaurants.Add(new RestaurantModel { RestaurantId = "001", Name = "Shtasliveca", Address = "ul.Stefan Stambolov 79", Rating = 5 });
            restaurants.Add(new RestaurantModel { RestaurantId = "002", Name = "Restaurant Bianko", Address = "ul.Stoqn Mihailovski 5000", Rating = 3 });
            restaurants.Add(new RestaurantModel { RestaurantId = "003", Name = "Asenevci", Address = "ul.Aleksandar Stamboliiski 7", Rating = 4 });
            restaurants.Add(new RestaurantModel { RestaurantId = "004", Name = "Trinavis", Address = "bul.Bulgaria 29", Rating = 2 });
            restaurants.Add(new RestaurantModel { RestaurantId = "005", Name = "Boliari Tavern", Address = "bul.Vasil Levski 15", Rating = 4 });
            return restaurants;
        }
    }
}
