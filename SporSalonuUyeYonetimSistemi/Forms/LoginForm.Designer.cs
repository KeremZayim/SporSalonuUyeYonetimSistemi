using SporSalonuUyeYonetimSistemi.Classes;

namespace SporSalonuUyeYonetimSistemi.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRightLogin = new System.Windows.Forms.Panel();
            this.pbRightImage = new System.Windows.Forms.PictureBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.switchRememberMe = new MaterialSkin.Controls.MaterialSwitch();
            this.tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlLeftImage = new System.Windows.Forms.Panel();
            this.pbLoginImage = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlRightLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImage)).BeginInit();
            this.pnlLeftImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRightLogin);
            this.pnlMain.Controls.Add(this.pnlLeftImage);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(994, 547);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRightLogin
            // 
            this.pnlRightLogin.Controls.Add(this.pbRightImage);
            this.pnlRightLogin.Controls.Add(this.btnLogin);
            this.pnlRightLogin.Controls.Add(this.switchRememberMe);
            this.pnlRightLogin.Controls.Add(this.tbPassword);
            this.pnlRightLogin.Controls.Add(this.tbUsername);
            this.pnlRightLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightLogin.Location = new System.Drawing.Point(644, 31);
            this.pnlRightLogin.Name = "pnlRightLogin";
            this.pnlRightLogin.Size = new System.Drawing.Size(350, 516);
            this.pnlRightLogin.TabIndex = 7;
            // 
            // pbRightImage
            // 
            this.pbRightImage.Image = global::SporSalonuUyeYonetimSistemi.Properties.Resources.logo;
            this.pbRightImage.Location = new System.Drawing.Point(87, 57);
            this.pbRightImage.Name = "pbRightImage";
            this.pbRightImage.Size = new System.Drawing.Size(196, 196);
            this.pbRightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRightImage.TabIndex = 4;
            this.pbRightImage.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Login;
            this.btnLogin.Location = new System.Drawing.Point(86, 432);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(199, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = true;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // switchRememberMe
            // 
            this.switchRememberMe.Depth = 0;
            this.switchRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.switchRememberMe.Location = new System.Drawing.Point(174, 390);
            this.switchRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.switchRememberMe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchRememberMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchRememberMe.Name = "switchRememberMe";
            this.switchRememberMe.Ripple = true;
            this.switchRememberMe.Size = new System.Drawing.Size(147, 29);
            this.switchRememberMe.TabIndex = 3;
            this.switchRememberMe.Text = "Beni Hatırla";
            this.switchRememberMe.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.HideSelection = true;
            this.tbPassword.Hint = "Şifre";
            this.tbPassword.LeadingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Password;
            this.tbPassword.Location = new System.Drawing.Point(50, 334);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PrefixSuffixText = null;
            this.tbPassword.ReadOnly = false;
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(271, 48);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TabStop = false;
            this.tbPassword.Tag = "visible";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TrailingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Eye;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.TrailingIconClick += new System.EventHandler(this.tbPassword_TrailingIconClick);
            // 
            // tbUsername
            // 
            this.tbUsername.AnimateReadOnly = false;
            this.tbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsername.Depth = 0;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.HideSelection = true;
            this.tbUsername.Hint = "Kullanıcı Adı";
            this.tbUsername.LeadingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Username;
            this.tbUsername.Location = new System.Drawing.Point(50, 280);
            this.tbUsername.MaxLength = 50;
            this.tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PrefixSuffixText = null;
            this.tbUsername.ReadOnly = false;
            this.tbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(271, 48);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TabStop = false;
            this.tbUsername.Tag = "";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.TrailingIcon = null;
            this.tbUsername.UseSystemPasswordChar = false;
            // 
            // pnlLeftImage
            // 
            this.pnlLeftImage.Controls.Add(this.pbLoginImage);
            this.pnlLeftImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftImage.Location = new System.Drawing.Point(0, 31);
            this.pnlLeftImage.Name = "pnlLeftImage";
            this.pnlLeftImage.Size = new System.Drawing.Size(650, 516);
            this.pnlLeftImage.TabIndex = 6;
            // 
            // pbLoginImage
            // 
            this.pbLoginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoginImage.Location = new System.Drawing.Point(0, 0);
            this.pbLoginImage.Name = "pbLoginImage";
            this.pbLoginImage.Size = new System.Drawing.Size(650, 516);
            this.pbLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginImage.TabIndex = 0;
            this.pbLoginImage.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Controls.Add(this.btnExitApplication);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(994, 31);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(170, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(661, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(994, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(955, 0);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(45, 30);
            this.btnExitApplication.TabIndex = 0;
            this.btnExitApplication.Text = "X";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnlMain);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlRightLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRightImage)).EndInit();
            this.pnlLeftImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlLeftImage;
        private System.Windows.Forms.Panel pnlRightLogin;
        private System.Windows.Forms.PictureBox pbLoginImage;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox2 tbUsername;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
        private MaterialSkin.Controls.MaterialSwitch switchRememberMe;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private System.Windows.Forms.PictureBox pbRightImage;
    }
}