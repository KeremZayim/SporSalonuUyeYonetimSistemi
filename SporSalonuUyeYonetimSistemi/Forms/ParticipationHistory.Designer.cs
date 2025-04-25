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
            this.dtParticipationHistory.Location = new System.Drawing.Point(50, 108);
            this.dtParticipationHistory.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtParticipationHistory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtParticipationHistory.MouseState = MaterialSkin.MouseState.OUT;
            this.dtParticipationHistory.Name = "dtParticipationHistory";
            this.dtParticipationHistory.OwnerDraw = true;
            this.dtParticipationHistory.Size = new System.Drawing.Size(904, 548);
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
            this.tbFilter.Location = new System.Drawing.Point(367, 32);
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
            // ParticipationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.dtParticipationHistory);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ParticipationHistory";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.ParticipationHistory_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView dtParticipationHistory;
        private MaterialSkin.Controls.MaterialTextBox tbFilter;
    }
}