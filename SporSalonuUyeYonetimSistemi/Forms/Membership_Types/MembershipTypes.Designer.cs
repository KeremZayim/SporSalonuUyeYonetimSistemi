namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    partial class MembershipTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipTypes));
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabMembership_types = new System.Windows.Forms.TabPage();
            this.btnAddMembershipType = new MaterialSkin.Controls.MaterialButton();
            this.btnEditMembershipType = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteMembershipType = new MaterialSkin.Controls.MaterialButton();
            this.dtMembershipTypes = new MaterialSkin.Controls.MaterialListView();
            this.tabController.SuspendLayout();
            this.tabMembership_types.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabController;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(3, 0);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(998, 50);
            this.tabSelector.TabIndex = 2;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabMembership_types);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(3, 50);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Multiline = true;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(998, 636);
            this.tabController.TabIndex = 3;
            // 
            // tabMembership_types
            // 
            this.tabMembership_types.Controls.Add(this.btnAddMembershipType);
            this.tabMembership_types.Controls.Add(this.btnEditMembershipType);
            this.tabMembership_types.Controls.Add(this.btnDeleteMembershipType);
            this.tabMembership_types.Controls.Add(this.dtMembershipTypes);
            this.tabMembership_types.Location = new System.Drawing.Point(4, 22);
            this.tabMembership_types.Name = "tabMembership_types";
            this.tabMembership_types.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembership_types.Size = new System.Drawing.Size(990, 610);
            this.tabMembership_types.TabIndex = 0;
            this.tabMembership_types.Text = "Üyelik Türleri";
            this.tabMembership_types.UseVisualStyleBackColor = true;
            // 
            // btnAddMembershipType
            // 
            this.btnAddMembershipType.AutoSize = false;
            this.btnAddMembershipType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMembershipType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMembershipType.Depth = 0;
            this.btnAddMembershipType.HighEmphasis = true;
            this.btnAddMembershipType.Icon = null;
            this.btnAddMembershipType.Location = new System.Drawing.Point(844, 227);
            this.btnAddMembershipType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddMembershipType.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMembershipType.Name = "btnAddMembershipType";
            this.btnAddMembershipType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddMembershipType.Size = new System.Drawing.Size(133, 40);
            this.btnAddMembershipType.TabIndex = 1;
            this.btnAddMembershipType.Text = "Üyelik Türü Ekle";
            this.btnAddMembershipType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMembershipType.UseAccentColor = false;
            this.btnAddMembershipType.UseVisualStyleBackColor = true;
            this.btnAddMembershipType.Click += new System.EventHandler(this.btnAddMembershipType_Click);
            // 
            // btnEditMembershipType
            // 
            this.btnEditMembershipType.AutoSize = false;
            this.btnEditMembershipType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMembershipType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditMembershipType.Depth = 0;
            this.btnEditMembershipType.Enabled = false;
            this.btnEditMembershipType.HighEmphasis = true;
            this.btnEditMembershipType.Icon = null;
            this.btnEditMembershipType.Location = new System.Drawing.Point(844, 279);
            this.btnEditMembershipType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditMembershipType.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMembershipType.Name = "btnEditMembershipType";
            this.btnEditMembershipType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditMembershipType.Size = new System.Drawing.Size(133, 40);
            this.btnEditMembershipType.TabIndex = 2;
            this.btnEditMembershipType.Text = "Üyelik Türünü Düzenle";
            this.btnEditMembershipType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditMembershipType.UseAccentColor = false;
            this.btnEditMembershipType.UseVisualStyleBackColor = true;
            this.btnEditMembershipType.Click += new System.EventHandler(this.btnEditMembershipType_Click);
            // 
            // btnDeleteMembershipType
            // 
            this.btnDeleteMembershipType.AutoSize = false;
            this.btnDeleteMembershipType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMembershipType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteMembershipType.Depth = 0;
            this.btnDeleteMembershipType.Enabled = false;
            this.btnDeleteMembershipType.HighEmphasis = true;
            this.btnDeleteMembershipType.Icon = null;
            this.btnDeleteMembershipType.Location = new System.Drawing.Point(844, 331);
            this.btnDeleteMembershipType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteMembershipType.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteMembershipType.Name = "btnDeleteMembershipType";
            this.btnDeleteMembershipType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteMembershipType.Size = new System.Drawing.Size(133, 40);
            this.btnDeleteMembershipType.TabIndex = 3;
            this.btnDeleteMembershipType.Text = "Üyelik Türünü Sil";
            this.btnDeleteMembershipType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteMembershipType.UseAccentColor = false;
            this.btnDeleteMembershipType.UseVisualStyleBackColor = true;
            this.btnDeleteMembershipType.Click += new System.EventHandler(this.btnDeleteMembershipType_Click);
            // 
            // dtMembershipTypes
            // 
            this.dtMembershipTypes.AutoSizeTable = false;
            this.dtMembershipTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtMembershipTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMembershipTypes.Depth = 0;
            this.dtMembershipTypes.FullRowSelect = true;
            this.dtMembershipTypes.HideSelection = false;
            this.dtMembershipTypes.Location = new System.Drawing.Point(6, 24);
            this.dtMembershipTypes.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtMembershipTypes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtMembershipTypes.MouseState = MaterialSkin.MouseState.OUT;
            this.dtMembershipTypes.Name = "dtMembershipTypes";
            this.dtMembershipTypes.OwnerDraw = true;
            this.dtMembershipTypes.Size = new System.Drawing.Size(800, 550);
            this.dtMembershipTypes.TabIndex = 1;
            this.dtMembershipTypes.UseCompatibleStateImageBehavior = false;
            this.dtMembershipTypes.View = System.Windows.Forms.View.Details;
            this.dtMembershipTypes.SelectedIndexChanged += new System.EventHandler(this.dtMembershipTypes_SelectedIndexChanged);
            // 
            // MembershipTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.tabSelector);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembershipTypes";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spor Salonu Üye Yönetim Sistemi";
            this.Shown += new System.EventHandler(this.MembershipTypes_Shown);
            this.tabController.ResumeLayout(false);
            this.tabMembership_types.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabMembership_types;
        private MaterialSkin.Controls.MaterialListView dtMembershipTypes;
        private MaterialSkin.Controls.MaterialButton btnAddMembershipType;
        private MaterialSkin.Controls.MaterialButton btnEditMembershipType;
        private MaterialSkin.Controls.MaterialButton btnDeleteMembershipType;
    }
}