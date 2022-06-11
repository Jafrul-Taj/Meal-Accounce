using MealAccounce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.Controllers
{
    public class EmployeeController : Controller
    {
        private MealContext _context;

        public EmployeeController(MealContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Employee());
            }
            else
            {
                var meal = await _context.Employees.FindAsync(id);
                // meal.mealDate =(Date) meal.mealDate.Date;
                return View(meal);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id", "EmployeeId", "EmployeeName", "Designation")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                {
                    _context.Add(employee);
                }
                else
                {
                    _context.Update(employee);
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Employee");
        }
    }
}
