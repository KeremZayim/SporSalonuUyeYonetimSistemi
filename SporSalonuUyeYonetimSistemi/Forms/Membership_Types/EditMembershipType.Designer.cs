namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    partial class EditMembershipType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMembershipType));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tbPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMembershipType = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEditMembershipType = new MaterialSkin.Controls.MaterialButton();
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
            this.lblTitle.Location = new System.Drawing.Point(91, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Üyelik Türü Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPrice
            // 
            this.tbPrice.AnimateReadOnly = false;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Depth = 0;
            this.tbPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPrice.Hint = "Üyelik Ücreti";
            this.tbPrice.LeadingIcon = null;
            this.tbPrice.Location = new System.Drawing.Point(92, 113);
            this.tbPrice.MaxLength = 50;
            this.tbPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(216, 50);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.Text = "";
            this.tbPrice.TrailingIcon = null;
            // 
            // tbMembershipType
            // 
            this.tbMembershipType.AnimateReadOnly = false;
            this.tbMembershipType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMembershipType.Depth = 0;
            this.tbMembershipType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMembershipType.Hint = "Üyelik Türü";
            this.tbMembershipType.LeadingIcon = null;
            this.tbMembershipType.Location = new System.Drawing.Point(92, 57);
            this.tbMembershipType.MaxLength = 50;
            this.tbMembershipType.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMembershipType.Multiline = false;
            this.tbMembershipType.Name = "tbMembershipType";
            this.tbMembershipType.Size = new System.Drawing.Size(216, 50);
            this.tbMembershipType.TabIndex = 3;
            this.tbMembershipType.Text = "";
            this.tbMembershipType.TrailingIcon = null;
            // 
            // btnEditMembershipType
            // 
            this.btnEditMembershipType.AutoSize = false;
            this.btnEditMembershipType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMembershipType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditMembershipType.Depth = 0;
            this.btnEditMembershipType.HighEmphasis = true;
            this.btnEditMembershipType.Icon = null;
            this.btnEditMembershipType.Location = new System.Drawing.Point(137, 185);
            this.btnEditMembershipType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditMembershipType.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMembershipType.Name = "btnEditMembershipType";
            this.btnEditMembershipType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditMembershipType.Size = new System.Drawing.Size(126, 44);
            this.btnEditMembershipType.TabIndex = 4;
            this.btnEditMembershipType.Text = "Düzenle";
            this.btnEditMembershipType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditMembershipType.UseAccentColor = false;
            this.btnEditMembershipType.UseVisualStyleBackColor = true;
            this.btnEditMembershipType.Click += new System.EventHandler(this.btnEditMembershipType_Click);
            // 
            // EditMembershipType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnEditMembershipType);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbMembershipType);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMembershipType";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyelik Türü Düzenleme";
            this.Shown += new System.EventHandler(this.EditMembershipType_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox tbPrice;
        private MaterialSkin.Controls.MaterialTextBox tbMembershipType;
        private MaterialSkin.Controls.MaterialButton btnEditMembershipType;
    }
}

