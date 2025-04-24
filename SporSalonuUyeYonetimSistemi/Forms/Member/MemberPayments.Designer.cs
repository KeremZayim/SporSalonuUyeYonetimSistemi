namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class MemberPayments
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
            this.dtData = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // dtData
            // 
            this.dtData.AutoSizeTable = false;
            this.dtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtData.Depth = 0;
            this.dtData.FullRowSelect = true;
            this.dtData.HideSelection = false;
            this.dtData.Location = new System.Drawing.Point(38, 85);
            this.dtData.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtData.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtData.MouseState = MaterialSkin.MouseState.OUT;
            this.dtData.Name = "dtData";
            this.dtData.OwnerDraw = true;
            this.dtData.ShowGroups = false;
            this.dtData.Size = new System.Drawing.Size(683, 363);
            this.dtData.TabIndex = 0;
            this.dtData.UseCompatibleStateImageBehavior = false;
            this.dtData.View = System.Windows.Forms.View.Details;
            // 
            // MemberPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 486);
            this.Controls.Add(this.dtData);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "MemberPayments";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Load += new System.EventHandler(this.MemberPayments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView dtData;
    }
}