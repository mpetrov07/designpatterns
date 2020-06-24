using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantSearch
{
    public abstract class AbstractExpression
    {
        public abstract List<RestaurantModel> Interpret(InterpreterContext context);
    }
}
