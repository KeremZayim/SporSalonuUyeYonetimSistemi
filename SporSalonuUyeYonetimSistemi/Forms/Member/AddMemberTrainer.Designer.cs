namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class AddMemberTrainer
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
            this.cbTrainers = new MaterialSkin.Controls.MaterialComboBox();
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
            this.pnlTitle.Size = new System.Drawing.Size(387, 31);
            this.pnlTitle.TabIndex = 5;
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(342, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(79, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.Location = new System.Drawing.Point(342, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(45, 31);
            this.btnExitForm.TabIndex = 0;
            this.btnExitForm.Text = "X";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // cbTrainers
            // 
            this.cbTrainers.AutoResize = false;
            this.cbTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTrainers.Depth = 0;
            this.cbTrainers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTrainers.DropDownHeight = 174;
            this.cbTrainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainers.DropDownWidth = 121;
            this.cbTrainers.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTrainers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTrainers.FormattingEnabled = true;
            this.cbTrainers.Hint = "Antrenör Seç";
            this.cbTrainers.IntegralHeight = false;
            this.cbTrainers.ItemHeight = 43;
            this.cbTrainers.Location = new System.Drawing.Point(85, 71);
            this.cbTrainers.MaxDropDownItems = 4;
            this.cbTrainers.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(222, 49);
            this.cbTrainers.StartIndex = 0;
            this.cbTrainers.TabIndex = 6;
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.AutoSize = false;
            this.btnAddTrainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrainer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTrainer.Depth = 0;
            this.btnAddTrainer.HighEmphasis = true;
            this.btnAddTrainer.Icon = null;
            this.btnAddTrainer.Location = new System.Drawing.Point(125, 167);
            this.btnAddTrainer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTrainer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTrainer.Size = new System.Drawing.Size(142, 44);
            this.btnAddTrainer.TabIndex = 10;
            this.btnAddTrainer.Text = "Antrenör Ekle";
            this.btnAddTrainer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTrainer.UseAccentColor = false;
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // AddMemberTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 248);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.cbTrainers);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "AddMemberTrainer";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberTrainer";
            this.Shown += new System.EventHandler(this.AddMemberTrainer_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitForm;
        private MaterialSkin.Controls.MaterialComboBox cbTrainers;
        private MaterialSkin.Controls.MaterialButton btnAddTrainer;
    }
}