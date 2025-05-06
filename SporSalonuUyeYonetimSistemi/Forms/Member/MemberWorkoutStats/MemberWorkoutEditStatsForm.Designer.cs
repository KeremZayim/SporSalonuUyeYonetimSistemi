namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutStats
{
    partial class MemberWorkoutEditStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberWorkoutEditStatsForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditWorkoutStats = new MaterialSkin.Controls.MaterialButton();
            this.tbGoal = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMuscleMass = new MaterialSkin.Controls.MaterialTextBox();
            this.tbBodyFatPercentage = new MaterialSkin.Controls.MaterialTextBox();
            this.tbWeight = new MaterialSkin.Controls.MaterialTextBox();
            this.tbHeight = new MaterialSkin.Controls.MaterialTextBox();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(354, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(309, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 29);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(354, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(69, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 30);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Antrenman İstatistiğini Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditWorkoutStats
            // 
            this.btnEditWorkoutStats.AutoSize = false;
            this.btnEditWorkoutStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditWorkoutStats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditWorkoutStats.Depth = 0;
            this.btnEditWorkoutStats.HighEmphasis = true;
            this.btnEditWorkoutStats.Icon = null;
            this.btnEditWorkoutStats.Location = new System.Drawing.Point(110, 375);
            this.btnEditWorkoutStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditWorkoutStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorkoutStats.Name = "btnEditWorkoutStats";
            this.btnEditWorkoutStats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditWorkoutStats.Size = new System.Drawing.Size(140, 40);
            this.btnEditWorkoutStats.TabIndex = 6;
            this.btnEditWorkoutStats.Text = "Düzenle";
            this.btnEditWorkoutStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditWorkoutStats.UseAccentColor = false;
            this.btnEditWorkoutStats.UseVisualStyleBackColor = true;
            this.btnEditWorkoutStats.Click += new System.EventHandler(this.btnEditWorkoutStats_Click);
            // 
            // tbGoal
            // 
            this.tbGoal.AnimateReadOnly = false;
            this.tbGoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGoal.Depth = 0;
            this.tbGoal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGoal.Hint = "Hedef ";
            this.tbGoal.LeadingIcon = null;
            this.tbGoal.Location = new System.Drawing.Point(77, 304);
            this.tbGoal.MaxLength = 50;
            this.tbGoal.MouseState = MaterialSkin.MouseState.OUT;
            this.tbGoal.Multiline = false;
            this.tbGoal.Name = "tbGoal";
            this.tbGoal.Size = new System.Drawing.Size(206, 50);
            this.tbGoal.TabIndex = 5;
            this.tbGoal.Text = "";
            this.tbGoal.TrailingIcon = null;
            // 
            // tbMuscleMass
            // 
            this.tbMuscleMass.AnimateReadOnly = false;
            this.tbMuscleMass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMuscleMass.Depth = 0;
            this.tbMuscleMass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMuscleMass.Hint = "Kas Kütlesi";
            this.tbMuscleMass.LeadingIcon = null;
            this.tbMuscleMass.Location = new System.Drawing.Point(77, 248);
            this.tbMuscleMass.MaxLength = 50;
            this.tbMuscleMass.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMuscleMass.Multiline = false;
            this.tbMuscleMass.Name = "tbMuscleMass";
            this.tbMuscleMass.Size = new System.Drawing.Size(206, 50);
            this.tbMuscleMass.TabIndex = 4;
            this.tbMuscleMass.Text = "";
            this.tbMuscleMass.TrailingIcon = null;
            // 
            // tbBodyFatPercentage
            // 
            this.tbBodyFatPercentage.AnimateReadOnly = false;
            this.tbBodyFatPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBodyFatPercentage.Depth = 0;
            this.tbBodyFatPercentage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbBodyFatPercentage.Hint = "Yağ Oranı";
            this.tbBodyFatPercentage.LeadingIcon = null;
            this.tbBodyFatPercentage.Location = new System.Drawing.Point(77, 192);
            this.tbBodyFatPercentage.MaxLength = 50;
            this.tbBodyFatPercentage.MouseState = MaterialSkin.MouseState.OUT;
            this.tbBodyFatPercentage.Multiline = false;
            this.tbBodyFatPercentage.Name = "tbBodyFatPercentage";
            this.tbBodyFatPercentage.Size = new System.Drawing.Size(206, 50);
            this.tbBodyFatPercentage.TabIndex = 3;
            this.tbBodyFatPercentage.Text = "";
            this.tbBodyFatPercentage.TrailingIcon = null;
            // 
            // tbWeight
            // 
            this.tbWeight.AnimateReadOnly = false;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeight.Depth = 0;
            this.tbWeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWeight.Hint = "Kilo (kg)";
            this.tbWeight.LeadingIcon = null;
            this.tbWeight.Location = new System.Drawing.Point(77, 136);
            this.tbWeight.MaxLength = 50;
            this.tbWeight.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWeight.Multiline = false;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(206, 50);
            this.tbWeight.TabIndex = 2;
            this.tbWeight.Text = "";
            this.tbWeight.TrailingIcon = null;
            // 
            // tbHeight
            // 
            this.tbHeight.AnimateReadOnly = false;
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeight.Depth = 0;
            this.tbHeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbHeight.Hint = "Boy (cm)";
            this.tbHeight.LeadingIcon = null;
            this.tbHeight.Location = new System.Drawing.Point(77, 80);
            this.tbHeight.MaxLength = 50;
            this.tbHeight.MouseState = MaterialSkin.MouseState.OUT;
            this.tbHeight.Multiline = false;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(206, 50);
            this.tbHeight.TabIndex = 1;
            this.tbHeight.Text = "";
            this.tbHeight.TrailingIcon = null;
            // 
            // MemberWorkoutEditStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btnEditWorkoutStats);
            this.Controls.Add(this.tbGoal);
            this.Controls.Add(this.tbMuscleMass);
            this.Controls.Add(this.tbBodyFatPercentage);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberWorkoutEditStatsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman İstatistiğini Düzenle";
            this.Shown += new System.EventHandler(this.MemberWorkoutEditStatsForm_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnEditWorkoutStats;
        private MaterialSkin.Controls.MaterialTextBox tbGoal;
        private MaterialSkin.Controls.MaterialTextBox tbMuscleMass;
        private MaterialSkin.Controls.MaterialTextBox tbBodyFatPercentage;
        private MaterialSkin.Controls.MaterialTextBox tbWeight;
        private MaterialSkin.Controls.MaterialTextBox tbHeight;
    }
}

