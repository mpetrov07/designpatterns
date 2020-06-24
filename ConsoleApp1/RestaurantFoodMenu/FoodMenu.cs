using ConsoleApp1.FoodDeliveryDriver;
using ConsoleApp1.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantFoodMenu
{
    public class FoodMenu : IFoodMenu
    {
        private string restaurantId;
        public FoodMenu(string restaurantId)
        {
            this.restaurantId = restaurantId;
        }
        public List<FoodMenuModel> GetFoodMenuItems()
        {
            FoodMenuService foodMenuService = new FoodMenuService(string.Empty, restaurantId);
            var foodMenuItems = foodMenuService.getAllFoodMenu(restaurantId);

            return foodMenuItems;
        }

        public IIterator CreateFoodMenuIterator()
        {
            var foodMenuItems = GetFoodMenuItems();
            return new RestaurantFoodMenuIterator(foodMenuItems);
        }
    }
}