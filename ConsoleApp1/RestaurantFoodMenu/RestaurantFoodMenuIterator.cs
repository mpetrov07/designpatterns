using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantFoodMenu
{
    public class RestaurantFoodMenuIterator : IIterator
    {
        List<FoodMenuModel> items;
        int position = 0;

        public RestaurantFoodMenuIterator(List<FoodMenuModel> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
                return false;
            else
                return true;
        }

        public object Next()
        {
            FoodMenuModel menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
