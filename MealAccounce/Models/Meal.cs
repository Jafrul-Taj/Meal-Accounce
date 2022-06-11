using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealAccounce.Models
{
    public class Meal
    {
        private DateTime _mealDate = DateTime.MinValue;
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Total Member")]
        public int TotalMemberOfTheMeal { get; set; }
        [Required]
        [DisplayName("Payment By")]
        public string PaymentBy { get; set; }
        [Required]
        [DisplayName("Total Payment")]
        public int TotalPayMent { get; set; }
        
        public int IsCompleted { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        [DisplayName("Meal Date")]
        public DateTime mealDate 
        {
            get
            {
                return (_mealDate == DateTime.MinValue) ? DateTime.Now : _mealDate;
            }
            set
            {
                _mealDate = value;
            }
        }
    }
}
