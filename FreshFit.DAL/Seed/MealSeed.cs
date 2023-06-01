using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FreshFit.Model.Enums;
using FreshFit.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshFit.DAL.Seed
{
    public class MealSeed
    {
        public void AddMealData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>().HasData(
                new Meal { ID =1,Name = Meals.Breakfast },
                new Meal { ID =2,Name = Meals.Lunch },
                new Meal { ID =3,Name = Meals.Dinner },
                new Meal { ID =4,Name = Meals.Aperitif }
                );
        }
    }
}
