using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FreshFit.DAL.Seed;
using FreshFit.Model.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace FreshFit.DAL.Entity
{
    public class FreshFitContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodMeal> FoodMeals { get; set; }
        public virtual DbSet<FoodType> FoodsTypes { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Water> Water { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<FoodTypeFood> FoodTypeFoods { get; set; }
        public virtual DbSet<UserActivity> UserActivities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\;Database=FreshFitDB;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FoodSeed foodSeed = new FoodSeed();
            ActivitySeed activitySeed = new ActivitySeed();
            FoodTypeSeed foodTypeSeed = new FoodTypeSeed();
            FoodTypeFoodSeed foodTypeFoodSeed = new FoodTypeFoodSeed();
            MealSeed mealSeed = new MealSeed();

            modelBuilder.Entity<FoodTypeFood>().HasKey(nameof(FoodTypeFood.FoodID), nameof(FoodTypeFood.FoodTypeID));


            modelBuilder.Entity<User>(e =>
            {
                e.Property(e => e.ID).HasColumnName("UserID").UseIdentityColumn(1, 1);
                e.Property(e => e.FirstName).HasMaxLength(50);
                e.Property(e => e.LastName).HasMaxLength(50);
                e.HasIndex(e => e.Mail).IsUnique();
                e.Property(e => e.Mail).HasMaxLength(25).IsRequired();
                e.Property(e => e.Password).IsRequired();
                e.Property(e => e.FavoriteFood).HasMaxLength(50);
                e.Property(e => e.CreatedDate).IsRequired().HasColumnOrder(10).HasColumnType("date").HasDefaultValue(DateTime.Today);
            });
            modelBuilder.Entity<Water>(e =>
            {
                e.Property(e => e.ID).HasColumnName("WaterID").UseIdentityColumn(1, 1);
                e.Property(e => e.Quantity).HasMaxLength(4);
            });
            modelBuilder.Entity<FoodType>(e =>
            {
                e.Property(e => e.ID).HasColumnName("FoodTypeID").UseIdentityColumn(1, 1);
                e.Property(e => e.Name).HasMaxLength(50);
            });
            modelBuilder.Entity<Food>(e =>
            {
                e.Property(e => e.ID).HasColumnName("FoodID").UseIdentityColumn(1, 1);
                e.Property(e => e.Name).HasMaxLength(50).IsRequired();

            });
            modelBuilder.Entity<Activity>(e => {
                e.Property(e => e.ID).HasColumnName("ActivityID").UseIdentityColumn(1, 1);
                e.Property(e => e.Name).HasMaxLength(50);

            });

            foodSeed.AddFoodData(modelBuilder);
            activitySeed.AddActivityData(modelBuilder);
            foodTypeSeed.AddFoodTypeData(modelBuilder);
            foodTypeFoodSeed.AddFoodTypeFoodData(modelBuilder);
            mealSeed.AddMealData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

    }
}
