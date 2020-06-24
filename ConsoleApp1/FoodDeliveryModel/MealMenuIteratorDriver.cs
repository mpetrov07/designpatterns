using ConsoleApp1.FoodDeliveryDriver;
using ConsoleApp1.RestaurantFoodMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FoodDeliveryModel
{
    public class MealMenuIteratorDriver
    {
        public List<FoodMenuModel> PrintMealMenu(string restaurantId)
        {
            Waitress waitress = new Waitress(restaurantId);
            var foodMenu = waitress.PrintFoodMenu();
            return foodMenu;
        }
    }
}
