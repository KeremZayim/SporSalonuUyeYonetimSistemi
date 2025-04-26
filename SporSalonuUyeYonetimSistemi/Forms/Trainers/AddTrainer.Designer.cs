namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    partial class AddTrainer
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
            this.tbTrainerPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTrainerSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTrainerName = new MaterialSkin.Controls.MaterialTextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.btnAddTrainer = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTrainerPhoneNumber
            // 
            this.tbTrainerPhoneNumber.AnimateReadOnly = false;
            this.tbTrainerPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrainerPhoneNumber.Depth = 0;
            this.tbTrainerPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrainerPhoneNumber.Hint = "0(5xx xxx xx xx)";
            this.tbTrainerPhoneNumber.LeadingIcon = null;
            this.tbTrainerPhoneNumber.Location = new System.Drawing.Point(72, 225);
            this.tbTrainerPhoneNumber.MaxLength = 11;
            this.tbTrainerPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrainerPhoneNumber.Multiline = false;
            this.tbTrainerPhoneNumber.Name = "tbTrainerPhoneNumber";
            this.tbTrainerPhoneNumber.Size = new System.Drawing.Size(257, 50);
            this.tbTrainerPhoneNumber.TabIndex = 3;
            this.tbTrainerPhoneNumber.Text = "";
            this.tbTrainerPhoneNumber.TrailingIcon = global::SporSalonuUyeYonetimSistemi.Properties.Resources.Phone;
            // 
            // tbTrainerSurname
            // 
            this.tbTrainerSurname.AnimateReadOnly = false;
            this.tbTrainerSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrainerSurname.Depth = 0;
            this.tbTrainerSurname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrainerSurname.Hint = "Antrenör Soyadı";
            this.tbTrainerSurname.LeadingIcon = null;
            this.tbTrainerSurname.Location = new System.Drawing.Point(72, 169);
            this.tbTrainerSurname.MaxLength = 50;
            this.tbTrainerSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrainerSurname.Multiline = false;
            this.tbTrainerSurname.Name = "tbTrainerSurname";
            this.tbTrainerSurname.Size = new System.Drawing.Size(257, 50);
            this.tbTrainerSurname.TabIndex = 2;
            this.tbTrainerSurname.Text = "";
            this.tbTrainerSurname.TrailingIcon = null;
            // 
            // tbTrainerName
            // 
            this.tbTrainerName.AnimateReadOnly = false;
            this.tbTrainerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTrainerName.Depth = 0;
            this.tbTrainerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrainerName.Hint = "Antrenör Adı";
            this.tbTrainerName.LeadingIcon = null;
            this.tbTrainerName.Location = new System.Drawing.Point(72, 113);
            this.tbTrainerName.MaxLength = 50;
            this.tbTrainerName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrainerName.Multiline = false;
            this.tbTrainerName.Name = "tbTrainerName";
            this.tbTrainerName.Size = new System.Drawing.Size(257, 50);
            this.tbTrainerName.TabIndex = 1;
            this.tbTrainerName.Text = "";
            this.tbTrainerName.TrailingIcon = null;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnExitForm);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(394, 31);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(50, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.Location = new System.Drawing.Point(349, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(45, 31);
            this.btnExitForm.TabIndex = 0;
            this.btnExitForm.Text = "X";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.AutoSize = false;
            this.btnAddTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTrainer.Depth = 0;
            this.btnAddTrainer.HighEmphasis = true;
            this.btnAddTrainer.Icon = null;
            this.btnAddTrainer.Location = new System.Drawing.Point(118, 313);
            this.btnAddTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTrainer.Size = new System.Drawing.Size(165, 44);
            this.btnAddTrainer.TabIndex = 5;
            this.btnAddTrainer.Text = "Antrenörü Ekle";
            this.btnAddTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTrainer.UseAccentColor = false;
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(349, 1);
            this.pnlTitleSeperator.TabIndex = 9;
            // 
            // AddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.tbTrainerPhoneNumber);
            this.Controls.Add(this.tbTrainerSurname);
            this.Controls.Add(this.tbTrainerName);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "AddTrainer";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Load += new System.EventHandler(this.AddTrainer_Load);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tbTrainerPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox tbTrainerSurname;
        private MaterialSkin.Controls.MaterialTextBox tbTrainerName;
        private System.Windows.Forms.Panel pnlTitle;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitForm;
        private MaterialSkin.Controls.MaterialButton btnAddTrainer;
        private System.Windows.Forms.Panel pnlTitleSeperator;
    }
}