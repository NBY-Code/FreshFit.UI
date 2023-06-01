using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshFit.UI.ProfileControls
{
    public partial class ProfileControlsBMICalculator : UserControl
    {
        double weight;
        double height;
        public ProfileControlsBMICalculator()
        {
            InitializeComponent();
        }

        private void ıcnbtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                weight = Convert.ToDouble(txtWeight.Text);
                height = Convert.ToDouble(txtHeight.Text);

                lblIBMI.Text = BMICalculator(height / 100, weight).ToString("00.00");
                lblIBMI.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Hesaplama yapılırken lütfen girilen değerleri kontrol ediniz.");
            }
        }
        private double BMICalculator(double height, double weight)
        {
            return weight / Math.Pow(height, 2);
        }

        private void ProfileControlsBMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
