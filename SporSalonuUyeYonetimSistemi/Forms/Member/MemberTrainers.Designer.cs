namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class MemberTrainers
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
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.btnDeleteTrainer = new MaterialSkin.Controls.MaterialButton();
            this.dtMemberTrainers = new MaterialSkin.Controls.MaterialListView();
            this.btnAddTrainer = new MaterialSkin.Controls.MaterialButton();
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
            this.pnlTitle.Size = new System.Drawing.Size(544, 31);
            this.pnlTitle.TabIndex = 4;
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(499, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(50, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.Location = new System.Drawing.Point(499, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(45, 31);
            this.btnExitForm.TabIndex = 0;
            this.btnExitForm.Text = "X";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.AutoSize = false;
            this.btnDeleteTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteTrainer.Depth = 0;
            this.btnDeleteTrainer.Enabled = false;
            this.btnDeleteTrainer.HighEmphasis = true;
            this.btnDeleteTrainer.Icon = null;
            this.btnDeleteTrainer.Location = new System.Drawing.Point(287, 435);
            this.btnDeleteTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteTrainer.TabIndex = 9;
            this.btnDeleteTrainer.Text = "Antrenörü Sil";
            this.btnDeleteTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteTrainer.UseAccentColor = false;
            this.btnDeleteTrainer.UseVisualStyleBackColor = true;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click);
            // 
            // dtMemberTrainers
            // 
            this.dtMemberTrainers.AutoSizeTable = false;
            this.dtMemberTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtMemberTrainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMemberTrainers.Depth = 0;
            this.dtMemberTrainers.FullRowSelect = true;
            this.dtMemberTrainers.HideSelection = false;
            this.dtMemberTrainers.Location = new System.Drawing.Point(25, 60);
            this.dtMemberTrainers.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtMemberTrainers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtMemberTrainers.MouseState = MaterialSkin.MouseState.OUT;
            this.dtMemberTrainers.Name = "dtMemberTrainers";
            this.dtMemberTrainers.OwnerDraw = true;
            this.dtMemberTrainers.Size = new System.Drawing.Size(500, 350);
            this.dtMemberTrainers.TabIndex = 8;
            this.dtMemberTrainers.UseCompatibleStateImageBehavior = false;
            this.dtMemberTrainers.View = System.Windows.Forms.View.Details;
            this.dtMemberTrainers.SelectedIndexChanged += new System.EventHandler(this.dtMemberTrainers_SelectedIndexChanged);
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.AutoSize = false;
            this.btnAddTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTrainer.Depth = 0;
            this.btnAddTrainer.HighEmphasis = true;
            this.btnAddTrainer.Icon = null;
            this.btnAddTrainer.Location = new System.Drawing.Point(117, 435);
            this.btnAddTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnAddTrainer.TabIndex = 9;
            this.btnAddTrainer.Text = "Antrenör Ekle";
            this.btnAddTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTrainer.UseAccentColor = false;
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // MemberTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.btnDeleteTrainer);
            this.Controls.Add(this.dtMemberTrainers);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "MemberTrainers";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberTrainers";
            this.Shown += new System.EventHandler(this.MemberTrainers_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitForm;
        private MaterialSkin.Controls.MaterialButton btnDeleteTrainer;
        private MaterialSkin.Controls.MaterialListView dtMemberTrainers;
        private MaterialSkin.Controls.MaterialButton btnAddTrainer;
    }
}