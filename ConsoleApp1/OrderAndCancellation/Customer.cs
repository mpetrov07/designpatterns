using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OrderAndCancellation
{
    public class Customer
    {
        List<IFoodOrderCommands> orderList = new List<IFoodOrderCommands>();

        public void TakeOrder(IFoodOrderCommands order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in orderList)
            {
                order.Execute();
            }

            orderList.Clear();
        }
    }
}

