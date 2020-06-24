using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantWebService
{
    public class FoodMenuService
    {
        public FoodMenuService(string endPoint, string restaurantId)
        {
            // TODO Initialize web service with the endpoint string.
            // Data for food Menu items will fetch based on the Restaurant Id.
        }

        public List<FoodMenuModel> getAllFoodMenu(string restaurantId)
        {
            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "001", Cuisine = "Chinese", FoodName = "Chicken wings in Chinese", Rating = 5, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "002", Cuisine = "Indian", FoodName = "Chickpea and lentil meatballs", Rating = 4, Rate = 300 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "003", Cuisine = "Italian", FoodName = "Spaghetti bolognese", Rating = 5, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "004", Cuisine = "Japanese", FoodName = "Сushi", Rating = 3, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "005", Cuisine = "Bulgarian", FoodName = "Beans with sausage", Rating = 10, Rate = 100 });
            return foodMenu;
        }
    }
}

