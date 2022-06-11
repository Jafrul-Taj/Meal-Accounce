using MealAccounce.Models;
using MealAccounce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.IServices
{
    public interface IMealService 
    {
        public MealModel GetMealById(int id);
    }
}
