using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OrderAndCancellation
{
    public class CancelFood : IFoodOrderCommands
    {
        private Food food;
        public string OrderId;

        public CancelFood(Food food)
        {
            this.food = food;
        }

        public void Execute()
        {
            food.CancelFood(OrderId);
        }
    }
}
