namespace FreshFit.UI.ProfileControls
{
    partial class ProfileControlsBMICalculator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControlsBMICalculator));
            panel1 = new Panel();
            label4 = new Label();
            txtHeight = new TextBox();
            label5 = new Label();
            label3 = new Label();
            lblIBMI = new Label();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            ıcnbtnCalculate = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtWeight = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblIBMI);
            panel1.Controls.Add(ıconButton2);
            panel1.Controls.Add(ıcnbtnCalculate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtWeight);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 411);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(33, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(389, 6);
            label4.TabIndex = 17;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.Control;
            txtHeight.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtHeight.Location = new Point(33, 171);
            txtHeight.Margin = new Padding(2);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(386, 36);
            txtHeight.TabIndex = 16;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(429, 74);
            label5.TabIndex = 15;
            label5.Text = "Boyunuzu Santimetre Cisinden Giriniz:";
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(244, 28);
            label3.Name = "label3";
            label3.Size = new Size(493, 46);
            label3.TabIndex = 14;
            label3.Text = "VÜCUT KİTLE İNDEKSİ HESAPLAMA";
            // 
            // lblIBMI
            // 
            lblIBMI.AutoSize = true;
            lblIBMI.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblIBMI.ForeColor = Color.Black;
            lblIBMI.Location = new Point(583, 360);
            lblIBMI.Margin = new Padding(2, 0, 2, 0);
            lblIBMI.Name = "lblIBMI";
            lblIBMI.Size = new Size(29, 32);
            lblIBMI.TabIndex = 13;
            lblIBMI.Text = "0";
            lblIBMI.Visible = false;
            // 
            // ıconButton2
            // 
            ıconButton2.Enabled = false;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıconButton2.ForeColor = Color.Black;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Weight;
            ıconButton2.IconColor = Color.Black;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton2.Location = new Point(237, 351);
            ıconButton2.Margin = new Padding(2);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(309, 53);
            ıconButton2.TabIndex = 12;
            ıconButton2.Text = "Vücut Kitle İndeksiniz:";
            ıconButton2.TextAlign = ContentAlignment.MiddleRight;
            ıconButton2.UseVisualStyleBackColor = true;
            // 
            // ıcnbtnCalculate
            // 
            ıcnbtnCalculate.BackColor = Color.DarkSalmon;
            ıcnbtnCalculate.FlatAppearance.BorderSize = 0;
            ıcnbtnCalculate.FlatStyle = FlatStyle.Flat;
            ıcnbtnCalculate.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnCalculate.ForeColor = Color.Black;
            ıcnbtnCalculate.IconChar = FontAwesome.Sharp.IconChar.Nutritionix;
            ıcnbtnCalculate.IconColor = Color.Black;
            ıcnbtnCalculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnCalculate.Location = new Point(335, 249);
            ıcnbtnCalculate.Margin = new Padding(2);
            ıcnbtnCalculate.Name = "ıcnbtnCalculate";
            ıcnbtnCalculate.Size = new Size(322, 64);
            ıcnbtnCalculate.TabIndex = 11;
            ıcnbtnCalculate.Text = "Hesapla";
            ıcnbtnCalculate.UseVisualStyleBackColor = false;
            ıcnbtnCalculate.Click += ıcnbtnCalculate_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(533, 206);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(389, 6);
            label2.TabIndex = 10;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.Control;
            txtWeight.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtWeight.Location = new Point(533, 171);
            txtWeight.Margin = new Padding(2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(386, 36);
            txtWeight.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(622, 101);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 48);
            label1.TabIndex = 8;
            label1.Text = "Kilonuzu Giriniz:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 421);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ProfileControlsBMICalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "ProfileControlsBMICalculator";
            Size = new Size(1106, 909);
            Load += ProfileControlsBMICalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label lblIBMI;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıcnbtnCalculate;
        private Label label2;
        private TextBox txtWeight;
        private Label label1;
        private TextBox txtHeight;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
