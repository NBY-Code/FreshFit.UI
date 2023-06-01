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

namespace FreshFit.UI.ProfileControls
{
    public partial class ProfileControlsWeightCalculator : UserControl
    {
        FreshFitControllers controllers;
        public ProfileControlsWeightCalculator()
        {
            InitializeComponent();
            controllers = FreshFitControllers.Instance;
        }
        private void ProfileControlsWeightCalculator_Load(object sender, EventArgs e)
        {

        }

        private void ıcnbtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double Boy = Convert.ToDouble(txtHeight.Text);
                if (Boy > 100)
                {
                    lblIdealWeight.Text = (45.5 + (2.3 * ((Boy / 2.54) - 60))).ToString("00.00");
                    lblIdealWeight.Visible = true;
                }
                else if (Boy < 3 && Boy > 0)
                {
                    lblIdealWeight.Text = (45.5 + (2.3 * ((Boy * 100 / 2.54) - 60))).ToString("00.00");
                    lblIdealWeight.Visible = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı bilgi girişi lütfen tekrar giriş yapınız.");
            }
        }
    }
}
