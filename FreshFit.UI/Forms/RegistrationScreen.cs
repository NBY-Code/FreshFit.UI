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
using FreshFit.DAL.Entity;
using FreshFit.Model.Enums;
using FreshFit.Model.Models;

namespace FreshFit.UI.Forms
{
    public partial class RegistrationScreen : Form
    {
        FreshFitControllers controller;
        byte[] imageByte = null;
        double bmıOran;
        public RegistrationScreen()
        {
            InitializeComponent();
            controller = FreshFitControllers.Instance;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if ((dtpBirthDate.Value).Year > 2015)
            {
                pbBirthDate.Visible = true;
            }
            else
            {
                pbBirthDate.Visible = false;
            }
        }

        private Gender SelectedGender()
        {
            Gender returnValue = Gender.Female;
            if (rdioMale.Checked == true)
            {
                returnValue = Gender.Male;
            }
            return returnValue;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ıcnbtnPasswordHide_Click(object sender, EventArgs e)
        {
            ıcnbtnPasswordShow.Visible = true;
            txtPassword.PasswordChar = '*';
            txtPasswordAgain.PasswordChar = '*';
            ıcnbtnPasswordHide.Visible = false;
        }

        private void ıcnbtnPasswordShow_Click(object sender, EventArgs e)
        {
            ıcnbtnPasswordHide.Visible = true;
            txtPassword.PasswordChar = '\0';
            txtPasswordAgain.PasswordChar = '\0';
            ıcnbtnPasswordShow.Visible = false;
        }

        private void txtPasswordAgain_Leave(object sender, EventArgs e)
        {
            if (txtPasswordAgain.Text == txtPassword.Text && !UserControlFunction.CheckForIsEmpty(txtPassword.Text))
            {
                pbPasswordAgain.Visible = false;
            }
            else
            {
                pbPasswordAgain.Visible = true;
            }
        }

        private void ıcnbtnRegister_Click(object sender, EventArgs e)
        {
            if (pbFirstName.Visible != true && pbMail.Visible != true && pbPassword.Visible != true && pbPasswordAgain.Visible != true && pbBirthDate.Visible != true && pbFavoriteFood.Visible != true)
            {
                var user = new User() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Mail = txtMail.Text, Height = Convert.ToDouble(nmrForHeight.Value), Weight = Convert.ToDouble(nmrForWeight.Value), Password = UserControlFunction.HidingPasswordInDB(txtPassword.Text), FavoriteFood = txtFavoriteFood.Text, BirthDate = dtpBirthDate.Value, Genders = SelectedGender(), UserPictureByte = imageByte };
                controller.AddData(user);
                MessageBox.Show("Kayıt başarılı");
            }
            else { MessageBox.Show("Lütfen eksik bilgileri doldurunuz."); }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (UserControlFunction.CheckForIsEmpty(txtFirstName.Text) || UserControlFunction.CheckForIsDigit(txtFirstName.Text) || UserControlFunction.CheckForSpecialCharacter(txtFirstName.Text))
            {
                pbFirstName.Visible = true;
            }
            else
            {
                txtFirstName.Text = UserControlFunction.TrimProcess(txtFirstName.Text);
                txtFirstName.Text = UserControlFunction.FixingName(txtFirstName.Text);
                pbFirstName.Visible = false;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (UserControlFunction.CheckForIsDigit(txtLastName.Text) || UserControlFunction.CheckForSpecialCharacter(txtLastName.Text))
            {
                lblSoyAd.Text = "(Soyad sayı veya özel karakter içeremez)";
            }
            else
            {
                txtLastName.Text = UserControlFunction.TrimProcess(txtLastName.Text);
                txtLastName.Text = UserControlFunction.RemovingWhitespace(txtLastName.Text);
                txtLastName.Text = UserControlFunction.ToUpperLastName(txtLastName.Text);
            }
        }

        private void ıcnbtnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByte = ms.ToArray();
                }
                pbUserPicture.Image = selectedImage;
                pbUserPicture.Show();
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPasswordExplanation.Visible = false;
            if (txtPassword.Text.Length >= 8 && UserControlFunction.CheckForUpperCharacter(txtPassword.Text) && UserControlFunction.CheckForLowerCharacter(txtPassword.Text) && UserControlFunction.CheckForSpecialCharacter(txtPassword.Text))
            {
                pbPassword.Visible = false;
            }
            else
            {
                pbPassword.Visible = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPasswordExplanation.Visible = true;
        }

        private void txtFavoriteFood_TextChanged(object sender, EventArgs e)
        {
            if (txtFavoriteFood.Text.Length > 1)
            {
                pbFavoriteFood.Visible = false;
            }
            else
            {
                pbFavoriteFood.Visible = true;
            }
        }
    }
}
