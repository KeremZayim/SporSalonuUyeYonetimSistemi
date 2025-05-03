namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    partial class EditTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrainer));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.tbTrainerPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTrainerSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTrainerName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEditTrainer = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTitle.TabIndex = 5;
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(349, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(35, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Antrenör Düzenle";
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
            this.tbTrainerPhoneNumber.TabIndex = 8;
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
            this.tbTrainerSurname.TabIndex = 7;
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
            this.tbTrainerName.TabIndex = 6;
            this.tbTrainerName.Text = "";
            this.tbTrainerName.TrailingIcon = null;
            // 
            // btnEditTrainer
            // 
            this.btnEditTrainer.AutoSize = false;
            this.btnEditTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditTrainer.Depth = 0;
            this.btnEditTrainer.HighEmphasis = true;
            this.btnEditTrainer.Icon = null;
            this.btnEditTrainer.Location = new System.Drawing.Point(118, 313);
            this.btnEditTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditTrainer.Name = "btnEditTrainer";
            this.btnEditTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditTrainer.Size = new System.Drawing.Size(165, 44);
            this.btnEditTrainer.TabIndex = 9;
            this.btnEditTrainer.Text = "Antrenörü Düzenle";
            this.btnEditTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditTrainer.UseAccentColor = false;
            this.btnEditTrainer.UseVisualStyleBackColor = true;
            this.btnEditTrainer.Click += new System.EventHandler(this.btnEditTrainer_Click);
            // 
            // EditTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnEditTrainer);
            this.Controls.Add(this.tbTrainerPhoneNumber);
            this.Controls.Add(this.tbTrainerSurname);
            this.Controls.Add(this.tbTrainerName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTrainer";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenör Düzenle";
            this.Shown += new System.EventHandler(this.EditTrainer_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitForm;
        private MaterialSkin.Controls.MaterialTextBox tbTrainerPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox tbTrainerSurname;
        private MaterialSkin.Controls.MaterialTextBox tbTrainerName;
        private MaterialSkin.Controls.MaterialButton btnEditTrainer;
    }
}