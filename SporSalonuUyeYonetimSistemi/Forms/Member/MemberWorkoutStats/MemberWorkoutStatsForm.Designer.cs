namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutStats
{
    partial class MemberWorkoutStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberWorkoutStatsForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dtMemberWorkoutStats = new MaterialSkin.Controls.MaterialListView();
            this.btnAddWorkoutStats = new MaterialSkin.Controls.MaterialButton();
            this.btnEditWorkoutStats = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteWorkoutStats = new MaterialSkin.Controls.MaterialButton();
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
            this.pnlTitle.Size = new System.Drawing.Size(1144, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1099, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 4;
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(1144, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(383, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Üye Antrenman İstatistikleri";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtMemberWorkoutStats
            // 
            this.dtMemberWorkoutStats.AutoSizeTable = false;
            this.dtMemberWorkoutStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtMemberWorkoutStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMemberWorkoutStats.Depth = 0;
            this.dtMemberWorkoutStats.FullRowSelect = true;
            this.dtMemberWorkoutStats.HideSelection = false;
            this.dtMemberWorkoutStats.Location = new System.Drawing.Point(25, 60);
            this.dtMemberWorkoutStats.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtMemberWorkoutStats.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtMemberWorkoutStats.MouseState = MaterialSkin.MouseState.OUT;
            this.dtMemberWorkoutStats.Name = "dtMemberWorkoutStats";
            this.dtMemberWorkoutStats.OwnerDraw = true;
            this.dtMemberWorkoutStats.Size = new System.Drawing.Size(902, 490);
            this.dtMemberWorkoutStats.TabIndex = 1;
            this.dtMemberWorkoutStats.UseCompatibleStateImageBehavior = false;
            this.dtMemberWorkoutStats.View = System.Windows.Forms.View.Details;
            this.dtMemberWorkoutStats.SelectedIndexChanged += new System.EventHandler(this.dtMemberWorkoutStats_SelectedIndexChanged);
            // 
            // btnAddWorkoutStats
            // 
            this.btnAddWorkoutStats.AutoSize = false;
            this.btnAddWorkoutStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWorkoutStats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddWorkoutStats.Depth = 0;
            this.btnAddWorkoutStats.HighEmphasis = true;
            this.btnAddWorkoutStats.Icon = null;
            this.btnAddWorkoutStats.Location = new System.Drawing.Point(961, 225);
            this.btnAddWorkoutStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddWorkoutStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWorkoutStats.Name = "btnAddWorkoutStats";
            this.btnAddWorkoutStats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddWorkoutStats.Size = new System.Drawing.Size(140, 40);
            this.btnAddWorkoutStats.TabIndex = 1;
            this.btnAddWorkoutStats.Text = "Ekle";
            this.btnAddWorkoutStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddWorkoutStats.UseAccentColor = false;
            this.btnAddWorkoutStats.UseVisualStyleBackColor = true;
            this.btnAddWorkoutStats.Click += new System.EventHandler(this.btnAddWorkoutList_Click);
            // 
            // btnEditWorkoutStats
            // 
            this.btnEditWorkoutStats.AutoSize = false;
            this.btnEditWorkoutStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditWorkoutStats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditWorkoutStats.Depth = 0;
            this.btnEditWorkoutStats.Enabled = false;
            this.btnEditWorkoutStats.HighEmphasis = true;
            this.btnEditWorkoutStats.Icon = null;
            this.btnEditWorkoutStats.Location = new System.Drawing.Point(961, 277);
            this.btnEditWorkoutStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditWorkoutStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorkoutStats.Name = "btnEditWorkoutStats";
            this.btnEditWorkoutStats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditWorkoutStats.Size = new System.Drawing.Size(140, 40);
            this.btnEditWorkoutStats.TabIndex = 2;
            this.btnEditWorkoutStats.Text = "Düzenle";
            this.btnEditWorkoutStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditWorkoutStats.UseAccentColor = false;
            this.btnEditWorkoutStats.UseVisualStyleBackColor = true;
            this.btnEditWorkoutStats.Click += new System.EventHandler(this.btnEditWorkoutStats_Click);
            // 
            // btnDeleteWorkoutStats
            // 
            this.btnDeleteWorkoutStats.AutoSize = false;
            this.btnDeleteWorkoutStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteWorkoutStats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteWorkoutStats.Depth = 0;
            this.btnDeleteWorkoutStats.Enabled = false;
            this.btnDeleteWorkoutStats.HighEmphasis = true;
            this.btnDeleteWorkoutStats.Icon = null;
            this.btnDeleteWorkoutStats.Location = new System.Drawing.Point(961, 329);
            this.btnDeleteWorkoutStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteWorkoutStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteWorkoutStats.Name = "btnDeleteWorkoutStats";
            this.btnDeleteWorkoutStats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteWorkoutStats.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteWorkoutStats.TabIndex = 3;
            this.btnDeleteWorkoutStats.Text = "Sil";
            this.btnDeleteWorkoutStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteWorkoutStats.UseAccentColor = false;
            this.btnDeleteWorkoutStats.UseVisualStyleBackColor = true;
            this.btnDeleteWorkoutStats.Click += new System.EventHandler(this.btnDeleteWorkoutStats_Click);
            // 
            // MemberWorkoutStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.btnAddWorkoutStats);
            this.Controls.Add(this.btnEditWorkoutStats);
            this.Controls.Add(this.btnDeleteWorkoutStats);
            this.Controls.Add(this.dtMemberWorkoutStats);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberWorkoutStatsForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Antrenman İstatistikleri";
            this.Shown += new System.EventHandler(this.MemberWorkoutStatsForm_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialListView dtMemberWorkoutStats;
        private MaterialSkin.Controls.MaterialButton btnAddWorkoutStats;
        private MaterialSkin.Controls.MaterialButton btnEditWorkoutStats;
        private MaterialSkin.Controls.MaterialButton btnDeleteWorkoutStats;
    }
}

