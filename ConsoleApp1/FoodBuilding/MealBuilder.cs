using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FoodBuilding
{
    public class MealBuilder
    {
        public Meal meal;
        public void PrepareMeal(List<FoodMenuModel> foodMenu)
        {
            meal = new Meal();
            meal.AddFoodItem(foodMenu);
        }
    }
}
