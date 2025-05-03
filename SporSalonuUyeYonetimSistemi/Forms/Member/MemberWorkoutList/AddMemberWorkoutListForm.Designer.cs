namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutList
{
    partial class AddMemberWorkoutListForm
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
            this.btnAddWorkoutList = new MaterialSkin.Controls.MaterialButton();
            this.tbWorkoutDay = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTargetArea = new MaterialSkin.Controls.MaterialTextBox();
            this.tbWorkoutName = new MaterialSkin.Controls.MaterialTextBox();
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
            this.pnlTitle.Size = new System.Drawing.Size(344, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(299, 0);
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(344, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(55, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Üye Antrenman Listesi Ekle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddWorkoutList
            // 
            this.btnAddWorkoutList.AutoSize = false;
            this.btnAddWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddWorkoutList.Depth = 0;
            this.btnAddWorkoutList.HighEmphasis = true;
            this.btnAddWorkoutList.Icon = null;
            this.btnAddWorkoutList.Location = new System.Drawing.Point(109, 275);
            this.btnAddWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddWorkoutList.Name = "btnAddWorkoutList";
            this.btnAddWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnAddWorkoutList.TabIndex = 10;
            this.btnAddWorkoutList.Text = " Ekle";
            this.btnAddWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddWorkoutList.UseAccentColor = false;
            this.btnAddWorkoutList.UseVisualStyleBackColor = true;
            this.btnAddWorkoutList.Click += new System.EventHandler(this.btnAddWorkoutList_Click);
            // 
            // tbWorkoutDay
            // 
            this.tbWorkoutDay.AnimateReadOnly = false;
            this.tbWorkoutDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkoutDay.Depth = 0;
            this.tbWorkoutDay.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWorkoutDay.Hint = "Çalışma Günü";
            this.tbWorkoutDay.LeadingIcon = null;
            this.tbWorkoutDay.Location = new System.Drawing.Point(76, 187);
            this.tbWorkoutDay.MaxLength = 50;
            this.tbWorkoutDay.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWorkoutDay.Multiline = false;
            this.tbWorkoutDay.Name = "tbWorkoutDay";
            this.tbWorkoutDay.Size = new System.Drawing.Size(199, 50);
            this.tbWorkoutDay.TabIndex = 9;
            this.tbWorkoutDay.Text = "";
            this.tbWorkoutDay.TrailingIcon = null;
            // 
            // tbTargetArea
            // 
            this.tbTargetArea.AnimateReadOnly = false;
            this.tbTargetArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTargetArea.Depth = 0;
            this.tbTargetArea.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTargetArea.Hint = "Hedef Bölge";
            this.tbTargetArea.LeadingIcon = null;
            this.tbTargetArea.Location = new System.Drawing.Point(76, 131);
            this.tbTargetArea.MaxLength = 50;
            this.tbTargetArea.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTargetArea.Multiline = false;
            this.tbTargetArea.Name = "tbTargetArea";
            this.tbTargetArea.Size = new System.Drawing.Size(199, 50);
            this.tbTargetArea.TabIndex = 8;
            this.tbTargetArea.Text = "";
            this.tbTargetArea.TrailingIcon = null;
            // 
            // tbWorkoutName
            // 
            this.tbWorkoutName.AnimateReadOnly = false;
            this.tbWorkoutName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkoutName.Depth = 0;
            this.tbWorkoutName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWorkoutName.Hint = "Liste Adı";
            this.tbWorkoutName.LeadingIcon = null;
            this.tbWorkoutName.Location = new System.Drawing.Point(76, 75);
            this.tbWorkoutName.MaxLength = 50;
            this.tbWorkoutName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWorkoutName.Multiline = false;
            this.tbWorkoutName.Name = "tbWorkoutName";
            this.tbWorkoutName.Size = new System.Drawing.Size(199, 50);
            this.tbWorkoutName.TabIndex = 7;
            this.tbWorkoutName.Text = "";
            this.tbWorkoutName.TrailingIcon = null;
            // 
            // AddMemberWorkoutListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btnAddWorkoutList);
            this.Controls.Add(this.tbWorkoutDay);
            this.Controls.Add(this.tbTargetArea);
            this.Controls.Add(this.tbWorkoutName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "AddMemberWorkoutListForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberWorkoutListForm";
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnAddWorkoutList;
        private MaterialSkin.Controls.MaterialTextBox tbWorkoutDay;
        private MaterialSkin.Controls.MaterialTextBox tbTargetArea;
        private MaterialSkin.Controls.MaterialTextBox tbWorkoutName;
    }
}

