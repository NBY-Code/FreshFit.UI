namespace FreshFit.UI.Forms
{
    partial class RegistrationScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationScreen));
            txtFirstName = new TextBox();
            nmrForWeight = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnIconStatus = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rdioFemale = new RadioButton();
            rdioMale = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtPasswordAgain = new TextBox();
            ıcnbtnRegister = new FontAwesome.Sharp.IconButton();
            pbUserPicture = new PictureBox();
            label18 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            nmrForHeight = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            ıcnbtnPasswordHide = new FontAwesome.Sharp.IconButton();
            ıcnbtnPasswordShow = new FontAwesome.Sharp.IconButton();
            txtPasswordExplanation = new TextBox();
            pictureBox1 = new PictureBox();
            btnBack = new FontAwesome.Sharp.IconButton();
            ıcnbtnPicture = new FontAwesome.Sharp.IconButton();
            pbFirstName = new PictureBox();
            pbMail = new PictureBox();
            pbBirthDate = new PictureBox();
            pbPassword = new PictureBox();
            pbPasswordAgain = new PictureBox();
            txtFavoriteFood = new TextBox();
            pbFavoriteFood = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nmrForWeight).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrForHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordAgain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavoriteFood).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(594, 15);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(317, 45);
            txtFirstName.TabIndex = 1;
            txtFirstName.Leave += txtFirstName_Leave;
            // 
            // nmrForWeight
            // 
            nmrForWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmrForWeight.Location = new Point(594, 223);
            nmrForWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmrForWeight.Name = "nmrForWeight";
            nmrForWeight.Size = new Size(317, 34);
            nmrForWeight.TabIndex = 4;
            nmrForWeight.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // btnIconStatus
            // 
            btnIconStatus.BackColor = Color.Transparent;
            btnIconStatus.FlatAppearance.BorderSize = 0;
            btnIconStatus.FlatStyle = FlatStyle.Flat;
            btnIconStatus.Image = (Image)resources.GetObject("btnIconStatus.Image");
            btnIconStatus.Location = new Point(1127, 4);
            btnIconStatus.Name = "btnIconStatus";
            btnIconStatus.Size = new Size(70, 43);
            btnIconStatus.TabIndex = 9;
            btnIconStatus.UseVisualStyleBackColor = false;
            btnIconStatus.Click += btnIconStatus_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1203, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 43);
            btnExit.TabIndex = 10;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(463, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 11;
            label1.Text = "İsim";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(457, 79);
            label2.Name = "label2";
            label2.Size = new Size(110, 45);
            label2.TabIndex = 13;
            label2.Text = "Soyisim";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(594, 79);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(317, 45);
            txtLastName.TabIndex = 2;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(427, 144);
            label3.Name = "label3";
            label3.Size = new Size(139, 45);
            label3.TabIndex = 15;
            label3.Text = "Mail Adresi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(594, 144);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(317, 45);
            txtMail.TabIndex = 3;
            txtMail.Leave += txtMail_Leave;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(457, 212);
            label4.Name = "label4";
            label4.Size = new Size(110, 45);
            label4.TabIndex = 16;
            label4.Text = "Kilo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdioFemale);
            groupBox1.Controls.Add(rdioMale);
            groupBox1.Location = new Point(594, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 83);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rdioFemale
            // 
            rdioFemale.AutoSize = true;
            rdioFemale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdioFemale.Location = new Point(176, 43);
            rdioFemale.Name = "rdioFemale";
            rdioFemale.Size = new Size(80, 29);
            rdioFemale.TabIndex = 1;
            rdioFemale.Text = "Kadın";
            rdioFemale.UseVisualStyleBackColor = true;
            // 
            // rdioMale
            // 
            rdioMale.AutoSize = true;
            rdioMale.Checked = true;
            rdioMale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdioMale.Location = new Point(32, 43);
            rdioMale.Name = "rdioMale";
            rdioMale.Size = new Size(77, 29);
            rdioMale.TabIndex = 0;
            rdioMale.TabStop = true;
            rdioMale.Text = "Erkek";
            rdioMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(350, 472);
            label5.Name = "label5";
            label5.Size = new Size(218, 63);
            label5.TabIndex = 20;
            label5.Text = "En Sevdiğiniz Yemek";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(449, 359);
            label6.Name = "label6";
            label6.Size = new Size(133, 45);
            label6.TabIndex = 21;
            label6.Text = "Cinsiyet";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(594, 431);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(318, 27);
            dtpBirthDate.TabIndex = 8;
            dtpBirthDate.ValueChanged += dtpBirthDate_ValueChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(393, 424);
            label7.Name = "label7";
            label7.Size = new Size(187, 45);
            label7.TabIndex = 23;
            label7.Text = "Doğum Tarihi";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(457, 544);
            label8.Name = "label8";
            label8.Size = new Size(123, 45);
            label8.TabIndex = 25;
            label8.Text = "Şifre";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(594, 544);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(317, 45);
            txtPassword.TabIndex = 9;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(415, 617);
            label9.Name = "label9";
            label9.Size = new Size(167, 45);
            label9.TabIndex = 27;
            label9.Text = "Şifre Tekrar";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(594, 617);
            txtPasswordAgain.Multiline = true;
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PasswordChar = '*';
            txtPasswordAgain.Size = new Size(317, 45);
            txtPasswordAgain.TabIndex = 10;
            txtPasswordAgain.Leave += txtPasswordAgain_Leave;
            // 
            // ıcnbtnRegister
            // 
            ıcnbtnRegister.FlatAppearance.BorderSize = 0;
            ıcnbtnRegister.FlatStyle = FlatStyle.Flat;
            ıcnbtnRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnRegister.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            ıcnbtnRegister.IconColor = Color.Black;
            ıcnbtnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnRegister.Location = new Point(664, 721);
            ıcnbtnRegister.Name = "ıcnbtnRegister";
            ıcnbtnRegister.Size = new Size(262, 69);
            ıcnbtnRegister.TabIndex = 11;
            ıcnbtnRegister.Text = "Kayıt Ol ";
            ıcnbtnRegister.UseVisualStyleBackColor = true;
            ıcnbtnRegister.Click += ıcnbtnRegister_Click;
            // 
            // pbUserPicture
            // 
            pbUserPicture.Location = new Point(1074, 183);
            pbUserPicture.Name = "pbUserPicture";
            pbUserPicture.Size = new Size(189, 160);
            pbUserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserPicture.TabIndex = 29;
            pbUserPicture.TabStop = false;
            pbUserPicture.Visible = false;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(545, 15);
            label18.Name = "label18";
            label18.Size = new Size(43, 45);
            label18.TabIndex = 30;
            label18.Text = ": ";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(553, 79);
            label10.Name = "label10";
            label10.Size = new Size(43, 45);
            label10.TabIndex = 39;
            label10.Text = ": ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(553, 209);
            label11.Name = "label11";
            label11.Size = new Size(43, 45);
            label11.TabIndex = 41;
            label11.Text = ": ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(553, 144);
            label12.Name = "label12";
            label12.Size = new Size(43, 45);
            label12.TabIndex = 40;
            label12.Text = ": ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(553, 479);
            label13.Name = "label13";
            label13.Size = new Size(43, 45);
            label13.TabIndex = 43;
            label13.Text = ": ";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(553, 359);
            label19.Name = "label19";
            label19.Size = new Size(43, 45);
            label19.TabIndex = 42;
            label19.Text = ": ";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(553, 532);
            label20.Name = "label20";
            label20.Size = new Size(43, 63);
            label20.TabIndex = 45;
            label20.Text = ": ";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(553, 421);
            label21.Name = "label21";
            label21.Size = new Size(43, 45);
            label21.TabIndex = 44;
            label21.Text = ": ";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(553, 608);
            label22.Name = "label22";
            label22.Size = new Size(43, 63);
            label22.TabIndex = 46;
            label22.Text = ": ";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nmrForHeight
            // 
            nmrForHeight.DecimalPlaces = 2;
            nmrForHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nmrForHeight.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmrForHeight.Location = new Point(594, 276);
            nmrForHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nmrForHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrForHeight.Name = "nmrForHeight";
            nmrForHeight.Size = new Size(317, 34);
            nmrForHeight.TabIndex = 5;
            nmrForHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(425, 271);
            label14.Name = "label14";
            label14.Size = new Size(143, 51);
            label14.TabIndex = 16;
            label14.Text = "Boy (metre)";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(553, 271);
            label15.Name = "label15";
            label15.Size = new Size(43, 45);
            label15.TabIndex = 41;
            label15.Text = ": ";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ıcnbtnPasswordHide
            // 
            ıcnbtnPasswordHide.BackColor = Color.Transparent;
            ıcnbtnPasswordHide.FlatAppearance.BorderSize = 0;
            ıcnbtnPasswordHide.FlatStyle = FlatStyle.Flat;
            ıcnbtnPasswordHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            ıcnbtnPasswordHide.IconColor = Color.Sienna;
            ıcnbtnPasswordHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnPasswordHide.Location = new Point(786, 669);
            ıcnbtnPasswordHide.Name = "ıcnbtnPasswordHide";
            ıcnbtnPasswordHide.Size = new Size(65, 36);
            ıcnbtnPasswordHide.TabIndex = 47;
            ıcnbtnPasswordHide.UseVisualStyleBackColor = false;
            ıcnbtnPasswordHide.Visible = false;
            ıcnbtnPasswordHide.Click += ıcnbtnPasswordHide_Click;
            // 
            // ıcnbtnPasswordShow
            // 
            ıcnbtnPasswordShow.BackColor = Color.Transparent;
            ıcnbtnPasswordShow.FlatAppearance.BorderSize = 0;
            ıcnbtnPasswordShow.FlatStyle = FlatStyle.Flat;
            ıcnbtnPasswordShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ıcnbtnPasswordShow.IconColor = Color.Sienna;
            ıcnbtnPasswordShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnPasswordShow.Location = new Point(848, 669);
            ıcnbtnPasswordShow.Name = "ıcnbtnPasswordShow";
            ıcnbtnPasswordShow.Size = new Size(65, 36);
            ıcnbtnPasswordShow.TabIndex = 48;
            ıcnbtnPasswordShow.UseVisualStyleBackColor = false;
            ıcnbtnPasswordShow.Click += ıcnbtnPasswordShow_Click;
            // 
            // txtPasswordExplanation
            // 
            txtPasswordExplanation.BackColor = SystemColors.ScrollBar;
            txtPasswordExplanation.Enabled = false;
            txtPasswordExplanation.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            txtPasswordExplanation.ForeColor = Color.Red;
            txtPasswordExplanation.Location = new Point(999, 560);
            txtPasswordExplanation.Multiline = true;
            txtPasswordExplanation.Name = "txtPasswordExplanation";
            txtPasswordExplanation.Size = new Size(262, 109);
            txtPasswordExplanation.TabIndex = 55;
            txtPasswordExplanation.Text = "Şifre uzunluğu en az 8 karakterden oluşmalı ve en az 1 büyük harf, 1 küçük harf ve 1 özel karakter içermelidir";
            txtPasswordExplanation.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 813);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.Location = new Point(314, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 45);
            btnBack.TabIndex = 57;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ıcnbtnPicture
            // 
            ıcnbtnPicture.FlatAppearance.BorderSize = 0;
            ıcnbtnPicture.FlatStyle = FlatStyle.Flat;
            ıcnbtnPicture.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnPicture.ForeColor = SystemColors.ActiveCaptionText;
            ıcnbtnPicture.IconChar = FontAwesome.Sharp.IconChar.Images;
            ıcnbtnPicture.IconColor = Color.Black;
            ıcnbtnPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnPicture.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnPicture.Location = new Point(1033, 372);
            ıcnbtnPicture.Name = "ıcnbtnPicture";
            ıcnbtnPicture.Size = new Size(240, 52);
            ıcnbtnPicture.TabIndex = 58;
            ıcnbtnPicture.Text = "Resim Yükle";
            ıcnbtnPicture.UseVisualStyleBackColor = true;
            ıcnbtnPicture.Click += ıcnbtnPicture_Click;
            // 
            // pbFirstName
            // 
            pbFirstName.Image = (Image)resources.GetObject("pbFirstName.Image");
            pbFirstName.Location = new Point(927, 15);
            pbFirstName.Name = "pbFirstName";
            pbFirstName.Size = new Size(56, 43);
            pbFirstName.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFirstName.TabIndex = 68;
            pbFirstName.TabStop = false;
            // 
            // pbMail
            // 
            pbMail.Image = (Image)resources.GetObject("pbMail.Image");
            pbMail.Location = new Point(928, 145);
            pbMail.Name = "pbMail";
            pbMail.Size = new Size(56, 43);
            pbMail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMail.TabIndex = 70;
            pbMail.TabStop = false;
            // 
            // pbBirthDate
            // 
            pbBirthDate.Image = (Image)resources.GetObject("pbBirthDate.Image");
            pbBirthDate.Location = new Point(927, 425);
            pbBirthDate.Name = "pbBirthDate";
            pbBirthDate.Size = new Size(56, 43);
            pbBirthDate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBirthDate.TabIndex = 71;
            pbBirthDate.TabStop = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(928, 545);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(56, 43);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 71;
            pbPassword.TabStop = false;
            // 
            // pbPasswordAgain
            // 
            pbPasswordAgain.Image = (Image)resources.GetObject("pbPasswordAgain.Image");
            pbPasswordAgain.Location = new Point(928, 619);
            pbPasswordAgain.Name = "pbPasswordAgain";
            pbPasswordAgain.Size = new Size(56, 43);
            pbPasswordAgain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPasswordAgain.TabIndex = 71;
            pbPasswordAgain.TabStop = false;
            // 
            // txtFavoriteFood
            // 
            txtFavoriteFood.Location = new Point(595, 479);
            txtFavoriteFood.Multiline = true;
            txtFavoriteFood.Name = "txtFavoriteFood";
            txtFavoriteFood.Size = new Size(317, 45);
            txtFavoriteFood.TabIndex = 7;
            txtFavoriteFood.TextChanged += txtFavoriteFood_TextChanged;
            // 
            // pbFavoriteFood
            // 
            pbFavoriteFood.Image = (Image)resources.GetObject("pbFavoriteFood.Image");
            pbFavoriteFood.Location = new Point(927, 480);
            pbFavoriteFood.Name = "pbFavoriteFood";
            pbFavoriteFood.Size = new Size(56, 43);
            pbFavoriteFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFavoriteFood.TabIndex = 72;
            pbFavoriteFood.TabStop = false;
            // 
            // RegistrationScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1282, 813);
            Controls.Add(pbFavoriteFood);
            Controls.Add(txtFavoriteFood);
            Controls.Add(pbPasswordAgain);
            Controls.Add(pbPassword);
            Controls.Add(pbBirthDate);
            Controls.Add(pbMail);
            Controls.Add(pbFirstName);
            Controls.Add(ıcnbtnPicture);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(txtPasswordExplanation);
            Controls.Add(ıcnbtnPasswordShow);
            Controls.Add(ıcnbtnPasswordHide);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label13);
            Controls.Add(label19);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label18);
            Controls.Add(pbUserPicture);
            Controls.Add(ıcnbtnRegister);
            Controls.Add(label9);
            Controls.Add(txtPasswordAgain);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMail);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnIconStatus);
            Controls.Add(nmrForHeight);
            Controls.Add(nmrForWeight);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationScreen";
            ((System.ComponentModel.ISupportInitialize)nmrForWeight).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrForHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPasswordAgain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFavoriteFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFirstName;
        private NumericUpDown nmrForWeight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnIconStatus;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtMail;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rdioFemale;
        private RadioButton rdioMale;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpBirthDate;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtPasswordAgain;
        private FontAwesome.Sharp.IconButton ıcnbtnRegister;
        private PictureBox pbUserPicture;
        private Label label18;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private NumericUpDown nmrForHeight;
        private Label label14;
        private Label label15;
        private FontAwesome.Sharp.IconButton ıcnbtnPasswordHide;
        private FontAwesome.Sharp.IconButton ıcnbtnPasswordShow;
        private Label lblSoyAd;
        private TextBox txtPasswordExplanation;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton ıcnbtnPicture;
        private PictureBox pbFirstName;
        private PictureBox pbMail;
        private PictureBox pbBirthDate;
        private PictureBox pbPassword;
        private PictureBox pbPasswordAgain;
        private TextBox txtFavoriteFood;
        private PictureBox pbFavoriteFood;
    }
}