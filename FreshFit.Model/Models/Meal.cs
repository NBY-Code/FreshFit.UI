using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Abstract;
using FreshFit.Model.Enums;

namespace FreshFit.Model.Models
{
    public class Meal : Base
    {
        public Meals Name { get; set; }

        public virtual ICollection<FoodMeal> FoodMeals { get; set; } = new List<FoodMeal>();
    }
}
