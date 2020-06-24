using ConsoleApp1.FoodBuilding;
using ConsoleApp1.FoodDeliveryDriver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FoodDeliveryModel
{
    public class MealBuilderDriver
    {
        public double BuildMealForUser(List<FoodMenuModel> selectedMealItems)
        {
            Console.WriteLine();
            Console.WriteLine("You Selected Below Meal Items");
            Console.WriteLine("_______________________________");
            MealBuilder mealBuilder = new MealBuilder();
            mealBuilder.PrepareMeal(selectedMealItems);
            mealBuilder.meal.ShowItems();
            var totalCost = mealBuilder.meal.GetCost();
            Console.WriteLine("Total Cost(Rs.): {0}", totalCost);
            return totalCost;
        }
    }
}
