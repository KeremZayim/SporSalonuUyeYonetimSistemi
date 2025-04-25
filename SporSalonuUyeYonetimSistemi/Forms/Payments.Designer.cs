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
            this.tbFilter.Location = new System.Drawing.Point(367, 32);
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
            this.dtPayments.Location = new System.Drawing.Point(50, 108);
            this.dtPayments.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtPayments.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtPayments.MouseState = MaterialSkin.MouseState.OUT;
            this.dtPayments.Name = "dtPayments";
            this.dtPayments.OwnerDraw = true;
            this.dtPayments.Size = new System.Drawing.Size(904, 548);
            this.dtPayments.TabIndex = 2;
            this.dtPayments.UseCompatibleStateImageBehavior = false;
            this.dtPayments.View = System.Windows.Forms.View.Details;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.dtPayments);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Payments";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.Payments_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbFilter;
        private MaterialSkin.Controls.MaterialListView dtPayments;
    }
}