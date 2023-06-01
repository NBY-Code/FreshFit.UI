namespace FreshFit.UI.ProfileControls
{
    partial class ProfileControlsActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControlsActivity));
            txtActivityFound = new TextBox();
            dgwActivity = new DataGridView();
            txtName = new TextBox();
            label3 = new Label();
            nmrForCalory = new NumericUpDown();
            txtUpdateName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nmrUpdateForCalory = new NumericUpDown();
            label7 = new Label();
            label4 = new Label();
            ıcnbtnUpdate = new FontAwesome.Sharp.IconButton();
            ıcnbtnDelete = new FontAwesome.Sharp.IconButton();
            ıcnbtnAdd = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ıcnbtnActivityList = new FontAwesome.Sharp.IconButton();
            ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgwActivity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCalory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrUpdateForCalory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtActivityFound
            // 
            txtActivityFound.Location = new Point(230, 42);
            txtActivityFound.Name = "txtActivityFound";
            txtActivityFound.Size = new Size(194, 25);
            txtActivityFound.TabIndex = 25;
            txtActivityFound.TextChanged += txtActivityFound_TextChanged;
            // 
            // dgwActivity
            // 
            dgwActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwActivity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwActivity.BackgroundColor = SystemColors.Control;
            dgwActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwActivity.Location = new Point(498, 40);
            dgwActivity.MultiSelect = false;
            dgwActivity.Name = "dgwActivity";
            dgwActivity.RowHeadersWidth = 51;
            dgwActivity.RowTemplate.Height = 29;
            dgwActivity.Size = new Size(538, 310);
            dgwActivity.TabIndex = 20;
            dgwActivity.CellClick += dgwActivity_CellClick;
            dgwActivity.CellMouseClick += dgwActivity_CellMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 25);
            txtName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 116);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 32;
            label3.Text = "Aktivite İsmi :";
            // 
            // nmrForCalory
            // 
            nmrForCalory.Location = new Point(295, 157);
            nmrForCalory.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrForCalory.Name = "nmrForCalory";
            nmrForCalory.Size = new Size(166, 25);
            nmrForCalory.TabIndex = 34;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(30, 326);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(200, 25);
            txtUpdateName.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(66, 285);
            label5.Name = "label5";
            label5.Size = new Size(141, 24);
            label5.TabIndex = 32;
            label5.Text = "Aktivite İsmi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(308, 285);
            label6.Name = "label6";
            label6.Size = new Size(141, 24);
            label6.TabIndex = 33;
            label6.Text = "Kalori (cal/dk)";
            // 
            // nmrUpdateForCalory
            // 
            nmrUpdateForCalory.Location = new Point(295, 325);
            nmrUpdateForCalory.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmrUpdateForCalory.Name = "nmrUpdateForCalory";
            nmrUpdateForCalory.Size = new Size(166, 25);
            nmrUpdateForCalory.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(19, 39);
            label7.Name = "label7";
            label7.Size = new Size(188, 24);
            label7.TabIndex = 27;
            label7.Text = "Aranacak Aktivite :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(241, 116);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 33;
            label4.Text = "Kalori (cal/dk) :";
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
            ıcnbtnUpdate.Location = new Point(123, 383);
            ıcnbtnUpdate.Name = "ıcnbtnUpdate";
            ıcnbtnUpdate.Size = new Size(289, 47);
            ıcnbtnUpdate.TabIndex = 49;
            ıcnbtnUpdate.Text = "Aktivite Güncelle";
            ıcnbtnUpdate.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnUpdate.UseVisualStyleBackColor = true;
            ıcnbtnUpdate.Click += ıcnbtnUpdate_Click;
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
            ıcnbtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnDelete.Location = new Point(498, 377);
            ıcnbtnDelete.Name = "ıcnbtnDelete";
            ıcnbtnDelete.Size = new Size(199, 53);
            ıcnbtnDelete.TabIndex = 48;
            ıcnbtnDelete.Text = "Aktivite Sil";
            ıcnbtnDelete.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnDelete.UseVisualStyleBackColor = false;
            ıcnbtnDelete.Click += ıcnbtnDelete_Click;
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
            ıcnbtnAdd.Location = new Point(102, 207);
            ıcnbtnAdd.Name = "ıcnbtnAdd";
            ıcnbtnAdd.Size = new Size(290, 54);
            ıcnbtnAdd.TabIndex = 47;
            ıcnbtnAdd.Text = "Aktivite Ekle";
            ıcnbtnAdd.UseVisualStyleBackColor = false;
            ıcnbtnAdd.Click += ıcnbtnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 482);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(993, 261);
            textBox1.TabIndex = 51;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // ıcnbtnActivityList
            // 
            ıcnbtnActivityList.FlatStyle = FlatStyle.Popup;
            ıcnbtnActivityList.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnActivityList.IconChar = FontAwesome.Sharp.IconChar.Running;
            ıcnbtnActivityList.IconColor = Color.Black;
            ıcnbtnActivityList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnActivityList.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnActivityList.Location = new Point(782, 376);
            ıcnbtnActivityList.Name = "ıcnbtnActivityList";
            ıcnbtnActivityList.Size = new Size(254, 53);
            ıcnbtnActivityList.TabIndex = 52;
            ıcnbtnActivityList.Text = "Aktiviteler ";
            ıcnbtnActivityList.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnActivityList.UseVisualStyleBackColor = true;
            ıcnbtnActivityList.Click += ıcnbtnActivityList_Click;
            // 
            // ıconPictureBox1
            // 
            ıconPictureBox1.BackColor = SystemColors.Control;
            ıconPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            ıconPictureBox1.ForeColor = SystemColors.ActiveCaptionText;
            ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Question;
            ıconPictureBox1.IconColor = SystemColors.ActiveCaptionText;
            ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconPictureBox1.IconSize = 28;
            ıconPictureBox1.Location = new Point(439, 39);
            ıconPictureBox1.Name = "ıconPictureBox1";
            ıconPictureBox1.Size = new Size(31, 28);
            ıconPictureBox1.TabIndex = 53;
            ıconPictureBox1.TabStop = false;
            // 
            // ProfileControlsActivity
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ıconPictureBox1);
            Controls.Add(ıcnbtnActivityList);
            Controls.Add(textBox1);
            Controls.Add(ıcnbtnUpdate);
            Controls.Add(ıcnbtnDelete);
            Controls.Add(ıcnbtnAdd);
            Controls.Add(nmrUpdateForCalory);
            Controls.Add(nmrForCalory);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUpdateName);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(txtActivityFound);
            Controls.Add(dgwActivity);
            Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "ProfileControlsActivity";
            Size = new Size(1257, 826);
            ((System.ComponentModel.ISupportInitialize)dgwActivity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForCalory).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrUpdateForCalory).EndInit();
            ((System.ComponentModel.ISupportInitialize)ıconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtActivityFound;
        private DataGridView dgwActivity;
        private TextBox txtName;
        private Label label3;
        private NumericUpDown nmrForCalory;
        private TextBox txtUpdateName;
        private Label label5;
        private Label label6;
        private NumericUpDown nmrUpdateForCalory;
        private Label label7;
        private Label label4;
        private FontAwesome.Sharp.IconButton ıcnbtnUpdate;
        private FontAwesome.Sharp.IconButton ıcnbtnDelete;
        private FontAwesome.Sharp.IconButton ıcnbtnAdd;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton ıcnbtnActivityList;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
    }
}
