using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Abstract;
using FreshFit.Model.Enums;

namespace FreshFit.Model.Models
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Mail { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Password { get; set; }
        public Gender Genders { get; set; }
        public string FavoriteFood { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[]? UserPictureByte { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; } = new List<FoodMeal>();
        public virtual ICollection<Water> Waters { get; set; } = new List<Water>();
        public virtual ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();


    }
}
