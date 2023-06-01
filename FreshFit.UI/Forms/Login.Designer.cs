namespace FreshFit.UI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            ıbtnBack = new FontAwesome.Sharp.IconButton();
            btnIconStatus = new Button();
            btnExit = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            ıcnbtnLogin = new FontAwesome.Sharp.IconButton();
            ıcnbtnPasswordHide = new FontAwesome.Sharp.IconButton();
            ıcnbtnPasswordShow = new FontAwesome.Sharp.IconButton();
            ıconButton3 = new FontAwesome.Sharp.IconButton();
            lblGirişlbl = new Label();
            ıconButton4 = new FontAwesome.Sharp.IconButton();
            ıconButton5 = new FontAwesome.Sharp.IconButton();
            pbMail = new PictureBox();
            pbPassword = new PictureBox();
            ıcnbtnForgetPassword = new FontAwesome.Sharp.IconButton();
            txtGeneralDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 815);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ıbtnBack
            // 
            ıbtnBack.FlatAppearance.BorderSize = 0;
            ıbtnBack.FlatStyle = FlatStyle.Flat;
            ıbtnBack.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            ıbtnBack.IconColor = Color.Black;
            ıbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıbtnBack.Location = new Point(321, 12);
            ıbtnBack.Name = "ıbtnBack";
            ıbtnBack.Size = new Size(75, 45);
            ıbtnBack.TabIndex = 55;
            ıbtnBack.UseVisualStyleBackColor = true;
            ıbtnBack.Click += ıbtnBack_Click;
            // 
            // btnIconStatus
            // 
            btnIconStatus.BackColor = Color.Transparent;
            btnIconStatus.FlatAppearance.BorderSize = 0;
            btnIconStatus.FlatStyle = FlatStyle.Flat;
            btnIconStatus.Image = (Image)resources.GetObject("btnIconStatus.Image");
            btnIconStatus.Location = new Point(1318, 13);
            btnIconStatus.Name = "btnIconStatus";
            btnIconStatus.Size = new Size(70, 43);
            btnIconStatus.TabIndex = 57;
            btnIconStatus.UseVisualStyleBackColor = false;
            btnIconStatus.Click += btnIconStatus_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1394, 13);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 43);
            btnExit.TabIndex = 58;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(811, 340);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(317, 45);
            txtMail.TabIndex = 40;
            txtMail.Text = "Admin@gmail.com";
            txtMail.Leave += txtMail_Leave;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(654, 343);
            label4.Name = "label4";
            label4.Size = new Size(110, 45);
            label4.TabIndex = 41;
            label4.Text = "Mail";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(811, 411);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(317, 45);
            txtPassword.TabIndex = 42;
            txtPassword.Text = "Admin123.";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(654, 413);
            label3.Name = "label3";
            label3.Size = new Size(110, 45);
            label3.TabIndex = 43;
            label3.Text = "Şifre";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ıcnbtnLogin
            // 
            ıcnbtnLogin.FlatAppearance.BorderSize = 0;
            ıcnbtnLogin.FlatStyle = FlatStyle.Flat;
            ıcnbtnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnLogin.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            ıcnbtnLogin.IconColor = Color.Black;
            ıcnbtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnLogin.IconSize = 52;
            ıcnbtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            ıcnbtnLogin.Location = new Point(911, 515);
            ıcnbtnLogin.Name = "ıcnbtnLogin";
            ıcnbtnLogin.Size = new Size(213, 89);
            ıcnbtnLogin.TabIndex = 57;
            ıcnbtnLogin.Text = "Giriş Yap";
            ıcnbtnLogin.TextAlign = ContentAlignment.MiddleRight;
            ıcnbtnLogin.UseVisualStyleBackColor = true;
            ıcnbtnLogin.Click += ıcnbtnLogin_Click;
            // 
            // ıcnbtnPasswordHide
            // 
            ıcnbtnPasswordHide.BackColor = Color.Transparent;
            ıcnbtnPasswordHide.FlatAppearance.BorderSize = 0;
            ıcnbtnPasswordHide.FlatStyle = FlatStyle.Flat;
            ıcnbtnPasswordHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            ıcnbtnPasswordHide.IconColor = Color.Sienna;
            ıcnbtnPasswordHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnPasswordHide.Location = new Point(969, 472);
            ıcnbtnPasswordHide.Name = "ıcnbtnPasswordHide";
            ıcnbtnPasswordHide.Size = new Size(65, 36);
            ıcnbtnPasswordHide.TabIndex = 58;
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
            ıcnbtnPasswordShow.Location = new Point(1040, 472);
            ıcnbtnPasswordShow.Name = "ıcnbtnPasswordShow";
            ıcnbtnPasswordShow.Size = new Size(65, 36);
            ıcnbtnPasswordShow.TabIndex = 59;
            ıcnbtnPasswordShow.UseVisualStyleBackColor = false;
            ıcnbtnPasswordShow.Click += ıcnbtnPasswordShow_Click;
            // 
            // ıconButton3
            // 
            ıconButton3.FlatAppearance.BorderSize = 0;
            ıconButton3.FlatStyle = FlatStyle.Flat;
            ıconButton3.Font = new Font("Segoe UI Semibold", 25.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton3.IconColor = Color.Black;
            ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton3.Location = new Point(853, 184);
            ıconButton3.Name = "ıconButton3";
            ıconButton3.Size = new Size(182, 93);
            ıconButton3.TabIndex = 60;
            ıconButton3.Text = "GİRİŞ";
            ıconButton3.UseVisualStyleBackColor = true;
            // 
            // lblGirişlbl
            // 
            lblGirişlbl.BackColor = Color.Brown;
            lblGirişlbl.Location = new Point(853, 267);
            lblGirişlbl.Name = "lblGirişlbl";
            lblGirişlbl.Size = new Size(181, 11);
            lblGirişlbl.TabIndex = 62;
            lblGirişlbl.Visible = false;
            // 
            // ıconButton4
            // 
            ıconButton4.BackColor = Color.Transparent;
            ıconButton4.Enabled = false;
            ıconButton4.FlatAppearance.BorderSize = 0;
            ıconButton4.FlatStyle = FlatStyle.Flat;
            ıconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
            ıconButton4.IconColor = Color.Black;
            ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton4.IconSize = 40;
            ıconButton4.Location = new Point(747, 343);
            ıconButton4.Name = "ıconButton4";
            ıconButton4.Size = new Size(58, 45);
            ıconButton4.TabIndex = 63;
            ıconButton4.UseVisualStyleBackColor = false;
            // 
            // ıconButton5
            // 
            ıconButton5.BackColor = Color.Transparent;
            ıconButton5.Enabled = false;
            ıconButton5.FlatAppearance.BorderSize = 0;
            ıconButton5.FlatStyle = FlatStyle.Flat;
            ıconButton5.IconChar = FontAwesome.Sharp.IconChar.Key;
            ıconButton5.IconColor = Color.Black;
            ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton5.Location = new Point(747, 411);
            ıconButton5.Name = "ıconButton5";
            ıconButton5.Size = new Size(58, 45);
            ıconButton5.TabIndex = 63;
            ıconButton5.UseVisualStyleBackColor = false;
            // 
            // pbMail
            // 
            pbMail.Image = (Image)resources.GetObject("pbMail.Image");
            pbMail.Location = new Point(1134, 343);
            pbMail.Name = "pbMail";
            pbMail.Size = new Size(56, 43);
            pbMail.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMail.TabIndex = 66;
            pbMail.TabStop = false;
            pbMail.Visible = false;
            // 
            // pbPassword
            // 
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(1134, 413);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(56, 43);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 67;
            pbPassword.TabStop = false;
            pbPassword.Visible = false;
            // 
            // ıcnbtnForgetPassword
            // 
            ıcnbtnForgetPassword.FlatAppearance.BorderSize = 0;
            ıcnbtnForgetPassword.FlatStyle = FlatStyle.Flat;
            ıcnbtnForgetPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ıcnbtnForgetPassword.ForeColor = Color.Firebrick;
            ıcnbtnForgetPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            ıcnbtnForgetPassword.IconColor = Color.Black;
            ıcnbtnForgetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnForgetPassword.Location = new Point(937, 609);
            ıcnbtnForgetPassword.Name = "ıcnbtnForgetPassword";
            ıcnbtnForgetPassword.Size = new Size(191, 35);
            ıcnbtnForgetPassword.TabIndex = 68;
            ıcnbtnForgetPassword.Text = "Şifremi Unuttum";
            ıcnbtnForgetPassword.UseVisualStyleBackColor = true;
            ıcnbtnForgetPassword.Click += ıcnbtnForgetPassword_Click;
            // 
            // txtGeneralDescription
            // 
            txtGeneralDescription.BackColor = SystemColors.ScrollBar;
            txtGeneralDescription.Enabled = false;
            txtGeneralDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtGeneralDescription.Location = new Point(1216, 372);
            txtGeneralDescription.Multiline = true;
            txtGeneralDescription.Name = "txtGeneralDescription";
            txtGeneralDescription.Size = new Size(207, 61);
            txtGeneralDescription.TabIndex = 47;
            txtGeneralDescription.Text = "İşaretli kısımlar boş bırakılamaz";
            txtGeneralDescription.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1467, 815);
            Controls.Add(txtGeneralDescription);
            Controls.Add(ıcnbtnForgetPassword);
            Controls.Add(pbPassword);
            Controls.Add(pbMail);
            Controls.Add(ıconButton5);
            Controls.Add(ıconButton4);
            Controls.Add(lblGirişlbl);
            Controls.Add(ıconButton3);
            Controls.Add(btnExit);
            Controls.Add(btnIconStatus);
            Controls.Add(ıcnbtnPasswordShow);
            Controls.Add(ıcnbtnPasswordHide);
            Controls.Add(ıbtnBack);
            Controls.Add(ıcnbtnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtMail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ıbtnBack;
        private Button btnIconStatus;
        private Button btnExit;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private FontAwesome.Sharp.IconButton ıcnbtnLogin;
        private FontAwesome.Sharp.IconButton ıcnbtnPasswordHide;
        private FontAwesome.Sharp.IconButton ıcnbtnPasswordShow;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private Label lblGirişlbl;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private PictureBox pbMail;
        private PictureBox pbPassword;
        private FontAwesome.Sharp.IconButton ıcnbtnForgetPassword;
        private TextBox txtGeneralDescription;
    }
}