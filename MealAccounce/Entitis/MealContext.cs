using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.Models
{
    public class MealContext : DbContext
    {
        public MealContext(DbContextOptions<MealContext> options) :base(options)
        {

        }
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Meal> Meals { get; set; }
    }
}
