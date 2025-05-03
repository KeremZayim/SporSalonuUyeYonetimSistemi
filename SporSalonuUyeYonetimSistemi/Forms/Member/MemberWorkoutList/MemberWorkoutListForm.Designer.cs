namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutList
{
    partial class MemberWorkoutListForm
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
            this.dtWorkoutList = new MaterialSkin.Controls.MaterialListView();
            this.btnAddWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.btnEditWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteWorkoutList = new MaterialSkin.Controls.MaterialButton();
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
            this.pnlTitle.Size = new System.Drawing.Size(879, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(834, 0);
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(879, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(298, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Üye Antrenman Listeleri";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtWorkoutList
            // 
            this.dtWorkoutList.AutoSizeTable = false;
            this.dtWorkoutList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtWorkoutList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtWorkoutList.Depth = 0;
            this.dtWorkoutList.FullRowSelect = true;
            this.dtWorkoutList.HideSelection = false;
            this.dtWorkoutList.Location = new System.Drawing.Point(25, 56);
            this.dtWorkoutList.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtWorkoutList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtWorkoutList.MouseState = MaterialSkin.MouseState.OUT;
            this.dtWorkoutList.Name = "dtWorkoutList";
            this.dtWorkoutList.OwnerDraw = true;
            this.dtWorkoutList.Size = new System.Drawing.Size(664, 364);
            this.dtWorkoutList.TabIndex = 1;
            this.dtWorkoutList.UseCompatibleStateImageBehavior = false;
            this.dtWorkoutList.View = System.Windows.Forms.View.Details;
            this.dtWorkoutList.SelectedIndexChanged += new System.EventHandler(this.dtWorkoutList_SelectedIndexChanged);
            // 
            // btnAddWorkoutList
            // 
            this.btnAddWorkoutList.AutoSize = false;
            this.btnAddWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddWorkoutList.Depth = 0;
            this.btnAddWorkoutList.HighEmphasis = true;
            this.btnAddWorkoutList.Icon = null;
            this.btnAddWorkoutList.Location = new System.Drawing.Point(722, 165);
            this.btnAddWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWorkoutList.Name = "btnAddWorkoutList";
            this.btnAddWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnAddWorkoutList.TabIndex = 10;
            this.btnAddWorkoutList.Text = "Antrenman Listesi Ekle";
            this.btnAddWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddWorkoutList.UseAccentColor = false;
            this.btnAddWorkoutList.UseVisualStyleBackColor = true;
            this.btnAddWorkoutList.Click += new System.EventHandler(this.btnAddWorkoutList_Click);
            // 
            // btnEditWorkoutList
            // 
            this.btnEditWorkoutList.AutoSize = false;
            this.btnEditWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditWorkoutList.Depth = 0;
            this.btnEditWorkoutList.Enabled = false;
            this.btnEditWorkoutList.HighEmphasis = true;
            this.btnEditWorkoutList.Icon = null;
            this.btnEditWorkoutList.Location = new System.Drawing.Point(722, 217);
            this.btnEditWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorkoutList.Name = "btnEditWorkoutList";
            this.btnEditWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnEditWorkoutList.TabIndex = 11;
            this.btnEditWorkoutList.Text = "Antrenman Listesini Düzenle";
            this.btnEditWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditWorkoutList.UseAccentColor = false;
            this.btnEditWorkoutList.UseVisualStyleBackColor = true;
            this.btnEditWorkoutList.Click += new System.EventHandler(this.btnEditWorkoutList_Click);
            // 
            // btnDeleteWorkoutList
            // 
            this.btnDeleteWorkoutList.AutoSize = false;
            this.btnDeleteWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteWorkoutList.Depth = 0;
            this.btnDeleteWorkoutList.Enabled = false;
            this.btnDeleteWorkoutList.HighEmphasis = true;
            this.btnDeleteWorkoutList.Icon = null;
            this.btnDeleteWorkoutList.Location = new System.Drawing.Point(722, 269);
            this.btnDeleteWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteWorkoutList.Name = "btnDeleteWorkoutList";
            this.btnDeleteWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnDeleteWorkoutList.TabIndex = 12;
            this.btnDeleteWorkoutList.Text = "Antrenman Listesini Sil";
            this.btnDeleteWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteWorkoutList.UseAccentColor = false;
            this.btnDeleteWorkoutList.UseVisualStyleBackColor = true;
            this.btnDeleteWorkoutList.Click += new System.EventHandler(this.btnDeleteWorkoutList_Click);
            // 
            // MemberWorkoutListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.btnAddWorkoutList);
            this.Controls.Add(this.btnEditWorkoutList);
            this.Controls.Add(this.btnDeleteWorkoutList);
            this.Controls.Add(this.dtWorkoutList);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "MemberWorkoutListForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Antrenman Listeleri";
            this.Shown += new System.EventHandler(this.MemberWorkoutList_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialListView dtWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnAddWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnEditWorkoutList;
        private MaterialSkin.Controls.MaterialButton btnDeleteWorkoutList;
    }
}

