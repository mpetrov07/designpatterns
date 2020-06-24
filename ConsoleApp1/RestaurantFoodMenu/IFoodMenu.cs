using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.RestaurantFoodMenu
{
    public interface IFoodMenu
    {
        IIterator CreateFoodMenuIterator();
    }
}
