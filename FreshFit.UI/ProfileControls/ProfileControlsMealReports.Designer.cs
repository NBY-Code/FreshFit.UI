namespace FreshFit.UI.ProfileControls
{
    partial class ProfileControlsMealReports
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
            dgwList = new DataGridView();
            dgwPersonelList = new DataGridView();
            cmbFoodType = new ComboBox();
            lblTakenCalory = new Label();
            lblRecommendedDailyCalory = new Label();
            label2 = new Label();
            label1 = new Label();
            lblYemekKategori = new Label();
            groupBox1 = new GroupBox();
            rdAperitif = new RadioButton();
            rdBreakFast = new RadioButton();
            rdLunch = new RadioButton();
            rdDinner = new RadioButton();
            nmrWaterQuantity = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            nmrPortion = new NumericUpDown();
            nmrTime = new NumericUpDown();
            label8 = new Label();
            lblRemainingCalories = new Label();
            label10 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ıcnbtnActivityList = new FontAwesome.Sharp.IconButton();
            ıcnbtnFoodLıst = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            ıcnbtnDelete = new FontAwesome.Sharp.IconButton();
            ıcnbtnMyActivity = new FontAwesome.Sharp.IconButton();
            ıcnbtnMyFood = new FontAwesome.Sharp.IconButton();
            ıcnbtnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgwList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersonelList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWaterQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPortion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrTime).BeginInit();
            SuspendLayout();
            // 
            // dgwList
            // 
            dgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwList.BackgroundColor = SystemColors.Control;
            dgwList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwList.Location = new Point(29, 43);
            dgwList.Margin = new Padding(3, 1, 3, 1);
            dgwList.Name = "dgwList";
            dgwList.RowHeadersWidth = 62;
            dgwList.RowTemplate.Height = 33;
            dgwList.Size = new Size(557, 339);
            dgwList.TabIndex = 1;
            dgwList.CellMouseClick += dgwList_CellMouseClick;
            // 
            // dgwPersonelList
            // 
            dgwPersonelList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPersonelList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwPersonelList.BackgroundColor = SystemColors.Control;
            dgwPersonelList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPersonelList.Location = new Point(616, 43);
            dgwPersonelList.Margin = new Padding(3, 1, 3, 1);
            dgwPersonelList.Name = "dgwPersonelList";
            dgwPersonelList.RowHeadersWidth = 62;
            dgwPersonelList.Size = new Size(464, 339);
            dgwPersonelList.TabIndex = 2;
            dgwPersonelList.CellMouseClick += dgwPersonelList_CellMouseClick;
            // 
            // cmbFoodType
            // 
            cmbFoodType.FormattingEnabled = true;
            cmbFoodType.Location = new Point(186, 474);
            cmbFoodType.Margin = new Padding(3, 1, 3, 1);
            cmbFoodType.Name = "cmbFoodType";
            cmbFoodType.Size = new Size(154, 28);
            cmbFoodType.TabIndex = 9;
            cmbFoodType.SelectedIndexChanged += cmbFoodType_SelectedIndexChanged;
            // 
            // lblTakenCalory
            // 
            lblTakenCalory.AutoSize = true;
            lblTakenCalory.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTakenCalory.Location = new Point(953, 604);
            lblTakenCalory.Name = "lblTakenCalory";
            lblTakenCalory.Size = new Size(22, 25);
            lblTakenCalory.TabIndex = 16;
            lblTakenCalory.Text = "0";
            // 
            // lblRecommendedDailyCalory
            // 
            lblRecommendedDailyCalory.AutoSize = true;
            lblRecommendedDailyCalory.BackColor = Color.Red;
            lblRecommendedDailyCalory.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecommendedDailyCalory.Location = new Point(770, 567);
            lblRecommendedDailyCalory.Name = "lblRecommendedDailyCalory";
            lblRecommendedDailyCalory.Size = new Size(22, 25);
            lblRecommendedDailyCalory.TabIndex = 15;
            lblRecommendedDailyCalory.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(606, 608);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 14;
            label2.Text = "Alınan Toplam Kalori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(616, 521);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 13;
            label1.Text = "Günlük Alınması Önerilen Maksimum kalori";
            // 
            // lblYemekKategori
            // 
            lblYemekKategori.AutoSize = true;
            lblYemekKategori.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblYemekKategori.Location = new Point(29, 474);
            lblYemekKategori.Name = "lblYemekKategori";
            lblYemekKategori.Size = new Size(154, 25);
            lblYemekKategori.TabIndex = 17;
            lblYemekKategori.Text = "Yemek Kategorisi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdAperitif);
            groupBox1.Controls.Add(rdBreakFast);
            groupBox1.Controls.Add(rdLunch);
            groupBox1.Controls.Add(rdDinner);
            groupBox1.Location = new Point(29, 521);
            groupBox1.Margin = new Padding(3, 1, 3, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 1, 3, 1);
            groupBox1.Size = new Size(310, 112);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğünler ";
            // 
            // rdAperitif
            // 
            rdAperitif.AutoSize = true;
            rdAperitif.Checked = true;
            rdAperitif.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdAperitif.Location = new Point(167, 68);
            rdAperitif.Margin = new Padding(3, 1, 3, 1);
            rdAperitif.Name = "rdAperitif";
            rdAperitif.Size = new Size(113, 29);
            rdAperitif.TabIndex = 22;
            rdAperitif.TabStop = true;
            rdAperitif.Text = "Ara Öğün";
            rdAperitif.UseVisualStyleBackColor = true;
            // 
            // rdBreakFast
            // 
            rdBreakFast.AutoSize = true;
            rdBreakFast.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdBreakFast.Location = new Point(5, 28);
            rdBreakFast.Margin = new Padding(3, 1, 3, 1);
            rdBreakFast.Name = "rdBreakFast";
            rdBreakFast.Size = new Size(98, 29);
            rdBreakFast.TabIndex = 19;
            rdBreakFast.Text = "Kahvaltı";
            rdBreakFast.UseVisualStyleBackColor = true;
            // 
            // rdLunch
            // 
            rdLunch.AutoSize = true;
            rdLunch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdLunch.Location = new Point(167, 28);
            rdLunch.Margin = new Padding(3, 1, 3, 1);
            rdLunch.Name = "rdLunch";
            rdLunch.Size = new Size(138, 29);
            rdLunch.TabIndex = 20;
            rdLunch.Text = "Öğle Yemeği";
            rdLunch.UseVisualStyleBackColor = true;
            // 
            // rdDinner
            // 
            rdDinner.AutoSize = true;
            rdDinner.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdDinner.Location = new Point(6, 68);
            rdDinner.Margin = new Padding(3, 1, 3, 1);
            rdDinner.Name = "rdDinner";
            rdDinner.Size = new Size(152, 29);
            rdDinner.TabIndex = 21;
            rdDinner.Text = "Akşam Yemeği";
            rdDinner.UseVisualStyleBackColor = true;
            // 
            // nmrWaterQuantity
            // 
            nmrWaterQuantity.Location = new Point(234, 666);
            nmrWaterQuantity.Margin = new Padding(5, 1, 5, 1);
            nmrWaterQuantity.Name = "nmrWaterQuantity";
            nmrWaterQuantity.Size = new Size(258, 25);
            nmrWaterQuantity.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 665);
            label6.Name = "label6";
            label6.Size = new Size(209, 25);
            label6.TabIndex = 20;
            label6.Text = "Tüketilen Su Miktarı (L.)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(29, 699);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 21;
            label7.Text = "Porsiyon";
            // 
            // nmrPortion
            // 
            nmrPortion.Location = new Point(234, 702);
            nmrPortion.Margin = new Padding(5, 1, 5, 1);
            nmrPortion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrPortion.Name = "nmrPortion";
            nmrPortion.Size = new Size(258, 25);
            nmrPortion.TabIndex = 22;
            nmrPortion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nmrTime
            // 
            nmrTime.Location = new Point(234, 740);
            nmrTime.Margin = new Padding(3, 1, 3, 1);
            nmrTime.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrTime.Name = "nmrTime";
            nmrTime.Size = new Size(258, 25);
            nmrTime.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 734);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 23;
            label8.Text = "Zaman (dk.)";
            // 
            // lblRemainingCalories
            // 
            lblRemainingCalories.AutoSize = true;
            lblRemainingCalories.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingCalories.Location = new Point(953, 642);
            lblRemainingCalories.Name = "lblRemainingCalories";
            lblRemainingCalories.Size = new Size(22, 25);
            lblRemainingCalories.TabIndex = 26;
            lblRemainingCalories.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(606, 642);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 25;
            label10.Text = "Kalan Kalori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(999, 525);
            label5.Name = "label5";
            label5.Size = new Size(16, 22);
            label5.TabIndex = 30;
            label5.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(911, 608);
            label3.Name = "label3";
            label3.Size = new Size(16, 22);
            label3.TabIndex = 30;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(911, 645);
            label4.Name = "label4";
            label4.Size = new Size(16, 22);
            label4.TabIndex = 30;
            label4.Text = ":";
            // 
            // ıcnbtnActivityList
            // 
            ıcnbtnActivityList.FlatStyle = FlatStyle.Popup;
            ıcnbtnActivityList.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnActivityList.IconChar = FontAwesome.Sharp.IconChar.Running;
            ıcnbtnActivityList.IconColor = Color.Black;
            ıcnbtnActivityList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnActivityList.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnActivityList.Location = new Point(344, 403);
            ıcnbtnActivityList.Name = "ıcnbtnActivityList";
            ıcnbtnActivityList.Size = new Size(242, 53);
            ıcnbtnActivityList.TabIndex = 53;
            ıcnbtnActivityList.Text = "Aktivite Listesi";
            ıcnbtnActivityList.UseVisualStyleBackColor = true;
            ıcnbtnActivityList.Click += ıcnbtnActivityList_Click;
            // 
            // ıcnbtnFoodLıst
            // 
            ıcnbtnFoodLıst.FlatStyle = FlatStyle.Popup;
            ıcnbtnFoodLıst.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnFoodLıst.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            ıcnbtnFoodLıst.IconColor = Color.Black;
            ıcnbtnFoodLıst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnFoodLıst.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnFoodLıst.Location = new Point(26, 403);
            ıcnbtnFoodLıst.Name = "ıcnbtnFoodLıst";
            ıcnbtnFoodLıst.Size = new Size(283, 53);
            ıcnbtnFoodLıst.TabIndex = 54;
            ıcnbtnFoodLıst.Text = "Yemekler Listesi";
            ıcnbtnFoodLıst.UseVisualStyleBackColor = true;
            ıcnbtnFoodLıst.Click += ıcnbtnFoodLıst_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(202, 667);
            label9.Name = "label9";
            label9.Size = new Size(16, 22);
            label9.TabIndex = 30;
            label9.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(202, 701);
            label11.Name = "label11";
            label11.Size = new Size(16, 22);
            label11.TabIndex = 30;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(202, 739);
            label12.Name = "label12";
            label12.Size = new Size(16, 22);
            label12.TabIndex = 30;
            label12.Text = ":";
            // 
            // ıcnbtnDelete
            // 
            ıcnbtnDelete.BackColor = Color.Transparent;
            ıcnbtnDelete.FlatAppearance.BorderSize = 0;
            ıcnbtnDelete.FlatStyle = FlatStyle.Flat;
            ıcnbtnDelete.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnDelete.ForeColor = Color.DarkRed;
            ıcnbtnDelete.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            ıcnbtnDelete.IconColor = Color.DarkRed;
            ıcnbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnDelete.Location = new Point(975, 388);
            ıcnbtnDelete.Margin = new Padding(2);
            ıcnbtnDelete.Name = "ıcnbtnDelete";
            ıcnbtnDelete.Size = new Size(105, 42);
            ıcnbtnDelete.TabIndex = 55;
            ıcnbtnDelete.Text = "İptal";
            ıcnbtnDelete.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnDelete.UseVisualStyleBackColor = false;
            ıcnbtnDelete.Click += ıcnbtnDelete_Click;
            // 
            // ıcnbtnMyActivity
            // 
            ıcnbtnMyActivity.FlatStyle = FlatStyle.Popup;
            ıcnbtnMyActivity.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnMyActivity.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ıcnbtnMyActivity.IconColor = Color.Black;
            ıcnbtnMyActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnMyActivity.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnMyActivity.Location = new Point(838, 437);
            ıcnbtnMyActivity.Name = "ıcnbtnMyActivity";
            ıcnbtnMyActivity.Size = new Size(242, 53);
            ıcnbtnMyActivity.TabIndex = 53;
            ıcnbtnMyActivity.Text = "Aktivitelerim";
            ıcnbtnMyActivity.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnMyActivity.UseVisualStyleBackColor = true;
            ıcnbtnMyActivity.Click += ıcnbtnMyActivity_Click;
            // 
            // ıcnbtnMyFood
            // 
            ıcnbtnMyFood.FlatStyle = FlatStyle.Popup;
            ıcnbtnMyFood.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnMyFood.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            ıcnbtnMyFood.IconColor = Color.Black;
            ıcnbtnMyFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnMyFood.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnMyFood.Location = new Point(606, 437);
            ıcnbtnMyFood.Name = "ıcnbtnMyFood";
            ıcnbtnMyFood.Size = new Size(226, 53);
            ıcnbtnMyFood.TabIndex = 54;
            ıcnbtnMyFood.Text = "Yemeklerim";
            ıcnbtnMyFood.UseVisualStyleBackColor = true;
            ıcnbtnMyFood.Click += ıcnbtnMyFood_Click;
            // 
            // ıcnbtnAdd
            // 
            ıcnbtnAdd.BackColor = Color.Transparent;
            ıcnbtnAdd.FlatAppearance.BorderSize = 0;
            ıcnbtnAdd.FlatStyle = FlatStyle.Flat;
            ıcnbtnAdd.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ıcnbtnAdd.ForeColor = Color.ForestGreen;
            ıcnbtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            ıcnbtnAdd.IconColor = Color.ForestGreen;
            ıcnbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnAdd.IconSize = 60;
            ıcnbtnAdd.ImageAlign = ContentAlignment.TopCenter;
            ıcnbtnAdd.Location = new Point(375, 534);
            ıcnbtnAdd.Margin = new Padding(2);
            ıcnbtnAdd.Name = "ıcnbtnAdd";
            ıcnbtnAdd.Size = new Size(182, 82);
            ıcnbtnAdd.TabIndex = 56;
            ıcnbtnAdd.Text = "Listeme Ekle";
            ıcnbtnAdd.TextAlign = ContentAlignment.BottomCenter;
            ıcnbtnAdd.UseVisualStyleBackColor = false;
            ıcnbtnAdd.Click += ıcnbtnAdd_Click;
            // 
            // ProfileControlsMealReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ıcnbtnAdd);
            Controls.Add(ıcnbtnDelete);
            Controls.Add(ıcnbtnMyFood);
            Controls.Add(ıcnbtnFoodLıst);
            Controls.Add(ıcnbtnMyActivity);
            Controls.Add(ıcnbtnActivityList);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(lblRemainingCalories);
            Controls.Add(label10);
            Controls.Add(nmrTime);
            Controls.Add(label8);
            Controls.Add(nmrPortion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(nmrWaterQuantity);
            Controls.Add(groupBox1);
            Controls.Add(lblYemekKategori);
            Controls.Add(lblTakenCalory);
            Controls.Add(lblRecommendedDailyCalory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbFoodType);
            Controls.Add(dgwPersonelList);
            Controls.Add(dgwList);
            Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfileControlsMealReports";
            Size = new Size(1137, 784);
            Load += ProfileControlsMealReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgwList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwPersonelList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWaterQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPortion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwList;
        private DataGridView dgwPersonelList;
        private ComboBox cmbFoodType;
        private Label lblTakenCalory;
        private Label lblRecommendedDailyCalory;
        private Label label2;
        private Label label1;
        private Label lblYemekKategori;
        private GroupBox groupBox1;
        private RadioButton rdAperitif;
        private RadioButton rdBreakFast;
        private RadioButton rdLunch;
        private RadioButton rdDinner;
        private NumericUpDown nmrWaterQuantity;
        private Label label6;
        private Label label7;
        private NumericUpDown nmrPortion;
        private NumericUpDown nmrTime;
        private Label label8;
        private Label lblRemainingCalories;
        private Label label10;
        private Label label5;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton ıcnbtnActivityList;
        private FontAwesome.Sharp.IconButton ıcnbtnFoodLıst;
        private Label label9;
        private Label label11;
        private Label label12;
        private FontAwesome.Sharp.IconButton ıcnbtnDelete;
        private FontAwesome.Sharp.IconButton ıcnbtnMyActivity;
        private FontAwesome.Sharp.IconButton ıcnbtnMyFood;
        private FontAwesome.Sharp.IconButton ıcnbtnAdd;
    }
}
