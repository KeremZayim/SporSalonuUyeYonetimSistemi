using SporSalonuUyeYonetimSistemi.Classes;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation
{
    partial class MemberPage
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
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMemberInfo = new System.Windows.Forms.TabPage();
            this.btnAttendance = new MaterialSkin.Controls.MaterialButton();
            this.btnHealthInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnTrainingInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnMemberTrainers = new MaterialSkin.Controls.MaterialButton();
            this.btnPayments = new MaterialSkin.Controls.MaterialButton();
            this.dtMemberInfo = new MaterialSkin.Controls.MaterialListView();
            this.member_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.member_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.member_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.member_birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMemberAdd = new System.Windows.Forms.TabPage();
            this.tabMenberDelete = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabMemberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(3, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(998, 50);
            this.tabSelector.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMemberInfo);
            this.tabControl.Controls.Add(this.tabMemberAdd);
            this.tabControl.Controls.Add(this.tabMenberDelete);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 50);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(998, 636);
            this.tabControl.TabIndex = 1;
            // 
            // tabMemberInfo
            // 
            this.tabMemberInfo.Controls.Add(this.btnAttendance);
            this.tabMemberInfo.Controls.Add(this.btnHealthInfo);
            this.tabMemberInfo.Controls.Add(this.btnTrainingInfo);
            this.tabMemberInfo.Controls.Add(this.btnMemberTrainers);
            this.tabMemberInfo.Controls.Add(this.btnPayments);
            this.tabMemberInfo.Controls.Add(this.dtMemberInfo);
            this.tabMemberInfo.Location = new System.Drawing.Point(4, 22);
            this.tabMemberInfo.Name = "tabMemberInfo";
            this.tabMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberInfo.Size = new System.Drawing.Size(990, 610);
            this.tabMemberInfo.TabIndex = 0;
            this.tabMemberInfo.Text = "Üye Bilgileri";
            this.tabMemberInfo.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.AutoSize = false;
            this.btnAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttendance.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttendance.Depth = 0;
            this.btnAttendance.Enabled = false;
            this.btnAttendance.HighEmphasis = true;
            this.btnAttendance.Icon = null;
            this.btnAttendance.Location = new System.Drawing.Point(835, 266);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttendance.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttendance.Size = new System.Drawing.Size(133, 40);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "Katılım Geçmişi";
            this.btnAttendance.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttendance.UseAccentColor = false;
            this.btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnHealthInfo
            // 
            this.btnHealthInfo.AutoSize = false;
            this.btnHealthInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHealthInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHealthInfo.Depth = 0;
            this.btnHealthInfo.Enabled = false;
            this.btnHealthInfo.HighEmphasis = true;
            this.btnHealthInfo.Icon = null;
            this.btnHealthInfo.Location = new System.Drawing.Point(835, 214);
            this.btnHealthInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHealthInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHealthInfo.Name = "btnHealthInfo";
            this.btnHealthInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHealthInfo.Size = new System.Drawing.Size(133, 40);
            this.btnHealthInfo.TabIndex = 1;
            this.btnHealthInfo.Text = "Sağlık Bilgileri";
            this.btnHealthInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHealthInfo.UseAccentColor = false;
            this.btnHealthInfo.UseVisualStyleBackColor = true;
            // 
            // btnTrainingInfo
            // 
            this.btnTrainingInfo.AutoSize = false;
            this.btnTrainingInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrainingInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrainingInfo.Depth = 0;
            this.btnTrainingInfo.Enabled = false;
            this.btnTrainingInfo.HighEmphasis = true;
            this.btnTrainingInfo.Icon = null;
            this.btnTrainingInfo.Location = new System.Drawing.Point(835, 162);
            this.btnTrainingInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrainingInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrainingInfo.Name = "btnTrainingInfo";
            this.btnTrainingInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrainingInfo.Size = new System.Drawing.Size(133, 40);
            this.btnTrainingInfo.TabIndex = 1;
            this.btnTrainingInfo.Text = "Antrenman Bilgileri";
            this.btnTrainingInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrainingInfo.UseAccentColor = false;
            this.btnTrainingInfo.UseVisualStyleBackColor = true;
            // 
            // btnMemberTrainers
            // 
            this.btnMemberTrainers.AutoSize = false;
            this.btnMemberTrainers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMemberTrainers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMemberTrainers.Depth = 0;
            this.btnMemberTrainers.Enabled = false;
            this.btnMemberTrainers.HighEmphasis = true;
            this.btnMemberTrainers.Icon = null;
            this.btnMemberTrainers.Location = new System.Drawing.Point(835, 110);
            this.btnMemberTrainers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMemberTrainers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMemberTrainers.Name = "btnMemberTrainers";
            this.btnMemberTrainers.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMemberTrainers.Size = new System.Drawing.Size(133, 40);
            this.btnMemberTrainers.TabIndex = 1;
            this.btnMemberTrainers.Text = "Antrenörleri";
            this.btnMemberTrainers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMemberTrainers.UseAccentColor = false;
            this.btnMemberTrainers.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.AutoSize = false;
            this.btnPayments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayments.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayments.Depth = 0;
            this.btnPayments.Enabled = false;
            this.btnPayments.HighEmphasis = true;
            this.btnPayments.Icon = null;
            this.btnPayments.Location = new System.Drawing.Point(835, 58);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPayments.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPayments.Size = new System.Drawing.Size(133, 40);
            this.btnPayments.TabIndex = 1;
            this.btnPayments.Text = "Ödemeler";
            this.btnPayments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayments.UseAccentColor = false;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // dtMemberInfo
            // 
            this.dtMemberInfo.AutoSizeTable = false;
            this.dtMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMemberInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.member_id,
            this.member_name,
            this.member_surname,
            this.member_birthday,
            this.phone_number,
            this.note});
            this.dtMemberInfo.Depth = 0;
            this.dtMemberInfo.FullRowSelect = true;
            this.dtMemberInfo.HideSelection = false;
            this.dtMemberInfo.Location = new System.Drawing.Point(6, 24);
            this.dtMemberInfo.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtMemberInfo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtMemberInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.dtMemberInfo.MultiSelect = false;
            this.dtMemberInfo.Name = "dtMemberInfo";
            this.dtMemberInfo.OwnerDraw = true;
            this.dtMemberInfo.ShowGroups = false;
            this.dtMemberInfo.Size = new System.Drawing.Size(800, 550);
            this.dtMemberInfo.TabIndex = 0;
            this.dtMemberInfo.UseCompatibleStateImageBehavior = false;
            this.dtMemberInfo.View = System.Windows.Forms.View.Details;
            this.dtMemberInfo.SelectedIndexChanged += new System.EventHandler(this.dtMemberInfo_SelectedIndexChanged);
            // 
            // member_id
            // 
            this.member_id.Text = "Üye ID";
            this.member_id.Width = 80;
            // 
            // member_name
            // 
            this.member_name.Text = "Ad";
            this.member_name.Width = 120;
            // 
            // member_surname
            // 
            this.member_surname.Text = "Soyad";
            this.member_surname.Width = 120;
            // 
            // member_birthday
            // 
            this.member_birthday.Text = "Doğum Tarihi";
            this.member_birthday.Width = 120;
            // 
            // phone_number
            // 
            this.phone_number.Text = "Telefon No";
            this.phone_number.Width = 120;
            // 
            // note
            // 
            this.note.Text = "Not";
            this.note.Width = 240;
            // 
            // tabMemberAdd
            // 
            this.tabMemberAdd.Location = new System.Drawing.Point(4, 22);
            this.tabMemberAdd.Name = "tabMemberAdd";
            this.tabMemberAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberAdd.Size = new System.Drawing.Size(990, 610);
            this.tabMemberAdd.TabIndex = 1;
            this.tabMemberAdd.Text = "Üye Ekle";
            this.tabMemberAdd.UseVisualStyleBackColor = true;
            // 
            // tabMenberDelete
            // 
            this.tabMenberDelete.Location = new System.Drawing.Point(4, 22);
            this.tabMenberDelete.Name = "tabMenberDelete";
            this.tabMenberDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenberDelete.Size = new System.Drawing.Size(990, 610);
            this.tabMenberDelete.TabIndex = 2;
            this.tabMenberDelete.Text = "Üye Düzenle";
            this.tabMenberDelete.UseVisualStyleBackColor = true;
            // 
            // MemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "MemberPage";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.MemberPage_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabMemberInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabMemberInfo;
        private System.Windows.Forms.TabPage tabMemberAdd;
        private System.Windows.Forms.TabPage tabMenberDelete;
        private MaterialSkin.Controls.MaterialListView dtMemberInfo;
        private System.Windows.Forms.ColumnHeader member_id;
        private System.Windows.Forms.ColumnHeader member_name;
        private System.Windows.Forms.ColumnHeader member_surname;
        private System.Windows.Forms.ColumnHeader member_birthday;
        private System.Windows.Forms.ColumnHeader phone_number;
        private System.Windows.Forms.ColumnHeader note;
        private MaterialSkin.Controls.MaterialButton btnPayments;
        private MaterialSkin.Controls.MaterialButton btnHealthInfo;
        private MaterialSkin.Controls.MaterialButton btnTrainingInfo;
        private MaterialSkin.Controls.MaterialButton btnMemberTrainers;
        private MaterialSkin.Controls.MaterialButton btnAttendance;
    }
}