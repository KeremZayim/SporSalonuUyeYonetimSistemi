namespace SporSalonuUyeYonetimSistemi.Forms
{
    partial class ParticipationHistory
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
            this.dtParticipationHistory = new MaterialSkin.Controls.MaterialListView();
            this.tbFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtParticipationHistory
            // 
            this.dtParticipationHistory.AutoSizeTable = false;
            this.dtParticipationHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtParticipationHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtParticipationHistory.Depth = 0;
            this.dtParticipationHistory.FullRowSelect = true;
            this.dtParticipationHistory.HideSelection = false;
            this.dtParticipationHistory.Location = new System.Drawing.Point(43, 96);
            this.dtParticipationHistory.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtParticipationHistory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtParticipationHistory.MouseState = MaterialSkin.MouseState.OUT;
            this.dtParticipationHistory.Name = "dtParticipationHistory";
            this.dtParticipationHistory.OwnerDraw = true;
            this.dtParticipationHistory.Size = new System.Drawing.Size(904, 508);
            this.dtParticipationHistory.TabIndex = 0;
            this.dtParticipationHistory.UseCompatibleStateImageBehavior = false;
            this.dtParticipationHistory.View = System.Windows.Forms.View.Details;
            // 
            // tbFilter
            // 
            this.tbFilter.AnimateReadOnly = false;
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilter.Depth = 0;
            this.tbFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFilter.Hint = "Filtrele";
            this.tbFilter.LeadingIcon = null;
            this.tbFilter.Location = new System.Drawing.Point(360, 22);
            this.tbFilter.MaxLength = 50;
            this.tbFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFilter.Multiline = false;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(270, 50);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.Text = "";
            this.tbFilter.TrailingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Filter;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
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
            this.tabSelector.TabIndex = 5;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(3, 50);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(998, 636);
            this.tabController.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtParticipationHistory);
            this.tabPage1.Controls.Add(this.tbFilter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş - Çıkışlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ParticipationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ParticipationHistory";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.ParticipationHistory_Shown);
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView dtParticipationHistory;
        private MaterialSkin.Controls.MaterialTextBox tbFilter;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
    }
}