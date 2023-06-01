namespace FreshFit.UI.Forms
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            btnRegistrationScreen = new Button();
            btnLogin = new Button();
            ıcnbtnExit = new FontAwesome.Sharp.IconButton();
            ıcnbtnStatus = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnRegistrationScreen
            // 
            btnRegistrationScreen.BackColor = Color.Transparent;
            btnRegistrationScreen.FlatAppearance.BorderSize = 0;
            btnRegistrationScreen.FlatStyle = FlatStyle.Flat;
            btnRegistrationScreen.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrationScreen.Image = (Image)resources.GetObject("btnRegistrationScreen.Image");
            btnRegistrationScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrationScreen.Location = new Point(935, 707);
            btnRegistrationScreen.Name = "btnRegistrationScreen";
            btnRegistrationScreen.Size = new Size(302, 96);
            btnRegistrationScreen.TabIndex = 4;
            btnRegistrationScreen.Text = "Kayıt Ol";
            btnRegistrationScreen.UseVisualStyleBackColor = false;
            btnRegistrationScreen.Click += btnRegistrationScreen_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(664, 720);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 83);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // ıcnbtnExit
            // 
            ıcnbtnExit.BackColor = Color.Transparent;
            ıcnbtnExit.FlatAppearance.BorderSize = 0;
            ıcnbtnExit.FlatStyle = FlatStyle.Flat;
            ıcnbtnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ıcnbtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            ıcnbtnExit.IconColor = Color.Black;
            ıcnbtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnExit.IconSize = 60;
            ıcnbtnExit.Location = new Point(1160, 12);
            ıcnbtnExit.Name = "ıcnbtnExit";
            ıcnbtnExit.Size = new Size(110, 63);
            ıcnbtnExit.TabIndex = 5;
            ıcnbtnExit.UseVisualStyleBackColor = false;
            ıcnbtnExit.Click += btnExit_Click;
            // 
            // ıcnbtnStatus
            // 
            ıcnbtnStatus.BackColor = Color.Transparent;
            ıcnbtnStatus.FlatAppearance.BorderSize = 0;
            ıcnbtnStatus.FlatStyle = FlatStyle.Flat;
            ıcnbtnStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ıcnbtnStatus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            ıcnbtnStatus.IconColor = Color.Black;
            ıcnbtnStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıcnbtnStatus.Location = new Point(1044, 12);
            ıcnbtnStatus.Name = "ıcnbtnStatus";
            ıcnbtnStatus.Size = new Size(110, 63);
            ıcnbtnStatus.TabIndex = 6;
            ıcnbtnStatus.UseVisualStyleBackColor = false;
            ıcnbtnStatus.Click += btnIconStatus_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1282, 813);
            Controls.Add(ıcnbtnStatus);
            Controls.Add(ıcnbtnExit);
            Controls.Add(btnRegistrationScreen);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Welcome_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrationScreen;
        private Button btnLogin;
        private FontAwesome.Sharp.IconButton ıcnbtnExit;
        private FontAwesome.Sharp.IconButton ıcnbtnStatus;
    }
}