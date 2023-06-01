using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreshFit.BLL.Controller;
using FreshFit.DAL.Entity;
using FreshFit.Model.Enums;
using FreshFit.Model.Models;
using FreshFit.UI.Forms;

namespace FreshFit.UI.ProfileControls
{

    public partial class ProfileControlsEndOfDayReports : UserControl
    {
        FreshFitContext _db = new FreshFitContext();
        FreshFitControllers controllers;

        public ProfileControlsEndOfDayReports()
        {
            InitializeComponent();
            controllers = FreshFitControllers.Instance;
        }

        private void ProfileControlsEndOfDayReports_Load(object sender, EventArgs e)
        {
            dtpStartTime.Value = Login.user.CreatedDate;
            dtpFinishTime.Value = DateTime.Now;
        }
        private void ıcnbtnActivityHistory_Click(object sender, EventArgs e)
        {
            var ActivityHistory = controllers.GetAllData<User>().Join(_db.UserActivities, x1 => x1.ID, x2 => x2.UserID, (x1, x2) => new { User = x1, UserActivities = x2 }).Join(_db.Activities, x1x2 => x1x2.UserActivities.ActivityID, x3 => x3.ID, (x1x2, x3) => new { User = x1x2.User, UserActivities = x1x2.UserActivities, Activitiy = x3 }).Where(x => x.User.ID == Login.user.ID && (x.UserActivities.Date >= dtpStartTime.Value && x.UserActivities.Date <= dtpFinishTime.Value)).Select(x => new { AktiviteAdi = x.Activitiy.Name, KaybedilenKalori = x.UserActivities.LoseCalory });
            dgwEndOfDay.DataSource = ActivityHistory.ToList();

            var totalLoseCal = controllers.GetAllData<UserActivity>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.LoseCalory);
            lblBurningCalory.Text = totalLoseCal.ToString();

            var gainTotalCalory = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.GainCalory);

            lblTotalCalory.Text = (gainTotalCalory - totalLoseCal).ToString();
        }
        private void ıcnbtnDietaryHistory_Click(object sender, EventArgs e)
        {
            var waterHistory = controllers.GetAllData<Water>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.Quantity);
            lblWater.Text = waterHistory.ToString();

            var totalGainedCalory = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.GainCalory);
            lblGainCalory.Text = totalGainedCalory.ToString();
            var totalGainedCarbonhydrate = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.GainCarbohydrate);
            lblCarbonhydrat.Text = totalGainedCarbonhydrate.ToString();
            var totalGainedFat = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.GainFat);
            lblFat.Text = totalGainedFat.ToString();
            var totalGainedProtein = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.GainProtein);
            lblProtein.Text = totalGainedProtein.ToString();

            var gainedCaloryAtBreakFast = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Join(_db.Meals, x => x.MealID, y => y.ID, (x, y) => new { FoodMeal = x, Meals = y }).Where(x => x.Meals.Name == Meals.Breakfast).Sum(x => x.FoodMeal.GainCalory);
            lblKahvaltiCal.Text = gainedCaloryAtBreakFast.ToString();

            var gainedCaloryAtLunch = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Join(_db.Meals, x => x.MealID, y => y.ID, (x, y) => new { FoodMeal = x, Meals = y }).Where(x => x.Meals.Name == Meals.Lunch).Sum(x => x.FoodMeal.GainCalory);
            lblOgledeCal.Text = gainedCaloryAtLunch.ToString();

            var gainedCaloryAtDinner = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Join(_db.Meals, x => x.MealID, y => y.ID, (x, y) => new { FoodMeal = x, Meals = y }).Where(x => x.Meals.Name == Meals.Dinner).Sum(x => x.FoodMeal.GainCalory);
            lblAksamCal.Text = gainedCaloryAtDinner.ToString();

            var gainedCaloryAtAperatif = controllers.GetAllData<FoodMeal>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Join(_db.Meals, x => x.MealID, y => y.ID, (x, y) => new { FoodMeal = x, Meals = y }).Where(x => x.Meals.Name == Meals.Aperitif).Sum(x => x.FoodMeal.GainCalory);
            lblAperatifCal.Text = gainedCaloryAtAperatif.ToString();

            var totalLoseCal = controllers.GetAllData<UserActivity>().Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Sum(x => x.LoseCalory);
            lblBurningCalory.Text = totalLoseCal.ToString();

            lblTotalCalory.Text = (totalGainedCalory - totalLoseCal).ToString();

            var consumedFood = _db.FoodMeals.Where(x => x.UserID == Login.user.ID && (x.Date >= dtpStartTime.Value && x.Date <= dtpFinishTime.Value)).Join(_db.Foods, x1 => x1.FoodID, x2 => x2.ID, (x1, x2) => new { FoodMeals = x1, Foods = x2 }).Join(_db.FoodTypeFoods, x1x2 => x1x2.Foods.ID, x3 => x3.FoodID, (x1x2, x3) => new { FoodMeal = x1x2.FoodMeals, Food = x1x2.Foods, FoodTypeFood = x3 }).Join(_db.FoodsTypes, x1x2x3 => x1x2x3.FoodTypeFood.FoodTypeID, x4 => x4.ID, (x1x2x3, x4) => new { YemekAdi = x1x2x3.Food.Name, Kalori = x1x2x3.FoodMeal.GainCalory, Karbonhidrat = x1x2x3.FoodMeal.GainCarbohydrate, Protein = x1x2x3.FoodMeal.GainProtein, Yag = x1x2x3.FoodMeal.GainFat, Resim = x1x2x3.Food.FoodPictureByte, YemekTuru = x4.Name });
            dgwEndOfDay.DataSource = consumedFood.ToList();
        }

    }
}
