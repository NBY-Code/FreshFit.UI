using FreshFit.BLL.Controller;
using FreshFit.BLL.Function;
using FreshFit.DAL.Entity;
using FreshFit.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FreshFit.UI.ProfileControls
{
    public partial class ProfileControlsFood : UserControl
    {
        FreshFitControllers controllers;
        FreshFitContext _cc;
        int index = -1;
        public ProfileControlsFood()
        {
            InitializeComponent();
            controllers = FreshFitControllers.Instance;
            _cc = new FreshFitContext();
        }

        private void ProfileControlsFood_Load(object sender, EventArgs e)
        {
            foreach (var item in controllers.GetAllData<FoodType>())
            {
                cmbForAdd.Items.Add(item.Name);
                cmbForUpdate.Items.Add(item.Name);
            }
            cmbForAdd.SelectedIndex = 0;
            cmbForUpdate.SelectedIndex = 0;
        }

        private void txtFoundFood_TextChanged(object sender, EventArgs e)
        {
            dgwFood.DataSource = null;

            var searchingValue = (_cc.Foods.Join(_cc.FoodTypeFoods, x1 => x1.ID, x2 => x2.FoodID, (x1, x2) => new { Tablo1 = x1, Tablo2 = x2 }).
                Join(_cc.FoodsTypes, x1x2 => x1x2.Tablo2.FoodTypeID, x3 => x3.ID, (x1x2, x3) =>
                new { YemekAdı = x1x2.Tablo1.Name, Kalori = x1x2.Tablo1.Calory, Karbonhidrat = x1x2.Tablo1.Carbohydrate, Yağ = x1x2.Tablo1.Fat, Protein = x1x2.Tablo1.Protein, YemekTürü = x3.Name, Resim = x1x2.Tablo1.FoodPictureByte })).Where(x => x.YemekAdı.Contains(txtFoundFood.Text));

            dgwFood.DataSource = searchingValue.ToList();
        }
        private void dgwFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFoodNameUpdate.Text = dgwFood.CurrentRow.Cells[0].Value.ToString();
            nmrForCaloryUpdating.Value = Convert.ToDecimal(dgwFood.CurrentRow.Cells[1].Value);
            nmrForCarbonhydrateUpdating.Value = Convert.ToDecimal(dgwFood.CurrentRow.Cells[2].Value);
            nmrForFatUpdating.Value = Convert.ToDecimal(dgwFood.CurrentRow.Cells[3].Value);
            nmrForProteinUpdating.Value = Convert.ToDecimal(dgwFood.CurrentRow.Cells[4].Value);
        }

        private void ıcnbtnPictureImage_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    byte[] imageByte = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageByte = ms.ToArray();
                    }
                    var getTargetFood = controllers.GetAllData<Food>().First(x => x.Name == dgwFood.CurrentRow.Cells[0].Value.ToString());
                    getTargetFood.FoodPictureByte = imageByte;
                    controllers.SaveAllChanges();
                    MessageBox.Show("Resim ekleme işlemi başarılı");
                    ListingFood();
                }
                else
                {
                    MessageBox.Show("Resim ekleme işlemi başarısız");
                }
            }
            else { MessageBox.Show("Lütfen listeden bir yemek seçimi yapınız."); }

        }

        private void ıcnibtnListed_Click(object sender, EventArgs e)
        {
            ListingFood();

        }

        private void ListingFood()
        {
            dgwFood.DataSource = _cc.Foods.Join(_cc.FoodTypeFoods, x1 => x1.ID, x2 => x2.FoodID, (x1, x2) => new { Tablo1 = x1, Tablo2 = x2 }).
                Join(_cc.FoodsTypes, x1x2 => x1x2.Tablo2.FoodTypeID, x3 => x3.ID, (x1x2, x3) =>
                new { YemekAdı = x1x2.Tablo1.Name, Kalori = x1x2.Tablo1.Calory, Karbonhidrat = x1x2.Tablo1.Carbohydrate, Yağ = x1x2.Tablo1.Fat, Protein = x1x2.Tablo1.Protein, YemekTürü = x3.Name, Resim = x1x2.Tablo1.FoodPictureByte }).ToList();

        }

        private void ıcnbtnAdd_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                var checkingBeforeAdding = controllers.GetAllData<Food>().Where(x => x.Name == UserControlFunction.FixingName(txtFoodNameAdd.Text)).ToList();
                if (checkingBeforeAdding.Count == 0) // aynı yemek adı sistemde varmı diye kontrol yapılıyor aksi halde database'de aynı yemek birden fazla görülür ve update kısmında hata oluşur.
                {
                    if (!(UserControlFunction.CheckForIsEmpty(txtFoodNameAdd.Text) && UserControlFunction.CheckForSpecialCharacter(txtFoodNameAdd.Text) && UserControlFunction.CheckForIsDigit(txtFoodNameAdd.Text)))
                    {
                        Food targetFood = new Food { Name = UserControlFunction.FixingName(txtFoodNameAdd.Text), Calory = (double)(nmrForCaloryAdding.Value), Carbohydrate = (double)(nmrForCarbonhydrateAdding.Value), Fat = (double)(nmrForFatAdding.Value), Protein = (double)(nmrForProteinAdding.Value) };
                        controllers.AddData<Food>(targetFood);

                        FoodType targetType = controllers.GetAllData<FoodType>().FirstOrDefault(x => x.Name == cmbForAdd.Items[cmbForAdd.SelectedIndex].ToString());

                        controllers.AddData<FoodTypeFood>(new FoodTypeFood { FoodID = targetFood.ID, FoodTypeID = targetType.ID });
                        MessageBox.Show("Ekleme İşlemi Başarılı");
                        ListingFood();
                    }
                    else
                    { MessageBox.Show("Ekleme İşlemi Başarısız"); }
                }
                else { MessageBox.Show("Bu yemek adı zaten mevcut!."); }
            }
            else { MessageBox.Show("Lütfen listeden bir yemek seçimi yapınız."); }

        }

        private void ıcnbtnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string fromDgw = dgwFood.CurrentRow.Cells[0].Value.ToString();
                var targetObje = controllers.GetAllData<Food>().FirstOrDefault(x => x.Name == fromDgw);
                controllers.RemoveDataByID<Food>(targetObje.ID);
                MessageBox.Show("Silme işlemi başarılı");
                ListingFood();
            }
            else { MessageBox.Show("Lütfen listeden bir yemek seçimi yapınız."); }

        }


        private void ıcnbtnUpdate_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                if (!(UserControlFunction.CheckForIsEmpty(txtFoodNameUpdate.Text) && UserControlFunction.CheckForSpecialCharacter(txtFoodNameUpdate.Text) && UserControlFunction.CheckForIsDigit(txtFoodNameUpdate.Text)))
                {
                    string fromDgw = dgwFood.CurrentRow.Cells[0].Value.ToString();
                    var targetObjeForFood = controllers.GetAllData<Food>().FirstOrDefault(x => x.Name == fromDgw);

                    targetObjeForFood.Name = txtFoodNameUpdate.Text;
                    targetObjeForFood.Calory = (double)nmrForCaloryUpdating.Value;
                    targetObjeForFood.Protein = (double)nmrForProteinUpdating.Value;
                    targetObjeForFood.Fat = (double)nmrForFatUpdating.Value;
                    targetObjeForFood.Carbohydrate = (double)nmrForCarbonhydrateUpdating.Value;

                    var findingFoodType = controllers.GetAllData<FoodType>().First(x => x.Name == cmbForUpdate.Items[cmbForUpdate.SelectedIndex].ToString());

                    var findingFoodTypeFood = controllers.GetAllData<FoodTypeFood>().First(x => x.FoodID == targetObjeForFood.ID);
                    controllers.RemoveData<FoodTypeFood>(findingFoodTypeFood);

                    controllers.AddData<FoodTypeFood>(new FoodTypeFood { FoodID = targetObjeForFood.ID, FoodTypeID = findingFoodType.ID });
                    controllers.SaveAllChanges();
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    ListingFood();
                }
                else { MessageBox.Show("Güncelleme İşlemi Başarısız"); }
            }
            else { MessageBox.Show("Lütfen listeden bir yemek seçimi yapınız."); }
        }

        private void dgwFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            Food food = controllers.GetAllData<Food>().FirstOrDefault(x => x.Name == dgwFood.CurrentRow.Cells[0].Value.ToString());
            pictureBox1.Image = Image.FromFile(food.StringPicture.ToString());
            pictureBox1.Show();
        }
    }
}
