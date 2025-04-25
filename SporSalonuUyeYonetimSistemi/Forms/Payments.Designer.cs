namespace SporSalonuUyeYonetimSistemi.Forms
{
    partial class Payments
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
            this.tbFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.dtPayments = new MaterialSkin.Controls.MaterialListView();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPayments = new System.Windows.Forms.TabPage();
            this.tabController.SuspendLayout();
            this.tabPayments.SuspendLayout();
            this.SuspendLayout();
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
            this.tbFilter.TabIndex = 3;
            this.tbFilter.Text = "";
            this.tbFilter.TrailingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Filter;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // dtPayments
            // 
            this.dtPayments.AutoSizeTable = false;
            this.dtPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtPayments.Depth = 0;
            this.dtPayments.FullRowSelect = true;
            this.dtPayments.HideSelection = false;
            this.dtPayments.Location = new System.Drawing.Point(43, 96);
            this.dtPayments.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtPayments.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtPayments.MouseState = MaterialSkin.MouseState.OUT;
            this.dtPayments.Name = "dtPayments";
            this.dtPayments.OwnerDraw = true;
            this.dtPayments.Size = new System.Drawing.Size(904, 508);
            this.dtPayments.TabIndex = 2;
            this.dtPayments.UseCompatibleStateImageBehavior = false;
            this.dtPayments.View = System.Windows.Forms.View.Details;
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
            this.tabSelector.TabIndex = 4;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPayments);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(3, 50);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(998, 636);
            this.tabController.TabIndex = 5;
            // 
            // tabPayments
            // 
            this.tabPayments.Controls.Add(this.tbFilter);
            this.tabPayments.Controls.Add(this.dtPayments);
            this.tabPayments.Location = new System.Drawing.Point(4, 22);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(990, 610);
            this.tabPayments.TabIndex = 0;
            this.tabPayments.Text = "Ödemeler";
            this.tabPayments.UseVisualStyleBackColor = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Payments";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.Payments_Shown);
            this.tabController.ResumeLayout(false);
            this.tabPayments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbFilter;
        private MaterialSkin.Controls.MaterialListView dtPayments;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabPayments;
    }
}