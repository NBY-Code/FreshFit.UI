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
    public partial class Login : Form
    {
        FreshFitControllers controller;
        public static User user;
        public Login()
        {
            InitializeComponent();
            controller = FreshFitControllers.Instance;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text.EndsWith(".com"))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtMail.Text);
                    if (addr.Address == txtMail.Text)
                    {
                        pbMail.Visible = false;
                    }

                }
                catch (Exception)
                {
                    pbMail.Visible = true;

                }
            }
            else
            {
                pbMail.Visible = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 8 && UserControlFunction.CheckForUpperCharacter(txtPassword.Text) && UserControlFunction.CheckForLowerCharacter(txtPassword.Text) && UserControlFunction.CheckForSpecialCharacter(txtPassword.Text))
            {
                pbPassword.Visible = false;
            }
            else
            {
                pbPassword.Visible = true;
            }
        }

        private void btnIconStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıcnbtnPasswordShow_Click(object sender, EventArgs e)
        {
            ıcnbtnPasswordHide.Visible = true;
            txtPassword.PasswordChar = '\0';
            ıcnbtnPasswordShow.Visible = false;
        }

        private void ıcnbtnPasswordHide_Click(object sender, EventArgs e)
        {
            ıcnbtnPasswordShow.Visible = true;
            txtPassword.PasswordChar = '*';
            ıcnbtnPasswordHide.Visible = false;
        }

        private void ıcnbtnLogin_Click(object sender, EventArgs e)
        {
            if (pbMail.Visible != true && pbPassword.Visible != true)
            {
                //var user = controller.GetAllData<User>().FirstOrDefault(x => x.Mail == txtKullaniciAd.Text);
                user = controller.GetAllData<User>().FirstOrDefault(x => x.Mail == txtMail.Text && x.Password == UserControlFunction.HidingPasswordInDB(txtPassword.Text));
                if (user != null)
                {
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Eşleşen kayıt bulunamadı");
                }
            }
            else
            {
                txtGeneralDescription.Visible = true;
            }
        }

        private void ıbtnBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }

        private void ıcnbtnForgetPassword_Click(object sender, EventArgs e)
        {
            RememberUser rememberUser = new RememberUser();
            rememberUser.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
