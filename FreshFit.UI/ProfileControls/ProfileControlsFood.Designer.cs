namespace FreshFit.UI.ProfileControls
{
    partial class ProfileControlsFood
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
            txtFoundFood = new TextBox();
            pictureBox1 = new PictureBox();
            dgwFood = new DataGridView();
            txtFoodNameAdd = new TextBox();
            nmrForCaloryAdding = new NumericUpDown();
            nmrForProteinAdding = new NumericUpDown();
            nmrForFatAdding = new NumericUpDown();
            nmrForCarbonhydrateAdding = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            nmrForCaloryUpdating = new NumericUpDown();
            nmrForProteinUpdating = new NumericUpDown();
            nmrForFatUpdating = new NumericUpDown();
            nmrForCarbonhydrateUpdating = new NumericUpDown();
            txtFoodNameUpdate = new TextBox();
            cmbForAdd = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbForUpdate = new ComboBox();
            label3 = new Label();
            ıcnbtnPictureImage = new FontAwesome.Sharp.IconButton();
            ıcnibtnListed = new FontAwesome.Sharp.IconButton();
            ıcnbtnAdd = new FontAwesome.Sharp.IconButton();
            ıcnbtnDelete = new FontAwesome.Sharp.IconButton();
            ıcnbtnUpdate = new FontAwesome.Sharp.IconButton();
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCaloryAdding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForProteinAdding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForFatAdding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCarbonhydrateAdding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCaloryUpdating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForProteinUpdating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForFatUpdating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCarbonhydrateUpdating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFoundFood
            // 
            txtFoundFood.Location = new Point(130, 16);
            txtFoundFood.Margin = new Padding(3, 2, 3, 2);
            txtFoundFood.Name = "txtFoundFood";
            txtFoundFood.Size = new Size(296, 22);
            txtFoundFood.TabIndex = 39;
            txtFoundFood.TextChanged += txtFoundFood_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(726, 42);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // dgwFood
            // 
            dgwFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwFood.BackgroundColor = SystemColors.Control;
            dgwFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwFood.Location = new Point(22, 44);
            dgwFood.Margin = new Padding(3, 2, 3, 2);
            dgwFood.MultiSelect = false;
            dgwFood.Name = "dgwFood";
            dgwFood.RowHeadersWidth = 51;
            dgwFood.RowTemplate.Height = 29;
            dgwFood.Size = new Size(669, 481);
            dgwFood.TabIndex = 20;
            dgwFood.CellMouseClick += dgwFood_CellMouseClick;
            // 
            // txtFoodNameAdd
            // 
            txtFoodNameAdd.Location = new Point(726, 358);
            txtFoodNameAdd.Margin = new Padding(3, 2, 3, 2);
            txtFoodNameAdd.Name = "txtFoodNameAdd";
            txtFoodNameAdd.Size = new Size(157, 22);
            txtFoodNameAdd.TabIndex = 39;
            // 
            // nmrForCaloryAdding
            // 
            nmrForCaloryAdding.Location = new Point(730, 431);
            nmrForCaloryAdding.Margin = new Padding(3, 2, 3, 2);
            nmrForCaloryAdding.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForCaloryAdding.Name = "nmrForCaloryAdding";
            nmrForCaloryAdding.Size = new Size(153, 22);
            nmrForCaloryAdding.TabIndex = 26;
            // 
            // nmrForProteinAdding
            // 
            nmrForProteinAdding.Location = new Point(915, 507);
            nmrForProteinAdding.Margin = new Padding(3, 2, 3, 2);
            nmrForProteinAdding.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForProteinAdding.Name = "nmrForProteinAdding";
            nmrForProteinAdding.Size = new Size(153, 22);
            nmrForProteinAdding.TabIndex = 26;
            // 
            // nmrForFatAdding
            // 
            nmrForFatAdding.Location = new Point(915, 431);
            nmrForFatAdding.Margin = new Padding(3, 2, 3, 2);
            nmrForFatAdding.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForFatAdding.Name = "nmrForFatAdding";
            nmrForFatAdding.Size = new Size(153, 22);
            nmrForFatAdding.TabIndex = 26;
            // 
            // nmrForCarbonhydrateAdding
            // 
            nmrForCarbonhydrateAdding.Location = new Point(730, 507);
            nmrForCarbonhydrateAdding.Margin = new Padding(3, 2, 3, 2);
            nmrForCarbonhydrateAdding.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForCarbonhydrateAdding.Name = "nmrForCarbonhydrateAdding";
            nmrForCarbonhydrateAdding.Size = new Size(153, 22);
            nmrForCarbonhydrateAdding.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(767, 330);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 25;
            label4.Text = "Yemek Adı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(757, 406);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 25;
            label5.Text = "Kalori Miktarı(cal/m)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(947, 481);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 25;
            label9.Text = "Protein Miktarı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(950, 406);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 25;
            label10.Text = "Yağ Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(750, 474);
            label11.Name = "label11";
            label11.Size = new Size(135, 20);
            label11.TabIndex = 25;
            label11.Text = "Karbonhidrat Mikltarı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(56, 568);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 25;
            label12.Text = "Yemek Adı :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(243, 568);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 25;
            label13.Text = "Kalori Miktarı(cal/m)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(472, 561);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 25;
            label14.Text = "Protein Miktarı";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(472, 661);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 25;
            label15.Text = "Yağ Miktarı";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(236, 662);
            label16.Name = "label16";
            label16.Size = new Size(135, 20);
            label16.TabIndex = 25;
            label16.Text = "Karbonhidrat Mikltarı";
            // 
            // nmrForCaloryUpdating
            // 
            nmrForCaloryUpdating.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nmrForCaloryUpdating.Location = new Point(225, 604);
            nmrForCaloryUpdating.Margin = new Padding(3, 2, 3, 2);
            nmrForCaloryUpdating.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForCaloryUpdating.Name = "nmrForCaloryUpdating";
            nmrForCaloryUpdating.Size = new Size(157, 25);
            nmrForCaloryUpdating.TabIndex = 26;
            // 
            // nmrForProteinUpdating
            // 
            nmrForProteinUpdating.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nmrForProteinUpdating.Location = new Point(435, 604);
            nmrForProteinUpdating.Margin = new Padding(3, 2, 3, 2);
            nmrForProteinUpdating.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForProteinUpdating.Name = "nmrForProteinUpdating";
            nmrForProteinUpdating.Size = new Size(157, 25);
            nmrForProteinUpdating.TabIndex = 26;
            // 
            // nmrForFatUpdating
            // 
            nmrForFatUpdating.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nmrForFatUpdating.Location = new Point(435, 697);
            nmrForFatUpdating.Margin = new Padding(3, 2, 3, 2);
            nmrForFatUpdating.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForFatUpdating.Name = "nmrForFatUpdating";
            nmrForFatUpdating.Size = new Size(157, 25);
            nmrForFatUpdating.TabIndex = 26;
            // 
            // nmrForCarbonhydrateUpdating
            // 
            nmrForCarbonhydrateUpdating.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nmrForCarbonhydrateUpdating.Location = new Point(225, 697);
            nmrForCarbonhydrateUpdating.Margin = new Padding(3, 2, 3, 2);
            nmrForCarbonhydrateUpdating.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForCarbonhydrateUpdating.Name = "nmrForCarbonhydrateUpdating";
            nmrForCarbonhydrateUpdating.Size = new Size(157, 25);
            nmrForCarbonhydrateUpdating.TabIndex = 26;
            // 
            // txtFoodNameUpdate
            // 
            txtFoodNameUpdate.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtFoodNameUpdate.Location = new Point(22, 604);
            txtFoodNameUpdate.Margin = new Padding(3, 2, 3, 2);
            txtFoodNameUpdate.Name = "txtFoodNameUpdate";
            txtFoodNameUpdate.Size = new Size(157, 25);
            txtFoodNameUpdate.TabIndex = 39;
            // 
            // cmbForAdd
            // 
            cmbForAdd.FormattingEnabled = true;
            cmbForAdd.Location = new Point(915, 358);
            cmbForAdd.Name = "cmbForAdd";
            cmbForAdd.Size = new Size(157, 24);
            cmbForAdd.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(956, 325);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 38;
            label1.Text = "Yemek Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 662);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 38;
            label2.Text = "Yemek Türü";
            // 
            // cmbForUpdate
            // 
            cmbForUpdate.Font = new Font("Arial Narrow", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbForUpdate.FormattingEnabled = true;
            cmbForUpdate.Location = new Point(14, 695);
            cmbForUpdate.Name = "cmbForUpdate";
            cmbForUpdate.Size = new Size(165, 28);
            cmbForUpdate.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 15);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 25;
            label3.Text = "Yemek Ara:";
            // 
            // ıcnbtnPictureImage
            // 
            ıcnbtnPictureImage.BackColor = SystemColors.ActiveBorder;
            ıcnbtnPictureImage.FlatAppearance.BorderSize = 0;
            ıcnbtnPictureImage.FlatStyle = FlatStyle.Flat;
            ıcnbtnPictureImage.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnPictureImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            ıcnbtnPictureImage.IconColor = Color.Black;
            ıcnbtnPictureImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnPictureImage.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnPictureImage.Location = new Point(779, 232);
            ıcnbtnPictureImage.Margin = new Padding(3, 2, 3, 2);
            ıcnbtnPictureImage.Name = "ıcnbtnPictureImage";
            ıcnbtnPictureImage.Size = new Size(204, 53);
            ıcnbtnPictureImage.TabIndex = 42;
            ıcnbtnPictureImage.Text = "Resim Ekle";
            ıcnbtnPictureImage.UseVisualStyleBackColor = false;
            ıcnbtnPictureImage.Click += ıcnbtnPictureImage_Click;
            // 
            // ıcnibtnListed
            // 
            ıcnibtnListed.BackColor = Color.Transparent;
            ıcnibtnListed.FlatAppearance.BorderSize = 0;
            ıcnibtnListed.FlatStyle = FlatStyle.Flat;
            ıcnibtnListed.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnibtnListed.ForeColor = Color.Black;
            ıcnibtnListed.IconChar = FontAwesome.Sharp.IconChar.List;
            ıcnibtnListed.IconColor = Color.Black;
            ıcnibtnListed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnibtnListed.IconSize = 35;
            ıcnibtnListed.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnibtnListed.Location = new Point(501, 10);
            ıcnibtnListed.Margin = new Padding(3, 2, 3, 2);
            ıcnibtnListed.Name = "ıcnibtnListed";
            ıcnibtnListed.Size = new Size(190, 30);
            ıcnibtnListed.TabIndex = 43;
            ıcnibtnListed.Text = "Yemekleri Listele";
            ıcnibtnListed.TextAlign = ContentAlignment.MiddleRight;
            ıcnibtnListed.UseVisualStyleBackColor = false;
            ıcnibtnListed.Click += ıcnibtnListed_Click;
            // 
            // ıcnbtnAdd
            // 
            ıcnbtnAdd.BackColor = Color.Transparent;
            ıcnbtnAdd.FlatAppearance.BorderSize = 0;
            ıcnbtnAdd.FlatStyle = FlatStyle.Flat;
            ıcnbtnAdd.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnAdd.ForeColor = Color.ForestGreen;
            ıcnbtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            ıcnbtnAdd.IconColor = Color.ForestGreen;
            ıcnbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnAdd.IconSize = 60;
            ıcnbtnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnAdd.Location = new Point(800, 557);
            ıcnbtnAdd.Name = "ıcnbtnAdd";
            ıcnbtnAdd.Size = new Size(258, 63);
            ıcnbtnAdd.TabIndex = 44;
            ıcnbtnAdd.Text = "Yemek Ekle";
            ıcnbtnAdd.UseVisualStyleBackColor = false;
            ıcnbtnAdd.Click += ıcnbtnAdd_Click;
            // 
            // ıcnbtnDelete
            // 
            ıcnbtnDelete.BackColor = Color.Transparent;
            ıcnbtnDelete.FlatAppearance.BorderSize = 0;
            ıcnbtnDelete.FlatStyle = FlatStyle.Flat;
            ıcnbtnDelete.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnDelete.ForeColor = Color.DarkRed;
            ıcnbtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            ıcnbtnDelete.IconColor = Color.DarkRed;
            ıcnbtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnDelete.ImageAlign = ContentAlignment.TopCenter;
            ıcnbtnDelete.Location = new Point(613, 534);
            ıcnbtnDelete.Name = "ıcnbtnDelete";
            ıcnbtnDelete.Size = new Size(109, 86);
            ıcnbtnDelete.TabIndex = 45;
            ıcnbtnDelete.Text = "Yemek Sil";
            ıcnbtnDelete.TextAlign = ContentAlignment.BottomCenter;
            ıcnbtnDelete.UseVisualStyleBackColor = false;
            ıcnbtnDelete.Click += ıcnbtnDelete_Click;
            // 
            // ıcnbtnUpdate
            // 
            ıcnbtnUpdate.FlatAppearance.BorderSize = 0;
            ıcnbtnUpdate.FlatStyle = FlatStyle.Flat;
            ıcnbtnUpdate.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnUpdate.ForeColor = Color.RosyBrown;
            ıcnbtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            ıcnbtnUpdate.IconColor = Color.RosyBrown;
            ıcnbtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnUpdate.IconSize = 70;
            ıcnbtnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnUpdate.Location = new Point(628, 680);
            ıcnbtnUpdate.Name = "ıcnbtnUpdate";
            ıcnbtnUpdate.Size = new Size(257, 55);
            ıcnbtnUpdate.TabIndex = 46;
            ıcnbtnUpdate.Text = "Güncelle";
            ıcnbtnUpdate.UseVisualStyleBackColor = true;
            ıcnbtnUpdate.Click += ıcnbtnUpdate_Click;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = SystemColors.Control;
            ıconPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            ıconPictureBox1.ForeColor = SystemColors.ActiveCaptionText;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Question;
            ıconPictureBox1.IconColor = SystemColors.ActiveCaptionText;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 27;
            ıconPictureBox1.Location = new Point(446, 8);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new Size(27, 32);
            ıconPictureBox1.TabIndex = 47;
            ıconPictureBox1.TabStop = false;
            // 
            // ProfileControlsFood
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ıconPictureBox1);
            Controls.Add(ıcnbtnUpdate);
            Controls.Add(ıcnbtnDelete);
            Controls.Add(ıcnbtnAdd);
            Controls.Add(ıcnibtnListed);
            Controls.Add(ıcnbtnPictureImage);
            Controls.Add(cmbForUpdate);
            Controls.Add(cmbForAdd);
            Controls.Add(txtFoodNameUpdate);
            Controls.Add(txtFoodNameAdd);
            Controls.Add(txtFoundFood);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrForCarbonhydrateUpdating);
            Controls.Add(nmrForFatUpdating);
            Controls.Add(nmrForCarbonhydrateAdding);
            Controls.Add(nmrForProteinUpdating);
            Controls.Add(nmrForFatAdding);
            Controls.Add(nmrForCaloryUpdating);
            Controls.Add(nmrForProteinAdding);
            Controls.Add(nmrForCaloryAdding);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dgwFood);
            Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "ProfileControlsFood";
            Size = new Size(1106, 826);
            Load += ProfileControlsFood_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCaloryAdding).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForProteinAdding).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForFatAdding).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCarbonhydrateAdding).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCaloryUpdating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForProteinUpdating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForFatUpdating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCarbonhydrateUpdating).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFoundFood;
        private PictureBox pictureBox1;
        private DataGridView dgwFood;
        private TextBox txtFoodNameAdd;
        private NumericUpDown nmrForCaloryAdding;
        private NumericUpDown nmrForProteinAdding;
        private NumericUpDown nmrForFatAdding;
        private NumericUpDown nmrForCarbonhydrateAdding;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private NumericUpDown nmrForCaloryUpdating;
        private NumericUpDown nmrForProteinUpdating;
        private NumericUpDown nmrForFatUpdating;
        private NumericUpDown nmrForCarbonhydrateUpdating;
        private TextBox txtFoodNameUpdate;
        private ComboBox cmbForAdd;
        private Label label1;
        private Label label2;
        private ComboBox cmbForUpdate;
        private Label label3;
        private FontAwesome.Sharp.IconButton ıcnbtnPictureImage;
        private FontAwesome.Sharp.IconButton ıcnibtnListed;
        private FontAwesome.Sharp.IconButton ıcnbtnAdd;
        private FontAwesome.Sharp.IconButton ıcnbtnDelete;
        private FontAwesome.Sharp.IconButton ıcnbtnUpdate;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}
