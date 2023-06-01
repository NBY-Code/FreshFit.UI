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
using FreshFit.BLL.Function;
using FreshFit.Model.Models;

namespace FreshFit.UI.Forms
{
    public partial class RememberUser : Form
    {
        FreshFitControllers controller;
        User _user;
        public RememberUser()
        {
            InitializeComponent();
            controller = FreshFitControllers.Instance;
        }

        private void ıcnbtnPasswordUpdate_Click(object sender, EventArgs e)
        {
            _user.Password = txtPassword.Text;
            controller.UpdateData<User>(_user);
            MessageBox.Show("Şifreniz Güncellenmiştir.");
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void PasswordUpdateControlShow()
        {
            lblPassword.Visible = true;
            lblPasswordAgain.Visible = true;
            txtPassword.Visible = true;
            txtPasswordAgain.Visible = true;
        }

        private void ıcnUserFind_Click(object sender, EventArgs e)
        {
            _user = controller.GetAllData<User>().Where(x => x.Mail == txtMail.Text).FirstOrDefault();
            if (_user != null)
            {
                if (_user.FirstName == txtFirstName.Text && _user.LastName == txtLastName.Text && _user.FavoriteFood == txtFavoriteFood.Text && _user.BirthDate.DayOfYear == (dtpBirthDate.Value).DayOfYear)
                {
                    PasswordUpdateControlShow();
                }
                else { MessageBox.Show("Kullanıcı Bilgileri Hatalı."); }
            }
            else { MessageBox.Show("Kayıtlı kullanıcı bulunamadı."); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ıbtnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = UserControlFunction.ToUpperLastName(txtLastName.Text);
        }
    }
}
