using MealAccounce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.IRepositories
{
    public interface IMealRepository
    {
        public Meal GetMealById(int id);
    }
}
