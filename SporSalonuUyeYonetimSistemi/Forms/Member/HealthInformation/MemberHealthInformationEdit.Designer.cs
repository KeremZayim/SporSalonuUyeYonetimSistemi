namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class MemberHealthInformationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberHealthInformationEdit));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tbMedicalConditions = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbAllergies = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbEmergencyContactName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbEmergencyContactPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(394, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(349, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 29);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(394, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(76, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Üye Sağlık Bilgileri Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMedicalConditions
            // 
            this.tbMedicalConditions.AnimateReadOnly = false;
            this.tbMedicalConditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMedicalConditions.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMedicalConditions.Depth = 0;
            this.tbMedicalConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMedicalConditions.HideSelection = true;
            this.tbMedicalConditions.Hint = "Sağlık Durumu";
            this.tbMedicalConditions.LeadingIcon = null;
            this.tbMedicalConditions.Location = new System.Drawing.Point(50, 109);
            this.tbMedicalConditions.MaxLength = 32767;
            this.tbMedicalConditions.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMedicalConditions.Name = "tbMedicalConditions";
            this.tbMedicalConditions.PasswordChar = '\0';
            this.tbMedicalConditions.PrefixSuffixText = null;
            this.tbMedicalConditions.ReadOnly = false;
            this.tbMedicalConditions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMedicalConditions.SelectedText = "";
            this.tbMedicalConditions.SelectionLength = 0;
            this.tbMedicalConditions.SelectionStart = 0;
            this.tbMedicalConditions.ShortcutsEnabled = true;
            this.tbMedicalConditions.Size = new System.Drawing.Size(300, 48);
            this.tbMedicalConditions.TabIndex = 1;
            this.tbMedicalConditions.TabStop = false;
            this.tbMedicalConditions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMedicalConditions.TrailingIcon = null;
            this.tbMedicalConditions.UseSystemPasswordChar = false;
            // 
            // tbAllergies
            // 
            this.tbAllergies.AnimateReadOnly = false;
            this.tbAllergies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbAllergies.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbAllergies.Depth = 0;
            this.tbAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAllergies.HideSelection = true;
            this.tbAllergies.Hint = "Alerjileri";
            this.tbAllergies.LeadingIcon = null;
            this.tbAllergies.Location = new System.Drawing.Point(50, 163);
            this.tbAllergies.MaxLength = 32767;
            this.tbAllergies.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAllergies.Name = "tbAllergies";
            this.tbAllergies.PasswordChar = '\0';
            this.tbAllergies.PrefixSuffixText = null;
            this.tbAllergies.ReadOnly = false;
            this.tbAllergies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAllergies.SelectedText = "";
            this.tbAllergies.SelectionLength = 0;
            this.tbAllergies.SelectionStart = 0;
            this.tbAllergies.ShortcutsEnabled = true;
            this.tbAllergies.Size = new System.Drawing.Size(300, 48);
            this.tbAllergies.TabIndex = 1;
            this.tbAllergies.TabStop = false;
            this.tbAllergies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbAllergies.TrailingIcon = null;
            this.tbAllergies.UseSystemPasswordChar = false;
            // 
            // tbEmergencyContactName
            // 
            this.tbEmergencyContactName.AnimateReadOnly = false;
            this.tbEmergencyContactName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEmergencyContactName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmergencyContactName.Depth = 0;
            this.tbEmergencyContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmergencyContactName.HideSelection = true;
            this.tbEmergencyContactName.Hint = "Acil Durum Kişi Adı";
            this.tbEmergencyContactName.LeadingIcon = null;
            this.tbEmergencyContactName.Location = new System.Drawing.Point(50, 217);
            this.tbEmergencyContactName.MaxLength = 32767;
            this.tbEmergencyContactName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmergencyContactName.Name = "tbEmergencyContactName";
            this.tbEmergencyContactName.PasswordChar = '\0';
            this.tbEmergencyContactName.PrefixSuffixText = null;
            this.tbEmergencyContactName.ReadOnly = false;
            this.tbEmergencyContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmergencyContactName.SelectedText = "";
            this.tbEmergencyContactName.SelectionLength = 0;
            this.tbEmergencyContactName.SelectionStart = 0;
            this.tbEmergencyContactName.ShortcutsEnabled = true;
            this.tbEmergencyContactName.Size = new System.Drawing.Size(300, 48);
            this.tbEmergencyContactName.TabIndex = 1;
            this.tbEmergencyContactName.TabStop = false;
            this.tbEmergencyContactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmergencyContactName.TrailingIcon = null;
            this.tbEmergencyContactName.UseSystemPasswordChar = false;
            // 
            // tbEmergencyContactPhone
            // 
            this.tbEmergencyContactPhone.AnimateReadOnly = false;
            this.tbEmergencyContactPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbEmergencyContactPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmergencyContactPhone.Depth = 0;
            this.tbEmergencyContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmergencyContactPhone.HideSelection = true;
            this.tbEmergencyContactPhone.Hint = "Acil Durum Telefon Numarası";
            this.tbEmergencyContactPhone.LeadingIcon = null;
            this.tbEmergencyContactPhone.Location = new System.Drawing.Point(50, 271);
            this.tbEmergencyContactPhone.MaxLength = 32767;
            this.tbEmergencyContactPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmergencyContactPhone.Name = "tbEmergencyContactPhone";
            this.tbEmergencyContactPhone.PasswordChar = '\0';
            this.tbEmergencyContactPhone.PrefixSuffixText = null;
            this.tbEmergencyContactPhone.ReadOnly = false;
            this.tbEmergencyContactPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmergencyContactPhone.SelectedText = "";
            this.tbEmergencyContactPhone.SelectionLength = 0;
            this.tbEmergencyContactPhone.SelectionStart = 0;
            this.tbEmergencyContactPhone.ShortcutsEnabled = true;
            this.tbEmergencyContactPhone.Size = new System.Drawing.Size(300, 48);
            this.tbEmergencyContactPhone.TabIndex = 1;
            this.tbEmergencyContactPhone.TabStop = false;
            this.tbEmergencyContactPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmergencyContactPhone.TrailingIcon = null;
            this.tbEmergencyContactPhone.UseSystemPasswordChar = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(108, 356);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(185, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Bilgileri Düzenle";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MemberHealthInformationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbEmergencyContactPhone);
            this.Controls.Add(this.tbEmergencyContactName);
            this.Controls.Add(this.tbAllergies);
            this.Controls.Add(this.tbMedicalConditions);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberHealthInformationEdit";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Sağlık Bilgileri Güncelle";
            this.Shown += new System.EventHandler(this.MemberHealthInformationEdit_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox2 tbMedicalConditions;
        private MaterialSkin.Controls.MaterialTextBox2 tbAllergies;
        private MaterialSkin.Controls.MaterialTextBox2 tbEmergencyContactName;
        private MaterialSkin.Controls.MaterialTextBox2 tbEmergencyContactPhone;
        private MaterialSkin.Controls.MaterialButton btnEdit;
    }
}

