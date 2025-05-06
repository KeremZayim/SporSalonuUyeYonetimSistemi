namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class MemberMemberships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberMemberships));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.dtMemberMemberships = new MaterialSkin.Controls.MaterialListView();
            this.btnStartMembership = new MaterialSkin.Controls.MaterialButton();
            this.btnEndMembership = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnExitApplication);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(744, 30);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(59, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(633, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Üye Detayları";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitApplication.Location = new System.Drawing.Point(699, 0);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(45, 30);
            this.btnExitApplication.TabIndex = 0;
            this.btnExitApplication.Text = "X";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(3, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(744, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // dtMemberMemberships
            // 
            this.dtMemberMemberships.AutoSizeTable = false;
            this.dtMemberMemberships.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtMemberMemberships.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMemberMemberships.Depth = 0;
            this.dtMemberMemberships.FullRowSelect = true;
            this.dtMemberMemberships.HideSelection = false;
            this.dtMemberMemberships.Location = new System.Drawing.Point(40, 82);
            this.dtMemberMemberships.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtMemberMemberships.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtMemberMemberships.MouseState = MaterialSkin.MouseState.OUT;
            this.dtMemberMemberships.Name = "dtMemberMemberships";
            this.dtMemberMemberships.OwnerDraw = true;
            this.dtMemberMemberships.Size = new System.Drawing.Size(671, 369);
            this.dtMemberMemberships.TabIndex = 5;
            this.dtMemberMemberships.UseCompatibleStateImageBehavior = false;
            this.dtMemberMemberships.View = System.Windows.Forms.View.Details;
            // 
            // btnStartMembership
            // 
            this.btnStartMembership.AutoSize = false;
            this.btnStartMembership.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartMembership.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartMembership.Depth = 0;
            this.btnStartMembership.HighEmphasis = true;
            this.btnStartMembership.Icon = null;
            this.btnStartMembership.Location = new System.Drawing.Point(232, 480);
            this.btnStartMembership.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartMembership.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartMembership.Name = "btnStartMembership";
            this.btnStartMembership.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartMembership.Size = new System.Drawing.Size(140, 40);
            this.btnStartMembership.TabIndex = 18;
            this.btnStartMembership.Text = "Üyeliği Başlat";
            this.btnStartMembership.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartMembership.UseAccentColor = false;
            this.btnStartMembership.UseVisualStyleBackColor = true;
            this.btnStartMembership.Click += new System.EventHandler(this.btnStartMembership_Click);
            // 
            // btnEndMembership
            // 
            this.btnEndMembership.AutoSize = false;
            this.btnEndMembership.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEndMembership.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEndMembership.Depth = 0;
            this.btnEndMembership.HighEmphasis = true;
            this.btnEndMembership.Icon = null;
            this.btnEndMembership.Location = new System.Drawing.Point(380, 480);
            this.btnEndMembership.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEndMembership.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEndMembership.Name = "btnEndMembership";
            this.btnEndMembership.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEndMembership.Size = new System.Drawing.Size(140, 40);
            this.btnEndMembership.TabIndex = 18;
            this.btnEndMembership.Text = "Üyeliği Bitir";
            this.btnEndMembership.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEndMembership.UseAccentColor = false;
            this.btnEndMembership.UseVisualStyleBackColor = true;
            this.btnEndMembership.Click += new System.EventHandler(this.btnEndMembership_Click);
            // 
            // MemberMemberships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnEndMembership);
            this.Controls.Add(this.btnStartMembership);
            this.Controls.Add(this.pnlTitleSeperator);
            this.Controls.Add(this.dtMemberMemberships);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberMemberships";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyelikler";
            this.Shown += new System.EventHandler(this.MemberMemberships_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitApplication;
        private MaterialSkin.Controls.MaterialListView dtMemberMemberships;
        private MaterialSkin.Controls.MaterialButton btnStartMembership;
        private MaterialSkin.Controls.MaterialButton btnEndMembership;
    }
}