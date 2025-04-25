namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    partial class TrainersPage
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
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPages = new MaterialSkin.Controls.MaterialTabControl();
            this.tabTrainers = new System.Windows.Forms.TabPage();
            this.btnStudents = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteTrainer = new MaterialSkin.Controls.MaterialButton();
            this.btnEditTrainer = new MaterialSkin.Controls.MaterialButton();
            this.btnAddTrainer = new MaterialSkin.Controls.MaterialButton();
            this.dtTrainerInfo = new MaterialSkin.Controls.MaterialListView();
            this.trainer_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainer_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainer_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPages.SuspendLayout();
            this.tabTrainers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabPages;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(3, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(998, 50);
            this.tabSelector.TabIndex = 1;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabTrainers);
            this.tabPages.Depth = 0;
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(3, 50);
            this.tabPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabPages.Multiline = true;
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(998, 636);
            this.tabPages.TabIndex = 2;
            // 
            // tabTrainers
            // 
            this.tabTrainers.Controls.Add(this.btnStudents);
            this.tabTrainers.Controls.Add(this.btnDeleteTrainer);
            this.tabTrainers.Controls.Add(this.btnEditTrainer);
            this.tabTrainers.Controls.Add(this.btnAddTrainer);
            this.tabTrainers.Controls.Add(this.dtTrainerInfo);
            this.tabTrainers.Location = new System.Drawing.Point(4, 22);
            this.tabTrainers.Name = "tabTrainers";
            this.tabTrainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainers.Size = new System.Drawing.Size(990, 610);
            this.tabTrainers.TabIndex = 0;
            this.tabTrainers.Text = "Antrenörler";
            this.tabTrainers.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.AutoSize = false;
            this.btnStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStudents.Depth = 0;
            this.btnStudents.Enabled = false;
            this.btnStudents.HighEmphasis = true;
            this.btnStudents.Icon = null;
            this.btnStudents.Location = new System.Drawing.Point(828, 246);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStudents.Size = new System.Drawing.Size(142, 44);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "Öğrencileri";
            this.btnStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStudents.UseAccentColor = false;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.AutoSize = false;
            this.btnDeleteTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteTrainer.Depth = 0;
            this.btnDeleteTrainer.Enabled = false;
            this.btnDeleteTrainer.HighEmphasis = true;
            this.btnDeleteTrainer.Icon = null;
            this.btnDeleteTrainer.Location = new System.Drawing.Point(828, 190);
            this.btnDeleteTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteTrainer.TabIndex = 6;
            this.btnDeleteTrainer.Text = "Antrenörü Sil";
            this.btnDeleteTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteTrainer.UseAccentColor = false;
            this.btnDeleteTrainer.UseVisualStyleBackColor = true;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click);
            // 
            // btnEditTrainer
            // 
            this.btnEditTrainer.AutoSize = false;
            this.btnEditTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditTrainer.Depth = 0;
            this.btnEditTrainer.Enabled = false;
            this.btnEditTrainer.HighEmphasis = true;
            this.btnEditTrainer.Icon = null;
            this.btnEditTrainer.Location = new System.Drawing.Point(828, 134);
            this.btnEditTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditTrainer.Name = "btnEditTrainer";
            this.btnEditTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnEditTrainer.TabIndex = 6;
            this.btnEditTrainer.Text = "Antrenörü Düzenle";
            this.btnEditTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditTrainer.UseAccentColor = false;
            this.btnEditTrainer.UseVisualStyleBackColor = true;
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.AutoSize = false;
            this.btnAddTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTrainer.Depth = 0;
            this.btnAddTrainer.HighEmphasis = true;
            this.btnAddTrainer.Icon = null;
            this.btnAddTrainer.Location = new System.Drawing.Point(828, 78);
            this.btnAddTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnAddTrainer.TabIndex = 6;
            this.btnAddTrainer.Text = "Antrenör Ekle";
            this.btnAddTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTrainer.UseAccentColor = false;
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // dtTrainerInfo
            // 
            this.dtTrainerInfo.AutoSizeTable = false;
            this.dtTrainerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtTrainerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtTrainerInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trainer_id,
            this.trainer_name,
            this.trainer_surname,
            this.phone_number});
            this.dtTrainerInfo.Depth = 0;
            this.dtTrainerInfo.FullRowSelect = true;
            this.dtTrainerInfo.HideSelection = false;
            this.dtTrainerInfo.Location = new System.Drawing.Point(6, 24);
            this.dtTrainerInfo.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtTrainerInfo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtTrainerInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.dtTrainerInfo.MultiSelect = false;
            this.dtTrainerInfo.Name = "dtTrainerInfo";
            this.dtTrainerInfo.OwnerDraw = true;
            this.dtTrainerInfo.ShowGroups = false;
            this.dtTrainerInfo.Size = new System.Drawing.Size(800, 550);
            this.dtTrainerInfo.TabIndex = 1;
            this.dtTrainerInfo.UseCompatibleStateImageBehavior = false;
            this.dtTrainerInfo.View = System.Windows.Forms.View.Details;
            this.dtTrainerInfo.SelectedIndexChanged += new System.EventHandler(this.dtTrainerInfo_SelectedIndexChanged);
            // 
            // trainer_id
            // 
            this.trainer_id.Text = "Antrenör ID";
            this.trainer_id.Width = 120;
            // 
            // trainer_name
            // 
            this.trainer_name.Text = "Ad";
            this.trainer_name.Width = 150;
            // 
            // trainer_surname
            // 
            this.trainer_surname.Text = "Soyad";
            this.trainer_surname.Width = 150;
            // 
            // phone_number
            // 
            this.phone_number.Text = "Telefon No";
            this.phone_number.Width = 120;
            // 
            // TrainersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "TrainersPage";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.TrainersPage_Shown);
            this.tabPages.ResumeLayout(false);
            this.tabTrainers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabPages;
        private System.Windows.Forms.TabPage tabTrainers;
        private MaterialSkin.Controls.MaterialListView dtTrainerInfo;
        private System.Windows.Forms.ColumnHeader trainer_id;
        private System.Windows.Forms.ColumnHeader trainer_name;
        private System.Windows.Forms.ColumnHeader trainer_surname;
        private System.Windows.Forms.ColumnHeader phone_number;
        private MaterialSkin.Controls.MaterialButton btnDeleteTrainer;
        private MaterialSkin.Controls.MaterialButton btnEditTrainer;
        private MaterialSkin.Controls.MaterialButton btnAddTrainer;
        private MaterialSkin.Controls.MaterialButton btnStudents;
    }
}