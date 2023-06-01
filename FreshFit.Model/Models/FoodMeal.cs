using FreshFit.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFit.Model.Models
{
    public class FoodMeal : Base
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public int UserID { get; set; } 
        public double GainCalory { get; set; }
        public double GainCarbohydrate { get; set; }
        public double GainProtein { get; set; }
        public double GainFat { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }

    }
}
