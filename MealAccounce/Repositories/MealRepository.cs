using MealAccounce.IRepositories;
using MealAccounce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.Repositories
{
    public class MealRepository : IMealRepository
    {
        private MealContext _context;
        public MealRepository(MealContext context)
        {
            _context = context;
        }
        public Meal GetMealById(int id)
        {
            var meal = _context.Meals.Where(x => x.Id == id).FirstOrDefault();
            return meal;
        }
    }
}
