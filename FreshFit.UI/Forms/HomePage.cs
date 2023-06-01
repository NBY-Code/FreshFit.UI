using FontAwesome.Sharp;
using FreshFit.BLL.Controller;
using FreshFit.UI.ProfileControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;

namespace FreshFit.UI.Forms
{
    public partial class HomePage : Form
    {
        FreshFitControllers controllers;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        ProfileControlsFood _forFoodUser;
        ProfileControlsActivity _forActivityUser;
        ProfileControlsEndOfDayReports _forEndOfReports;
        ProfileControlsProfile _forProfile;
        ProfileControlsMealReports _forMealReports;
        ProfileControlsWeightCalculator _forWeightCalculator;
        ProfileControlsBMICalculator _forBMICalculator;

        public HomePage()
        {
            InitializeComponent();
            UserControlsInstance();
            ButtonSettings();
            InsertAllUsersToPanel();
            UserInformationShow();
        }

        private void UserControlsInstance()
        {
            _forFoodUser = new ProfileControlsFood();
            _forActivityUser = new ProfileControlsActivity();
            _forEndOfReports = new ProfileControlsEndOfDayReports();
            _forProfile = new ProfileControlsProfile();
            _forWeightCalculator = new ProfileControlsWeightCalculator();
            _forBMICalculator = new ProfileControlsBMICalculator();
            _forMealReports = new ProfileControlsMealReports();
        }

        private void InsertAllUsersToPanel()
        {
            _forFoodUser.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forFoodUser);
            _forActivityUser.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forActivityUser);
            _forWeightCalculator.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forWeightCalculator);
            _forEndOfReports.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forEndOfReports);
            _forProfile.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forProfile);
            _forBMICalculator.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forBMICalculator);
            _forMealReports.Dock = DockStyle.Fill;
            pnlForGeneral.Controls.Add(_forMealReports);
        }

        private void UserInformationShow()
        {
            lblUserName.Text = Login.user.FirstName + " " + Login.user.LastName;
            lblUserHeight.Text = Login.user.Height.ToString("0.00");
            lblUserWeight.Text = Login.user.Weight.ToString("0.00");
            if (Login.user.UserPictureByte != null)
            {
                using (var ms = new MemoryStream(Login.user.UserPictureByte))
                {
                    ıcnpbUserPicture.Image = new Bitmap(ms);
                    ıcnpbUserPicture.Show();
                }
            }
        }

        private void ButtonSettings()
        {
            controllers = FreshFitControllers.Instance;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 81);
            panelMenu.Controls.Add(leftBorderBtn);
            panelMenu.BackColor = Color.FromArgb(37, 36, 81);
            panelLogo.BackColor = Color.FromArgb(37, 36, 81);
            pnlIcon.BackColor = Color.FromArgb(37, 36, 81);

        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void UserControlShow(Panel panel, UserControl userControl = null!)
        {
            foreach (var _userControl in panel.Controls)
            {
                if (_userControl == userControl)
                    ((UserControl)_userControl).Visible = true;
                else
                    ((UserControl)_userControl).Visible = false;
            }
        }

        private void ıcnbtnFood_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forFoodUser);
        }

        private void ıcnbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıcnbtnStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ıcnbtnUserExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz ?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void ıcnbtnActivity_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forActivityUser);
        }

        private void pnlForGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ıcnbtnIdealWeighCal_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forWeightCalculator);
        }

        private void ıcnbtnProfile_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forProfile);
        }


        private void ıcnbtnBMI_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forBMICalculator);
        }

        private void ıcnbtnMealReports_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forMealReports);
        }

        private void ıcnbtnReports_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.Gold);
            UserControlShow(pnlForGeneral, _forEndOfReports);
        }
    }
}
