using MealAccounce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.Controllers
{
    public class MealController : Controller
    {
        private MealContext _context;

        public MealController(MealContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meals.ToListAsync());
        }
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Meal());
            }
            else
            {
                var meal = await _context.Meals.FindAsync(id);
                // meal.mealDate =(Date) meal.mealDate.Date;
                return View(meal);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id", "Name", "TotalMemberOfTheMeal", "PaymentBy", "TotalPayMent", "mealDate")] Meal meal)
        {
            if(ModelState.IsValid)
            {
                if (meal.Id == 0)
                {
                    _context.Add(meal);
                }
                else
                {
                    _context.Update(meal);
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Meal");
        }

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    var meal = await _context.Meals.FindAsync(id);
        //}
    }
}
