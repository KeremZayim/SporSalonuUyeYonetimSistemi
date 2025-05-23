﻿namespace SporSalonuUyeYonetimSistemi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMembershipTypes = new MaterialSkin.Controls.MaterialButton();
            this.btnPayments = new MaterialSkin.Controls.MaterialButton();
            this.btnParticipationHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnWorkoutLists = new MaterialSkin.Controls.MaterialButton();
            this.btnExercises = new MaterialSkin.Controls.MaterialButton();
            this.btnMembers = new MaterialSkin.Controls.MaterialButton();
            this.btnTrainers = new MaterialSkin.Controls.MaterialButton();
            this.btnMainPage = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnExitApplication);
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1280, 31);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(310, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(661, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | Ana Sayfa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(1235, 0);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(45, 30);
            this.btnExitApplication.TabIndex = 9;
            this.btnExitApplication.Text = "X";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(1280, 1);
            this.pnlTitleSeperator.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1280, 720);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlChildForm);
            this.pnlBody.Controls.Add(this.pnlMenu);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 31);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1280, 689);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(276, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1004, 689);
            this.pnlChildForm.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnMembershipTypes);
            this.pnlMenu.Controls.Add(this.btnPayments);
            this.pnlMenu.Controls.Add(this.btnParticipationHistory);
            this.pnlMenu.Controls.Add(this.btnWorkoutLists);
            this.pnlMenu.Controls.Add(this.btnExercises);
            this.pnlMenu.Controls.Add(this.btnMembers);
            this.pnlMenu.Controls.Add(this.btnTrainers);
            this.pnlMenu.Controls.Add(this.btnMainPage);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 689);
            this.pnlMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SporSalonuUyeYonetimSistemi.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(74, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnMembershipTypes
            // 
            this.btnMembershipTypes.AutoSize = false;
            this.btnMembershipTypes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMembershipTypes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMembershipTypes.Depth = 0;
            this.btnMembershipTypes.HighEmphasis = true;
            this.btnMembershipTypes.Icon = null;
            this.btnMembershipTypes.Location = new System.Drawing.Point(0, 292);
            this.btnMembershipTypes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMembershipTypes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMembershipTypes.Name = "btnMembershipTypes";
            this.btnMembershipTypes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMembershipTypes.Size = new System.Drawing.Size(275, 66);
            this.btnMembershipTypes.TabIndex = 3;
            this.btnMembershipTypes.Text = "Üyelik Türleri";
            this.btnMembershipTypes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMembershipTypes.UseAccentColor = false;
            this.btnMembershipTypes.UseVisualStyleBackColor = true;
            this.btnMembershipTypes.Click += new System.EventHandler(this.btnMembershipTypes_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.AutoSize = false;
            this.btnPayments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayments.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayments.Depth = 0;
            this.btnPayments.HighEmphasis = true;
            this.btnPayments.Icon = null;
            this.btnPayments.Location = new System.Drawing.Point(0, 556);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPayments.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPayments.Size = new System.Drawing.Size(275, 66);
            this.btnPayments.TabIndex = 7;
            this.btnPayments.Text = "Ödemeler";
            this.btnPayments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayments.UseAccentColor = false;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnParticipationHistory
            // 
            this.btnParticipationHistory.AutoSize = false;
            this.btnParticipationHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnParticipationHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnParticipationHistory.Depth = 0;
            this.btnParticipationHistory.HighEmphasis = true;
            this.btnParticipationHistory.Icon = null;
            this.btnParticipationHistory.Location = new System.Drawing.Point(0, 622);
            this.btnParticipationHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnParticipationHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParticipationHistory.Name = "btnParticipationHistory";
            this.btnParticipationHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnParticipationHistory.Size = new System.Drawing.Size(275, 66);
            this.btnParticipationHistory.TabIndex = 8;
            this.btnParticipationHistory.Text = "Giriş Çıkışlar";
            this.btnParticipationHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnParticipationHistory.UseAccentColor = false;
            this.btnParticipationHistory.UseVisualStyleBackColor = true;
            this.btnParticipationHistory.Click += new System.EventHandler(this.btnParticipationHistory_Click);
            // 
            // btnWorkoutLists
            // 
            this.btnWorkoutLists.AutoSize = false;
            this.btnWorkoutLists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWorkoutLists.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWorkoutLists.Depth = 0;
            this.btnWorkoutLists.HighEmphasis = true;
            this.btnWorkoutLists.Icon = null;
            this.btnWorkoutLists.Location = new System.Drawing.Point(0, 490);
            this.btnWorkoutLists.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWorkoutLists.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWorkoutLists.Name = "btnWorkoutLists";
            this.btnWorkoutLists.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWorkoutLists.Size = new System.Drawing.Size(275, 66);
            this.btnWorkoutLists.TabIndex = 6;
            this.btnWorkoutLists.Text = "Antrenman Listeleri";
            this.btnWorkoutLists.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWorkoutLists.UseAccentColor = false;
            this.btnWorkoutLists.UseVisualStyleBackColor = true;
            this.btnWorkoutLists.Click += new System.EventHandler(this.btnTraningLists_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.AutoSize = false;
            this.btnExercises.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExercises.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExercises.Depth = 0;
            this.btnExercises.HighEmphasis = true;
            this.btnExercises.Icon = null;
            this.btnExercises.Location = new System.Drawing.Point(0, 424);
            this.btnExercises.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExercises.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExercises.Size = new System.Drawing.Size(275, 66);
            this.btnExercises.TabIndex = 5;
            this.btnExercises.Text = "Egzersizler";
            this.btnExercises.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExercises.UseAccentColor = false;
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.AutoSize = false;
            this.btnMembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMembers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMembers.Depth = 0;
            this.btnMembers.HighEmphasis = true;
            this.btnMembers.Icon = null;
            this.btnMembers.Location = new System.Drawing.Point(0, 226);
            this.btnMembers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMembers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMembers.Size = new System.Drawing.Size(275, 66);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "Üyeler";
            this.btnMembers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMembers.UseAccentColor = false;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.AutoSize = false;
            this.btnTrainers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrainers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrainers.Depth = 0;
            this.btnTrainers.HighEmphasis = true;
            this.btnTrainers.Icon = null;
            this.btnTrainers.Location = new System.Drawing.Point(0, 358);
            this.btnTrainers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrainers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrainers.Size = new System.Drawing.Size(275, 66);
            this.btnTrainers.TabIndex = 4;
            this.btnTrainers.Text = "Antrenörler";
            this.btnTrainers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrainers.UseAccentColor = false;
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.AutoSize = false;
            this.btnMainPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMainPage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMainPage.Depth = 0;
            this.btnMainPage.HighEmphasis = true;
            this.btnMainPage.Icon = null;
            this.btnMainPage.Location = new System.Drawing.Point(0, 160);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMainPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMainPage.Size = new System.Drawing.Size(275, 66);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Text = "Ana Sayfa";
            this.btnMainPage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMainPage.UseAccentColor = false;
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(275, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 689);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Panel pnlMain;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlChildForm;
        private MaterialSkin.Controls.MaterialButton btnMainPage;
        private MaterialSkin.Controls.MaterialButton btnTrainers;
        private MaterialSkin.Controls.MaterialButton btnMembers;
        private MaterialSkin.Controls.MaterialButton btnExercises;
        private MaterialSkin.Controls.MaterialButton btnParticipationHistory;
        private MaterialSkin.Controls.MaterialButton btnPayments;
        private MaterialSkin.Controls.MaterialButton btnWorkoutLists;
        private MaterialSkin.Controls.MaterialButton btnMembershipTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

