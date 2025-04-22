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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRightLogin = new System.Windows.Forms.Panel();
            this.pnlLeftImage = new System.Windows.Forms.Panel();
            this.pbLoginImage = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
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
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 550);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRightLogin
            // 
            this.pnlRightLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightLogin.Location = new System.Drawing.Point(650, 31);
            this.pnlRightLogin.Name = "pnlRightLogin";
            this.pnlRightLogin.Size = new System.Drawing.Size(350, 519);
            this.pnlRightLogin.TabIndex = 2;
            // 
            // pnlLeftImage
            // 
            this.pnlLeftImage.Controls.Add(this.pbLoginImage);
            this.pnlLeftImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftImage.Location = new System.Drawing.Point(0, 31);
            this.pnlLeftImage.Name = "pnlLeftImage";
            this.pnlLeftImage.Size = new System.Drawing.Size(650, 519);
            this.pnlLeftImage.TabIndex = 1;
            // 
            // pbLoginImage
            // 
            this.pbLoginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoginImage.Location = new System.Drawing.Point(0, 0);
            this.pbLoginImage.Name = "pbLoginImage";
            this.pbLoginImage.Size = new System.Drawing.Size(650, 519);
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
            this.pnlTitle.Size = new System.Drawing.Size(1000, 31);
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
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Spor Salonu Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(1000, 1);
            this.pnlTitleSeperator.TabIndex = 1;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlMain.ResumeLayout(false);
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
    }
}