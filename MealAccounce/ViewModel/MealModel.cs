using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.ViewModel
{
    public class MealModel
    {
        //private DateTime _mealDate = DateTime.MinValue;

        public int Id { get; set; }

        public string Name { get; set; }
 
        public int TotalMemberOfTheMeal { get; set; }
 
        public string PaymentBy { get; set; }
 
        public int TotalPayMent { get; set; }

        public int IsCompleted { get; set; }
 
        public DateTime mealDate
        {
            get;
            set
          ;
        }
    }
}
