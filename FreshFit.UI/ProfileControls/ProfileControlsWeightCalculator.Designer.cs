namespace FreshFit.UI.ProfileControls
{
    partial class ProfileControlsWeightCalculator
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
            panel1 = new Panel();
            label3 = new Label();
            lblIdealWeight = new Label();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            ıcnbtnCalculate = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtHeight = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblIdealWeight);
            panel1.Controls.Add(ıconButton2);
            panel1.Controls.Add(ıcnbtnCalculate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            panel1.Location = new Point(177, 97);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 713);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(176, 36);
            label3.Name = "label3";
            label3.Size = new Size(425, 63);
            label3.TabIndex = 7;
            label3.Text = "İDEAL BOY KİLO HESAPLAMA";
            // 
            // lblIdealWeight
            // 
            lblIdealWeight.AutoSize = true;
            lblIdealWeight.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdealWeight.ForeColor = Color.Black;
            lblIdealWeight.Location = new Point(401, 540);
            lblIdealWeight.Margin = new Padding(2, 0, 2, 0);
            lblIdealWeight.Name = "lblIdealWeight";
            lblIdealWeight.Size = new Size(29, 32);
            lblIdealWeight.TabIndex = 6;
            lblIdealWeight.Text = "0";
            lblIdealWeight.Visible = false;
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
            ıconButton2.Location = new Point(117, 532);
            ıconButton2.Margin = new Padding(2);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(255, 53);
            ıconButton2.TabIndex = 5;
            ıconButton2.Text = "İdeal Kilo :";
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
            ıcnbtnCalculate.Location = new Point(235, 363);
            ıcnbtnCalculate.Margin = new Padding(2);
            ıcnbtnCalculate.Name = "ıcnbtnCalculate";
            ıcnbtnCalculate.Size = new Size(322, 64);
            ıcnbtnCalculate.TabIndex = 4;
            ıcnbtnCalculate.Text = "Hesapla";
            ıcnbtnCalculate.UseVisualStyleBackColor = false;
            ıcnbtnCalculate.Click += ıcnbtnCalculate_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(176, 296);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(389, 6);
            label2.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = SystemColors.Control;
            txtHeight.Location = new Point(176, 261);
            txtHeight.Margin = new Padding(2);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(386, 30);
            txtHeight.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(176, 209);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 68);
            label1.TabIndex = 1;
            label1.Text = "Boyunuzu Santimetre Cisinden Giriniz:";
            // 
            // ProfileControlsWeightCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(2);
            Name = "ProfileControlsWeightCalculator";
            Size = new Size(1106, 909);
            Load += ProfileControlsWeightCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıcnbtnCalculate;
        private Label label2;
        private TextBox txtHeight;
        private Label label1;
        private Label lblIdealWeight;
        private Label label3;
    }
}
