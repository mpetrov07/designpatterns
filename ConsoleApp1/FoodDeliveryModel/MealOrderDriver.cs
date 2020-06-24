using ConsoleApp1.FoodDeliveryDriver;
using ConsoleApp1.OrderAndCancellation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FoodDeliveryModel
{
    public class MealOrderDriver
    { 
        public char MealOrderByUser(List<FoodMenuModel> selectedMealItems, double totalCost, string restaurantId, out string orderId, out UserModel user)
        {
        Console.WriteLine(string.Empty);
        Console.WriteLine("Do you want to place order(y/n)...?");
        var wantsOrder = Console.ReadKey().KeyChar;
        Console.WriteLine(string.Empty);

        orderId = string.Empty;
        user = null;

        if (wantsOrder == 'y')
        {
            Console.WriteLine("_________________________");
            Food food = new Food();
            OrderFood orderFood = new OrderFood(food);
            orderFood.FoodItems = selectedMealItems;
            orderFood.User = new UserModel();
            orderFood.User.UserId = "mpetrov";
            orderFood.User.UserName = "Milen Petrov";
            orderFood.User.Address = "Veliko Tarnovo";
            orderFood.User.PhoneNumber = "0889888888";
            orderFood.User.Amount = totalCost;
            orderFood.RestaurantId = restaurantId;
            user = orderFood.User;
            Customer customer = new Customer();
            customer.TakeOrder(orderFood);
            customer.PlaceOrders();
            orderId = orderFood.OrderId;
            Console.WriteLine(string.Empty);
        }

        //Order Cancellation.
        char cancel = 'n';
        if (!string.IsNullOrEmpty(orderId))
        {
            Console.WriteLine("Do you want to cancel order(y/n)...?");
            cancel = Console.ReadKey().KeyChar;
            Console.WriteLine(string.Empty);

            if (cancel == 'y')
            {
                Console.WriteLine(String.Empty);
                Food food = new Food();
                CancelFood cancelOrder = new CancelFood(food);
                cancelOrder.OrderId = orderId;
                Customer customer = new Customer();
                customer.TakeOrder(cancelOrder);
                customer.PlaceOrders();
            }
        }

        return cancel;
    }
}
}
