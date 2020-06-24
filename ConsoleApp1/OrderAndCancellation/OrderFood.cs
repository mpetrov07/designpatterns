using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OrderAndCancellation
{
    public class OrderFood : IFoodOrderCommands
    {
        private Food food;
        public List<FoodMenuModel> FoodItems;
        public UserModel User;
        public string OrderId;
        public string RestaurantId;

        public OrderFood(Food food)
        {
            this.food = food;
        }

        public void Execute()
        {
            OrderId = food.OrderFood(RestaurantId, User);
        }
    }
}
