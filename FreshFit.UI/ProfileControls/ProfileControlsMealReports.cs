using FreshFit.BLL.Controller;
using FreshFit.DAL.Entity;
using FreshFit.Model.Enums;
using FreshFit.Model.Models;
using FreshFit.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Activity = FreshFit.Model.Models.Activity;

namespace FreshFit.UI.ProfileControls
{

    public partial class ProfileControlsMealReports : UserControl
    {
        FreshFitContext _db = new FreshFitContext();
        int indexDgw = -1;
        int indexMy = -1;

        FreshFitControllers controllers;
        double _bmi = 0;
        bool selectedButton = true;
        public ProfileControlsMealReports()
        {
            InitializeComponent();
            controllers = FreshFitControllers.Instance;
        }
        private void ıcnbtnFoodLıst_Click(object sender, EventArgs e)
        {
            EnableTrueFoodFunc();
            dgwList.DataSource = _db.Foods.Join(_db.FoodTypeFoods, x1 => x1.ID, x2 => x2.FoodID, (x1, x2) => new { Tablo1 = x1, Tablo2 = x2 }).
           Join(_db.FoodsTypes, x1x2 => x1x2.Tablo2.FoodTypeID, x3 => x3.ID, (x1x2, x3) =>
           new { YemekAdı = x1x2.Tablo1.Name, Kalori = x1x2.Tablo1.Calory, Karbonhidrat = x1x2.Tablo1.Carbohydrate, Yağ = x1x2.Tablo1.Fat, Protein = x1x2.Tablo1.Protein, YemekTürü = x3.Name, Resim = x1x2.Tablo1.FoodPictureByte }).ToList();
        }
        private void ıcnbtnActivityList_Click(object sender, EventArgs e)
        {
            selectedButton = false;
            dgwList.DataSource = null;
            EnableFalseFoodFunc();
            dgwList.DataSource = controllers.GetAllData<Activity>().Select(x => new { AktiviteAdi = x.Name, Kalori = x.BurnedCalory }).ToList();
        }
        private void ıcnbtnDelete_Click(object sender, EventArgs e)
        {
            if (indexMy >= 0)
            {
                if (selectedButton)
                {
                    string meal = dgwPersonelList.CurrentRow.Cells[1].Value.ToString();
                    string foodName = dgwPersonelList.CurrentRow.Cells[0].Value.ToString();
                    var targetObje = controllers.GetAllData<Food>().FirstOrDefault(x => x.Name == foodName);
                    var targetObje2 = controllers.GetAllData<Meal>().FirstOrDefault(x => x.Name == GetMeals(meal));
                    var removeObje = controllers.GetAllData<FoodMeal>().Where(x => x.FoodID == targetObje.ID || x.Date == DateTime.Today || x.MealID == targetObje2.ID).First();
                    controllers.RemoveDataByID<FoodMeal>(removeObje.ID);
                }
                else
                {
                    string activity = dgwPersonelList.CurrentRow.Cells[0].Value.ToString();
                    string calory = dgwPersonelList.CurrentRow.Cells[1].Value.ToString();
                    var targetObje = controllers.GetAllData<Activity>().FirstOrDefault(x => x.Name == activity);
                    var removeObje = controllers.GetAllData<UserActivity>().Where(x => x.ActivityID == targetObje.ID || x.Date == DateTime.Today || x.LoseCalory == (Convert.ToDouble(calory))).First();
                    controllers.RemoveDataByID<Activity>(removeObje.ID);
                }
            }
            else { MessageBox.Show("Listeden seçim yapılmadı"); }

        }
        private void ıcnbtnMyFood_Click(object sender, EventArgs e)
        {
            dgwPersonelList.DataSource = controllers.GetAllData<FoodMeal>().Where(x => x.Date == DateTime.Today && x.UserID == Login.user.ID).
                   Join(_db.Foods, x => x.FoodID, y => y.ID, (x, y) => new { FoodMeal = x, Food = y }).
                   Join(_db.Meals, xy => xy.FoodMeal.MealID, z => z.ID, (xy, z) => new { FFMeal = xy, Meal = z }).
                   Select(x => new { YemekAdi = x.FFMeal.Food.Name, ÖğünAdi = x.Meal.Name, Kalori = x.FFMeal.FoodMeal.GainCalory, Karbonhidrat = x.FFMeal.FoodMeal.GainCarbohydrate, Protein = x.FFMeal.FoodMeal.GainProtein, Yağ = x.FFMeal.FoodMeal.GainFat }).ToList();
        }

        private void ıcnbtnMyActivity_Click(object sender, EventArgs e)
        {
            dgwPersonelList.DataSource = controllers.GetAllData<UserActivity>().Where(x => x.Date == DateTime.Today).
                Join(_db.Users, x => x.UserID, y => y.ID, (x, y) => new { UserActivity = x, User = y }).
                Join(_db.Activities, xy => xy.UserActivity.ActivityID, z => z.ID, (xy, z) => new { UUActivity = xy, Activity = z }).
                Select(x => new { AktiviteAdi = x.Activity.Name, YakılanKolori = x.UUActivity.UserActivity.LoseCalory }).ToList();
        }

        private void EnableFalseFoodFunc()
        {
            cmbFoodType.Enabled = false;
            groupBox1.Enabled = false;
            nmrPortion.Enabled = false;
            nmrTime.Enabled = true;
        }
        private void EnableTrueFoodFunc()
        {
            cmbFoodType.Enabled = true;
            groupBox1.Enabled = true;
            nmrPortion.Enabled = true;
            nmrTime.Enabled = false;
        }
        private Meals SelectedMeal()
        {
            Meals returnValue = Meals.Aperitif;
            string selectedRadio = string.Empty;
            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked == true)
                {
                    selectedRadio = item.Text;
                }
            }
            if (selectedRadio == "Kahvaltı")
            {
                returnValue = Meals.Breakfast;
            }
            else if (selectedRadio == "Akşam Yemeği")
            {
                returnValue = Meals.Dinner;
            }
            else if (selectedRadio == "Öğle Yemeği")
            {
                returnValue = Meals.Lunch;
            }
            else
            {
                returnValue = Meals.Aperitif;
            }
            return returnValue;
        }

        private double TotalCaloriesIntake()
        {
            var addedFoodCalory = controllers.GetAllData<FoodMeal>().Where(x => x.Date == DateTime.Today).Sum(x => x.GainCalory);
            var addedActivityCalory = controllers.GetAllData<UserActivity>().Where(x => x.Date == DateTime.Today).Sum(x => x.LoseCalory);
            return ((double)(addedFoodCalory) - (double)(addedActivityCalory));
        }
        private double RemainingCalories()
        {
            return _bmi - (double)TotalCaloriesIntake();

        }

        private void cmbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yemekKategorisi = cmbFoodType.Items[cmbFoodType.SelectedIndex].ToString();

            dgwList.DataSource = _db.Foods.Join(_db.FoodTypeFoods, x1 => x1.ID, x2 => x2.FoodID, (x1, x2) => new { Tablo1 = x1, Tablo2 = x2 }).
              Join(_db.FoodsTypes, x1x2 => x1x2.Tablo2.FoodTypeID, x3 => x3.ID, (x1x2, x3) =>
              new { YemekAdı = x1x2.Tablo1.Name, Kalori = x1x2.Tablo1.Calory, Karbonhidrat = x1x2.Tablo1.Carbohydrate, Yağ = x1x2.Tablo1.Fat, Protein = x1x2.Tablo1.Protein, YemekTürü = x3.Name, Resim = x1x2.Tablo1.FoodPictureByte }).Where(x => x.YemekTürü == yemekKategorisi).ToList();
        }

        private Meals GetMeals(string name)
        {
            Meals returnValue = Meals.Aperitif;
            if (name == "Breakfast")
            {
                returnValue = Meals.Breakfast;
            }
            else if (name == "Dinner")
            {
                returnValue = Meals.Dinner;
            }
            else if (name == "Lunch")
            {
                returnValue = Meals.Lunch;
            }
            else
            {
                returnValue = Meals.Aperitif;
            }
            return returnValue;
        }

        private void ıcnbtnAdd_Click(object sender, EventArgs e)
        {
            if (indexDgw >= 0)
            {
                if (selectedButton == true)
                {
                    var selectedFoodObject = controllers.GetAllData<Food>().First(x => x.Name == dgwList.CurrentRow.Cells[0].Value.ToString());
                    var selectedMeal = controllers.GetAllData<Meal>().First(x => x.Name == SelectedMeal());
                    controllers.AddData<FoodMeal>(new FoodMeal { Date = DateTime.Today, FoodID = selectedFoodObject.ID, MealID = selectedMeal.ID, GainCalory = ((double)nmrPortion.Value * (selectedFoodObject.Calory)) - ((double)nmrWaterQuantity.Value * ((double)nmrPortion.Value * (selectedFoodObject.Calory)) * 0.02), GainCarbohydrate = (double)nmrPortion.Value * (selectedFoodObject.Carbohydrate), GainFat = (double)nmrPortion.Value * (selectedFoodObject.Fat), GainProtein = (double)nmrPortion.Value * (selectedFoodObject.Protein), UserID = Login.user.ID });
                }
                else
                {
                    var selectedActivity = controllers.GetAllData<Activity>().First(x => x.Name == dgwList.CurrentRow.Cells[0].Value.ToString());
                    controllers.AddData<UserActivity>(new UserActivity { Date = DateTime.Today, ActivityID = selectedActivity.ID, UserID = Login.user.ID, LoseCalory = (double)nmrTime.Value * (selectedActivity.BurnedCalory) });
                }
                controllers.AddData<Water>(new Water { Date = DateTime.Today, Quantity = (int)(nmrWaterQuantity.Value), UserID = Login.user.ID });
                lblTakenCalory.Text = TotalCaloriesIntake().ToString();
                lblRemainingCalories.Text = RemainingCalories().ToString();
            }
            else { MessageBox.Show("Listeden seçim yapılmadı"); }
        }


        private void ProfileControlsMealReports_Load(object sender, EventArgs e)
        {
            ıcnbtnFoodLıst_Click(sender, e);
            if (Login.user.Genders == Model.Enums.Gender.Male)
            {
                _bmi = 66.5 + ((13.75 * Login.user.Weight) + (5 * 100 * Login.user.Height)) - (6.77 * ((DateTime.Now.Year) - (Login.user.BirthDate.Year)));
            }
            else if (Login.user.Genders == Model.Enums.Gender.Female)
            {
                _bmi = 655.5 + ((9.56 * Login.user.Weight) + (1.85 * 100 * Login.user.Height)) - (4.67 * ((DateTime.Now.Year) - (Login.user.BirthDate.Year)));
            }
            lblRecommendedDailyCalory.Text = _bmi.ToString();
            foreach (var item in controllers.GetAllData<FoodType>())
            {
                cmbFoodType.Items.Add(item.Name);
            }
            foreach (var item in controllers.GetAllData<FoodType>())
            {
                cmbFoodType.Items.Add(item.Name);
            }
        }

        private void dgwList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexDgw = e.RowIndex;
        }

        private void dgwPersonelList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexMy = e.RowIndex;
        }
    }
}
