namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    partial class Exercise
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
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabExercise = new System.Windows.Forms.TabPage();
            this.cbMember = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddExercise = new MaterialSkin.Controls.MaterialButton();
            this.btnEditExercise = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteExercise = new MaterialSkin.Controls.MaterialButton();
            this.dtExercise = new MaterialSkin.Controls.MaterialListView();
            this.tabController.SuspendLayout();
            this.tabExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabController;
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
            // tabController
            // 
            this.tabController.Controls.Add(this.tabExercise);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(3, 50);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(998, 636);
            this.tabController.TabIndex = 2;
            // 
            // tabExercise
            // 
            this.tabExercise.Controls.Add(this.cbMember);
            this.tabExercise.Controls.Add(this.btnAddExercise);
            this.tabExercise.Controls.Add(this.btnEditExercise);
            this.tabExercise.Controls.Add(this.btnDeleteExercise);
            this.tabExercise.Controls.Add(this.dtExercise);
            this.tabExercise.Location = new System.Drawing.Point(4, 22);
            this.tabExercise.Name = "tabExercise";
            this.tabExercise.Padding = new System.Windows.Forms.Padding(3);
            this.tabExercise.Size = new System.Drawing.Size(990, 610);
            this.tabExercise.TabIndex = 1;
            this.tabExercise.Text = "Egzersizler";
            this.tabExercise.UseVisualStyleBackColor = true;
            // 
            // cbMember
            // 
            this.cbMember.AutoResize = false;
            this.cbMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMember.Depth = 0;
            this.cbMember.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMember.DropDownHeight = 174;
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMember.DropDownWidth = 121;
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Hint = "Filtrele";
            this.cbMember.IntegralHeight = false;
            this.cbMember.ItemHeight = 43;
            this.cbMember.Location = new System.Drawing.Point(828, 111);
            this.cbMember.MaxDropDownItems = 4;
            this.cbMember.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(156, 49);
            this.cbMember.StartIndex = 0;
            this.cbMember.TabIndex = 4;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.AutoSize = false;
            this.btnAddExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddExercise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddExercise.Depth = 0;
            this.btnAddExercise.HighEmphasis = true;
            this.btnAddExercise.Icon = null;
            this.btnAddExercise.Location = new System.Drawing.Point(840, 180);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddExercise.Size = new System.Drawing.Size(133, 40);
            this.btnAddExercise.TabIndex = 3;
            this.btnAddExercise.Text = "Egzersiz Ekle";
            this.btnAddExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddExercise.UseAccentColor = false;
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.AutoSize = false;
            this.btnEditExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditExercise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditExercise.Depth = 0;
            this.btnEditExercise.Enabled = false;
            this.btnEditExercise.HighEmphasis = true;
            this.btnEditExercise.Icon = null;
            this.btnEditExercise.Location = new System.Drawing.Point(840, 232);
            this.btnEditExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditExercise.Size = new System.Drawing.Size(133, 40);
            this.btnEditExercise.TabIndex = 3;
            this.btnEditExercise.Text = "Egzersizi Düzenle";
            this.btnEditExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditExercise.UseAccentColor = false;
            this.btnEditExercise.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.AutoSize = false;
            this.btnDeleteExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExercise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteExercise.Depth = 0;
            this.btnDeleteExercise.Enabled = false;
            this.btnDeleteExercise.HighEmphasis = true;
            this.btnDeleteExercise.Icon = null;
            this.btnDeleteExercise.Location = new System.Drawing.Point(840, 284);
            this.btnDeleteExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteExercise.Size = new System.Drawing.Size(133, 40);
            this.btnDeleteExercise.TabIndex = 3;
            this.btnDeleteExercise.Text = "Egzersizi Sil";
            this.btnDeleteExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteExercise.UseAccentColor = false;
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // dtExercise
            // 
            this.dtExercise.AutoSizeTable = false;
            this.dtExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtExercise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtExercise.Depth = 0;
            this.dtExercise.FullRowSelect = true;
            this.dtExercise.HideSelection = false;
            this.dtExercise.Location = new System.Drawing.Point(6, 24);
            this.dtExercise.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtExercise.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtExercise.MouseState = MaterialSkin.MouseState.OUT;
            this.dtExercise.Name = "dtExercise";
            this.dtExercise.OwnerDraw = true;
            this.dtExercise.Size = new System.Drawing.Size(800, 550);
            this.dtExercise.TabIndex = 0;
            this.dtExercise.UseCompatibleStateImageBehavior = false;
            this.dtExercise.View = System.Windows.Forms.View.Details;
            this.dtExercise.SelectedIndexChanged += new System.EventHandler(this.dtExercise_SelectedIndexChanged);
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Exercise";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.Exercise_Shown);
            this.tabController.ResumeLayout(false);
            this.tabExercise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabExercise;
        private MaterialSkin.Controls.MaterialListView dtExercise;
        private MaterialSkin.Controls.MaterialButton btnDeleteExercise;
        private MaterialSkin.Controls.MaterialButton btnAddExercise;
        private MaterialSkin.Controls.MaterialButton btnEditExercise;
        private MaterialSkin.Controls.MaterialComboBox cbMember;
    }
}