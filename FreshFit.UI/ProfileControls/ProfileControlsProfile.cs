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
using FreshFit.Model.Models;
using FreshFit.UI.Forms;

namespace FreshFit.UI.ProfileControls
{
    public partial class ProfileControlsProfile : UserControl
    {
        FreshFitControllers controller;
        byte[] imageByte = null;
        public ProfileControlsProfile()
        {
            InitializeComponent();
            controller = FreshFitControllers.Instance;

        }

        private void ProfileControlsProfile_Load(object sender, EventArgs e)
        {
            UserInformationShow();
        }
        private void UserInformationShow()
        {
            txtUserFirstName.Text = Login.user.FirstName;
            txtUserLastName.Text = Login.user.LastName;
            txtHeight.Text = Login.user.Height.ToString();
            txtWeight.Text = Login.user.Weight.ToString();
            if (Login.user.UserPictureByte != null)
            {
                using (var ms = new MemoryStream(Login.user.UserPictureByte))
                {
                    pbUserPicture.Image = new Bitmap(ms);
                    pbUserPicture.Show();
                }
            }
            txtPassword.Text = Login.user.Password;
            txtMail.Text = Login.user.Mail;
        }

        private void ıcnbtnlblWeightUpdate_Click(object sender, EventArgs e)
        {
            lblWeightUpdate.Visible = true;
            txtWeightUpdate.Visible = true;
        }

        private void ıcnbtnlblWeightUpdate_MouseHover(object sender, EventArgs e)
        {
            lblWeightUpdate.Visible = true;
        }

        private void lblWeightUpdate_Click(object sender, EventArgs e)
        {
            Login.user.Weight = Convert.ToDouble(txtWeightUpdate.Text);
            controller.UpdateData<User>(Login.user);
            UserInformationShow();
            lblWeightUpdate.Visible = false;
            txtWeightUpdate.Visible = false;
        }

        private void ıcnbtnPictureImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByte = ms.ToArray();
                    Login.user.UserPictureByte = imageByte;
                    controller.UpdateData<User>(Login.user);

                }
                pbUserPicture.Image = selectedImage;
                pbUserPicture.Show();
            }
        }

        private void TextBoxClear()
        {
            txtPastPassword.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtNewPasswordAgain.Text = string.Empty;
        }
        private void TextBoxNewPaswordClear()
        {
            txtPassword.Text = string.Empty;
            txtNewPasswordAgain.Text = string.Empty;
        }
        private void PasswordTextVisableFalse()
        {
            lblPasswordUpdate.Visible = false;
            txtNewPassword.Visible = false;
            txtNewPasswordAgain.Visible = false;
            txtPastPassword.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

        }
        private void PasswordTextVisableTrue()
        {
            lblPasswordUpdate.Visible = true;
            txtNewPassword.Visible = true;
            txtNewPasswordAgain.Visible = true;
            txtPastPassword.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void lblPasswordUpdate_Click(object sender, EventArgs e)
        {
            if (txtPastPassword.Text == Login.user.Password)
            {
                if (txtPassword.Text == txtNewPasswordAgain.Text)
                {
                    Login.user.Password = txtNewPasswordAgain.Text;
                    controller.UpdateData<User>(Login.user);
                    PasswordTextVisableFalse();
                    MessageBox.Show("Şifre başarıyla güncellendi");

                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil şifreyi tekrar belirleyiniz.");
                    TextBoxNewPaswordClear();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı şifresi yanlış.");
                TextBoxClear();
            }
        }

        private void ıcnbtnPasswordUpdate_Click(object sender, EventArgs e)
        {
            PasswordTextVisableTrue();
        }

        private void ıcnbtnPasswordUpdate_MouseHover(object sender, EventArgs e)
        {
            lblPasswordUpdate.Visible = true;
        }

    }
}
