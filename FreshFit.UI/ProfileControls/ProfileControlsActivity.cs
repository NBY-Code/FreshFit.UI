using FreshFit.BLL.Controller;
using FreshFit.BLL.Function;
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
using System.Windows.Xps;

namespace FreshFit.UI.ProfileControls
{
    
    public partial class ProfileControlsActivity : UserControl
    {
        FreshFitControllers controllers;
        int index = -1;
        public ProfileControlsActivity()
        {
            InitializeComponent();
            controllers = FreshFitControllers.Instance;
        }
        private void ıcnbtnAdd_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                if (!(UserControlFunction.CheckForIsEmpty(txtName.Text) && UserControlFunction.CheckForSpecialCharacter(txtName.Text) && UserControlFunction.CheckForIsDigit(txtName.Text)))
                {
                    controllers.AddData<Activity>(new Activity { Name = UserControlFunction.FixingName(txtName.Text), BurnedCalory = Convert.ToInt32(nmrForCalory.Value) });
                    MessageBox.Show("Başarıyla Ekleme İşlemi Tamamlanmıştır");
                    ıcnbtnActivityList_Click(sender, e);
                    TextClear(txtName, nmrForCalory);
                }
                else{ MessageBox.Show("Ekleme Başarısız");}
            }
            else { MessageBox.Show("Aktivite seçimi yapınız.");}
            
        }
        private void ıcnbtnActivityList_Click(object sender, EventArgs e)
        {
            dgwActivity.DataSource = controllers.GetAllData<Activity>().Select(x => new { Isim = x.Name, KaloriMiktar = x.BurnedCalory }).ToList();
        }
        private void TextClear(TextBox text, NumericUpDown value)
        {
            text.Text = string.Empty;
            value.Value = 0;
        }
        private void ıcnbtnUpdate_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                if (!(UserControlFunction.CheckForIsEmpty(txtUpdateName.Text) && UserControlFunction.CheckForSpecialCharacter(txtUpdateName.Text) && UserControlFunction.CheckForIsDigit(txtUpdateName.Text)))
                {
                    string fromDgw = dgwActivity.CurrentRow.Cells[0].Value.ToString();
                    var targetObje = controllers.GetAllData<Activity>().FirstOrDefault(x => x.Name == fromDgw);
                    targetObje.Name = UserControlFunction.FixingName(txtUpdateName.Text);
                    targetObje.BurnedCalory = Convert.ToDouble(nmrUpdateForCalory.Value);
                    controllers.SaveAllChanges();
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    ıcnbtnActivityList_Click(sender, e);
                    TextClear(txtUpdateName, nmrUpdateForCalory);
                }
                else { MessageBox.Show("Güncelleme Başarısız"); }
            }
            else { MessageBox.Show("Aktivite seçimi yapınız."); }
        }

        private void ıcnbtnDelete_Click(object sender, EventArgs e)
        {
            if (index>=0 )
            {
                string fromDgw = dgwActivity.CurrentRow.Cells[0].Value.ToString();
                var targetObje = controllers.GetAllData<Activity>().FirstOrDefault(x => x.Name == fromDgw);
                controllers.RemoveDataByID<Activity>(targetObje.ID);
                MessageBox.Show("Silme işlemi başarılı");
                ıcnbtnActivityList_Click(sender, e);
            }
            else { MessageBox.Show("Aktivite seçimi yapınız."); }
        }


        private void txtActivityFound_TextChanged(object sender, EventArgs e)
        {
            dgwActivity.DataSource = null;
            var searchingValue = controllers.GetAllData<Activity>().Where(x => x.Name.Contains(txtActivityFound.Text)).Select(x => new { Isim = x.Name, KaloriMiktar = x.BurnedCalory });
            dgwActivity.DataSource = searchingValue.ToList();
        }
        private void dgwActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateName.Text = dgwActivity.CurrentRow.Cells[0].Value.ToString();
            nmrUpdateForCalory.Value = Convert.ToDecimal(dgwActivity.CurrentRow.Cells[1].Value);
        }

        private void dgwActivity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
