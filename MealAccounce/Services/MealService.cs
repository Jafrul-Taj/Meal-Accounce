using MealAccounce.IRepositories;
using MealAccounce.IServices;
using MealAccounce.Models;
using MealAccounce.ViewModel;

namespace MealAccounce.Services
{
    public class MealService : IMealService
    {
        private readonly IMealRepository _mealRepository;
        public MealService(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }
        public MealModel GetMealById(int id)
        {
            Meal meal;
            meal = _mealRepository.GetMealById(id);

            var mealmodel = new MealModel();
            mealmodel.Id = meal.Id;

            return mealmodel;
        }
    } 
}
