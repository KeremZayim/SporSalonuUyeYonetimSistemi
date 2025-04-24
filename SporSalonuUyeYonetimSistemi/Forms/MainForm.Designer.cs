namespace SporSalonuUyeYonetimSistemi
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPayments = new MaterialSkin.Controls.MaterialButton();
            this.btnParticipationHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnTraningLists = new MaterialSkin.Controls.MaterialButton();
            this.btnExercises = new MaterialSkin.Controls.MaterialButton();
            this.btnMembers = new MaterialSkin.Controls.MaterialButton();
            this.btnCoach = new MaterialSkin.Controls.MaterialButton();
            this.btnMainPage = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMembershipTypes = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMenu.SuspendLayout();
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
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(1235, 0);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(45, 30);
            this.btnExitApplication.TabIndex = 1;
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
            this.pnlMenu.Controls.Add(this.btnMembershipTypes);
            this.pnlMenu.Controls.Add(this.btnPayments);
            this.pnlMenu.Controls.Add(this.btnParticipationHistory);
            this.pnlMenu.Controls.Add(this.btnTraningLists);
            this.pnlMenu.Controls.Add(this.btnExercises);
            this.pnlMenu.Controls.Add(this.btnMembers);
            this.pnlMenu.Controls.Add(this.btnCoach);
            this.pnlMenu.Controls.Add(this.btnMainPage);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 689);
            this.pnlMenu.TabIndex = 0;
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
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Ödemeler";
            this.btnPayments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayments.UseAccentColor = false;
            this.btnPayments.UseVisualStyleBackColor = true;
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
            this.btnParticipationHistory.TabIndex = 5;
            this.btnParticipationHistory.Text = "Giriş Çıkışlar";
            this.btnParticipationHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnParticipationHistory.UseAccentColor = false;
            this.btnParticipationHistory.UseVisualStyleBackColor = true;
            // 
            // btnTraningLists
            // 
            this.btnTraningLists.AutoSize = false;
            this.btnTraningLists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTraningLists.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTraningLists.Depth = 0;
            this.btnTraningLists.HighEmphasis = true;
            this.btnTraningLists.Icon = null;
            this.btnTraningLists.Location = new System.Drawing.Point(0, 490);
            this.btnTraningLists.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTraningLists.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTraningLists.Name = "btnTraningLists";
            this.btnTraningLists.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTraningLists.Size = new System.Drawing.Size(275, 66);
            this.btnTraningLists.TabIndex = 8;
            this.btnTraningLists.Text = "Antrenman Listeleri";
            this.btnTraningLists.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTraningLists.UseAccentColor = false;
            this.btnTraningLists.UseVisualStyleBackColor = true;
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
            this.btnExercises.TabIndex = 6;
            this.btnExercises.Text = "Egzersizler";
            this.btnExercises.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExercises.UseAccentColor = false;
            this.btnExercises.UseVisualStyleBackColor = true;
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
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Üyeler";
            this.btnMembers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMembers.UseAccentColor = false;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnCoach
            // 
            this.btnCoach.AutoSize = false;
            this.btnCoach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCoach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCoach.Depth = 0;
            this.btnCoach.HighEmphasis = true;
            this.btnCoach.Icon = null;
            this.btnCoach.Location = new System.Drawing.Point(0, 358);
            this.btnCoach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCoach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCoach.Size = new System.Drawing.Size(275, 66);
            this.btnCoach.TabIndex = 2;
            this.btnCoach.Text = "Antrenörler";
            this.btnCoach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCoach.UseAccentColor = false;
            this.btnCoach.UseVisualStyleBackColor = true;
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
            this.btnMembershipTypes.TabIndex = 9;
            this.btnMembershipTypes.Text = "Üyeler";
            this.btnMembershipTypes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMembershipTypes.UseAccentColor = false;
            this.btnMembershipTypes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialButton btnCoach;
        private MaterialSkin.Controls.MaterialButton btnMembers;
        private MaterialSkin.Controls.MaterialButton btnExercises;
        private MaterialSkin.Controls.MaterialButton btnParticipationHistory;
        private MaterialSkin.Controls.MaterialButton btnPayments;
        private MaterialSkin.Controls.MaterialButton btnTraningLists;
        private MaterialSkin.Controls.MaterialButton btnMembershipTypes;
    }
}

