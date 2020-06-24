using ConsoleApp1.FoodDeliveryDriver;
using ConsoleApp1.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantSearch
{
    public class InterpreterContext
    {
        private RestaurantService restaurantService;

        public InterpreterContext(String endpoint)
        {
            restaurantService = new RestaurantService(endpoint);
        }

        public List<RestaurantModel> GetAllRestaurants()
        {
            return restaurantService.GetAllRestaurants();
        }
    }
}
