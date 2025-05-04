namespace SporSalonuUyeYonetimSistemi.Forms
{
    partial class EditMember
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tbEmergencyContactPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEmergencyContactName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbAllergies = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMedicalConditions = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditMember = new MaterialSkin.Controls.MaterialButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbMembershipType = new MaterialSkin.Controls.MaterialComboBox();
            this.tbMemberPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMemberSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMemberName = new MaterialSkin.Controls.MaterialTextBox();
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
            this.pnlTitle.Size = new System.Drawing.Size(1094, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1049, 0);
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(1094, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(433, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Üye Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmergencyContactPhone
            // 
            this.tbEmergencyContactPhone.AnimateReadOnly = false;
            this.tbEmergencyContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmergencyContactPhone.Depth = 0;
            this.tbEmergencyContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmergencyContactPhone.Hint = "Acil Durum Telefon Numarası";
            this.tbEmergencyContactPhone.LeadingIcon = null;
            this.tbEmergencyContactPhone.Location = new System.Drawing.Point(399, 225);
            this.tbEmergencyContactPhone.MaxLength = 50;
            this.tbEmergencyContactPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmergencyContactPhone.Multiline = false;
            this.tbEmergencyContactPhone.Name = "tbEmergencyContactPhone";
            this.tbEmergencyContactPhone.Size = new System.Drawing.Size(300, 50);
            this.tbEmergencyContactPhone.TabIndex = 28;
            this.tbEmergencyContactPhone.Text = "";
            this.tbEmergencyContactPhone.TrailingIcon = null;
            // 
            // tbEmergencyContactName
            // 
            this.tbEmergencyContactName.AnimateReadOnly = false;
            this.tbEmergencyContactName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmergencyContactName.Depth = 0;
            this.tbEmergencyContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEmergencyContactName.Hint = "Acil Durum Kişi Adı";
            this.tbEmergencyContactName.LeadingIcon = null;
            this.tbEmergencyContactName.Location = new System.Drawing.Point(399, 169);
            this.tbEmergencyContactName.MaxLength = 50;
            this.tbEmergencyContactName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEmergencyContactName.Multiline = false;
            this.tbEmergencyContactName.Name = "tbEmergencyContactName";
            this.tbEmergencyContactName.Size = new System.Drawing.Size(300, 50);
            this.tbEmergencyContactName.TabIndex = 27;
            this.tbEmergencyContactName.Text = "";
            this.tbEmergencyContactName.TrailingIcon = null;
            // 
            // tbAllergies
            // 
            this.tbAllergies.AnimateReadOnly = false;
            this.tbAllergies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAllergies.Depth = 0;
            this.tbAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAllergies.Hint = "Alerjiler";
            this.tbAllergies.LeadingIcon = null;
            this.tbAllergies.Location = new System.Drawing.Point(399, 113);
            this.tbAllergies.MaxLength = 50;
            this.tbAllergies.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAllergies.Multiline = false;
            this.tbAllergies.Name = "tbAllergies";
            this.tbAllergies.Size = new System.Drawing.Size(300, 50);
            this.tbAllergies.TabIndex = 26;
            this.tbAllergies.Text = "";
            this.tbAllergies.TrailingIcon = null;
            // 
            // tbMedicalConditions
            // 
            this.tbMedicalConditions.AnimateReadOnly = false;
            this.tbMedicalConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMedicalConditions.Depth = 0;
            this.tbMedicalConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMedicalConditions.Hint = "Sağlık Durumu";
            this.tbMedicalConditions.LeadingIcon = null;
            this.tbMedicalConditions.Location = new System.Drawing.Point(399, 57);
            this.tbMedicalConditions.MaxLength = 50;
            this.tbMedicalConditions.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMedicalConditions.Multiline = false;
            this.tbMedicalConditions.Name = "tbMedicalConditions";
            this.tbMedicalConditions.Size = new System.Drawing.Size(300, 50);
            this.tbMedicalConditions.TabIndex = 25;
            this.tbMedicalConditions.Text = "";
            this.tbMedicalConditions.TrailingIcon = null;
            // 
            // tbNotes
            // 
            this.tbNotes.AnimateReadOnly = false;
            this.tbNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNotes.Depth = 0;
            this.tbNotes.HideSelection = true;
            this.tbNotes.Hint = "Notlar";
            this.tbNotes.Location = new System.Drawing.Point(732, 113);
            this.tbNotes.MaxLength = 512;
            this.tbNotes.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PasswordChar = '\0';
            this.tbNotes.ReadOnly = false;
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNotes.SelectedText = "";
            this.tbNotes.SelectionLength = 0;
            this.tbNotes.SelectionStart = 0;
            this.tbNotes.ShortcutsEnabled = true;
            this.tbNotes.Size = new System.Drawing.Size(300, 162);
            this.tbNotes.TabIndex = 24;
            this.tbNotes.TabStop = false;
            this.tbNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNotes.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(733, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 17);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Doğum Tarihi";
            // 
            // btnEditMember
            // 
            this.btnEditMember.AutoSize = false;
            this.btnEditMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMember.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditMember.Depth = 0;
            this.btnEditMember.HighEmphasis = true;
            this.btnEditMember.Icon = null;
            this.btnEditMember.Location = new System.Drawing.Point(484, 324);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditMember.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditMember.Size = new System.Drawing.Size(133, 40);
            this.btnEditMember.TabIndex = 22;
            this.btnEditMember.Text = "Üyeyi Düzenle";
            this.btnEditMember.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditMember.UseAccentColor = false;
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpBirthday.Location = new System.Drawing.Point(732, 82);
            this.dtpBirthday.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 21;
            this.dtpBirthday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.AutoResize = false;
            this.cbMembershipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMembershipType.Depth = 0;
            this.cbMembershipType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMembershipType.DropDownHeight = 174;
            this.cbMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembershipType.DropDownWidth = 121;
            this.cbMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMembershipType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Hint = "Üyelik Tipi";
            this.cbMembershipType.IntegralHeight = false;
            this.cbMembershipType.ItemHeight = 43;
            this.cbMembershipType.Location = new System.Drawing.Point(67, 226);
            this.cbMembershipType.MaxDropDownItems = 4;
            this.cbMembershipType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(294, 49);
            this.cbMembershipType.StartIndex = 0;
            this.cbMembershipType.TabIndex = 20;
            // 
            // tbMemberPhoneNumber
            // 
            this.tbMemberPhoneNumber.AnimateReadOnly = false;
            this.tbMemberPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMemberPhoneNumber.Depth = 0;
            this.tbMemberPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMemberPhoneNumber.Hint = "Telefon No";
            this.tbMemberPhoneNumber.LeadingIcon = null;
            this.tbMemberPhoneNumber.Location = new System.Drawing.Point(67, 169);
            this.tbMemberPhoneNumber.MaxLength = 50;
            this.tbMemberPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMemberPhoneNumber.Multiline = false;
            this.tbMemberPhoneNumber.Name = "tbMemberPhoneNumber";
            this.tbMemberPhoneNumber.Size = new System.Drawing.Size(294, 50);
            this.tbMemberPhoneNumber.TabIndex = 17;
            this.tbMemberPhoneNumber.Text = "";
            this.tbMemberPhoneNumber.TrailingIcon = null;
            // 
            // tbMemberSurname
            // 
            this.tbMemberSurname.AnimateReadOnly = false;
            this.tbMemberSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMemberSurname.Depth = 0;
            this.tbMemberSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMemberSurname.Hint = "Soyad";
            this.tbMemberSurname.LeadingIcon = null;
            this.tbMemberSurname.Location = new System.Drawing.Point(67, 113);
            this.tbMemberSurname.MaxLength = 50;
            this.tbMemberSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMemberSurname.Multiline = false;
            this.tbMemberSurname.Name = "tbMemberSurname";
            this.tbMemberSurname.Size = new System.Drawing.Size(294, 50);
            this.tbMemberSurname.TabIndex = 18;
            this.tbMemberSurname.Text = "";
            this.tbMemberSurname.TrailingIcon = null;
            // 
            // tbMemberName
            // 
            this.tbMemberName.AnimateReadOnly = false;
            this.tbMemberName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMemberName.Depth = 0;
            this.tbMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMemberName.Hint = "Ad";
            this.tbMemberName.LeadingIcon = null;
            this.tbMemberName.Location = new System.Drawing.Point(67, 57);
            this.tbMemberName.MaxLength = 50;
            this.tbMemberName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMemberName.Multiline = false;
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(294, 50);
            this.tbMemberName.TabIndex = 19;
            this.tbMemberName.Text = "";
            this.tbMemberName.TrailingIcon = null;
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 390);
            this.Controls.Add(this.tbEmergencyContactPhone);
            this.Controls.Add(this.tbEmergencyContactName);
            this.Controls.Add(this.tbAllergies);
            this.Controls.Add(this.tbMedicalConditions);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cbMembershipType);
            this.Controls.Add(this.tbMemberPhoneNumber);
            this.Controls.Add(this.tbMemberSurname);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "EditMember";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Düzenle";
            this.Shown += new System.EventHandler(this.EditMember_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox tbEmergencyContactPhone;
        private MaterialSkin.Controls.MaterialTextBox tbEmergencyContactName;
        private MaterialSkin.Controls.MaterialTextBox tbAllergies;
        private MaterialSkin.Controls.MaterialTextBox tbMedicalConditions;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbNotes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnEditMember;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private MaterialSkin.Controls.MaterialComboBox cbMembershipType;
        private MaterialSkin.Controls.MaterialTextBox tbMemberPhoneNumber;
        private MaterialSkin.Controls.MaterialTextBox tbMemberSurname;
        private MaterialSkin.Controls.MaterialTextBox tbMemberName;
    }
}

