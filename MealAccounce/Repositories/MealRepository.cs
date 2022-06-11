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
            return _context.Meals.Find(id);
        }
    }
}
