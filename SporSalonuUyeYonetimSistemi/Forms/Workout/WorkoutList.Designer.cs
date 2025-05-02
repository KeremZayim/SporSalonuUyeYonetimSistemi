namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    partial class WorkoutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutList));
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.btnEditWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.dtWorkoutList = new MaterialSkin.Controls.MaterialListView();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabController;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(0, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(1004, 50);
            this.tabSelector.TabIndex = 2;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 50);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1004, 639);
            this.tabController.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddWorkoutList);
            this.tabPage1.Controls.Add(this.btnEditWorkoutList);
            this.tabPage1.Controls.Add(this.btnDeleteWorkoutList);
            this.tabPage1.Controls.Add(this.dtWorkoutList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Antrenman Listelsi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddWorkoutList
            // 
            this.btnAddWorkoutList.AutoSize = false;
            this.btnAddWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddWorkoutList.Depth = 0;
            this.btnAddWorkoutList.HighEmphasis = true;
            this.btnAddWorkoutList.Icon = null;
            this.btnAddWorkoutList.Location = new System.Drawing.Point(838, 203);
            this.btnAddWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWorkoutList.Name = "btnAddWorkoutList";
            this.btnAddWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnAddWorkoutList.TabIndex = 7;
            this.btnAddWorkoutList.Text = "Antrenman Listesi Ekle";
            this.btnAddWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddWorkoutList.UseAccentColor = false;
            this.btnAddWorkoutList.UseVisualStyleBackColor = true;
            this.btnAddWorkoutList.Click += new System.EventHandler(this.btnAddWorkoutList_Click);
            // 
            // btnEditWorkoutList
            // 
            this.btnEditWorkoutList.AutoSize = false;
            this.btnEditWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditWorkoutList.Depth = 0;
            this.btnEditWorkoutList.Enabled = false;
            this.btnEditWorkoutList.HighEmphasis = true;
            this.btnEditWorkoutList.Icon = null;
            this.btnEditWorkoutList.Location = new System.Drawing.Point(838, 255);
            this.btnEditWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorkoutList.Name = "btnEditWorkoutList";
            this.btnEditWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnEditWorkoutList.TabIndex = 8;
            this.btnEditWorkoutList.Text = "Antrenman Listesini Düzenle";
            this.btnEditWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditWorkoutList.UseAccentColor = false;
            this.btnEditWorkoutList.UseVisualStyleBackColor = true;
            this.btnEditWorkoutList.Click += new System.EventHandler(this.btnEditWorkoutList_Click);
            // 
            // btnDeleteWorkoutList
            // 
            this.btnDeleteWorkoutList.AutoSize = false;
            this.btnDeleteWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteWorkoutList.Depth = 0;
            this.btnDeleteWorkoutList.Enabled = false;
            this.btnDeleteWorkoutList.HighEmphasis = true;
            this.btnDeleteWorkoutList.Icon = null;
            this.btnDeleteWorkoutList.Location = new System.Drawing.Point(838, 307);
            this.btnDeleteWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteWorkoutList.Name = "btnDeleteWorkoutList";
            this.btnDeleteWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnDeleteWorkoutList.TabIndex = 9;
            this.btnDeleteWorkoutList.Text = "Antrenman Listesini Sil";
            this.btnDeleteWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteWorkoutList.UseAccentColor = false;
            this.btnDeleteWorkoutList.UseVisualStyleBackColor = true;
            this.btnDeleteWorkoutList.Click += new System.EventHandler(this.btnDeleteWorkoutList_Click);
            // 
            // dtWorkoutList
            // 
            this.dtWorkoutList.AutoSizeTable = false;
            this.dtWorkoutList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtWorkoutList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtWorkoutList.Depth = 0;
            this.dtWorkoutList.FullRowSelect = true;
            this.dtWorkoutList.HideSelection = false;
            this.dtWorkoutList.Location = new System.Drawing.Point(6, 24);
            this.dtWorkoutList.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtWorkoutList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtWorkoutList.MouseState = MaterialSkin.MouseState.OUT;
            this.dtWorkoutList.MultiSelect = false;
            this.dtWorkoutList.Name = "dtWorkoutList";
            this.dtWorkoutList.OwnerDraw = true;
            this.dtWorkoutList.Size = new System.Drawing.Size(800, 550);
            this.dtWorkoutList.TabIndex = 2;
            this.dtWorkoutList.UseCompatibleStateImageBehavior = false;
            this.dtWorkoutList.View = System.Windows.Forms.View.Details;
            this.dtWorkoutList.SelectedIndexChanged += new System.EventHandler(this.dtWorkoutList_SelectedIndexChanged);
            // 
            // WorkoutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.WorkoutList_Shown);
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialListView dtWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnAddWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnEditWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnDeleteWorkoutList;
    }
}