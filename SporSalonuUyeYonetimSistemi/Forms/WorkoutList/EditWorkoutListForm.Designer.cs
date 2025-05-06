namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    partial class EditWorkoutListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWorkoutListForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditWorkoutList = new MaterialSkin.Controls.MaterialButton();
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
            this.btnExit.TabIndex = 5;
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
            this.lblTitle.Location = new System.Drawing.Point(60, -1);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Antrenman Listesi Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditWorkoutList
            // 
            this.btnEditWorkoutList.AutoSize = false;
            this.btnEditWorkoutList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditWorkoutList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditWorkoutList.Depth = 0;
            this.btnEditWorkoutList.HighEmphasis = true;
            this.btnEditWorkoutList.Icon = null;
            this.btnEditWorkoutList.Location = new System.Drawing.Point(109, 272);
            this.btnEditWorkoutList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditWorkoutList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditWorkoutList.Name = "btnEditWorkoutList";
            this.btnEditWorkoutList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditWorkoutList.Size = new System.Drawing.Size(133, 40);
            this.btnEditWorkoutList.TabIndex = 4;
            this.btnEditWorkoutList.Text = "Düzenle";
            this.btnEditWorkoutList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditWorkoutList.UseAccentColor = false;
            this.btnEditWorkoutList.UseVisualStyleBackColor = true;
            this.btnEditWorkoutList.Click += new System.EventHandler(this.btnEditWorkoutList_Click);
            // 
            // tbWorkoutDay
            // 
            this.tbWorkoutDay.AnimateReadOnly = false;
            this.tbWorkoutDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWorkoutDay.Depth = 0;
            this.tbWorkoutDay.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWorkoutDay.Hint = "Çalışma Günü";
            this.tbWorkoutDay.LeadingIcon = null;
            this.tbWorkoutDay.Location = new System.Drawing.Point(76, 188);
            this.tbWorkoutDay.MaxLength = 50;
            this.tbWorkoutDay.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWorkoutDay.Multiline = false;
            this.tbWorkoutDay.Name = "tbWorkoutDay";
            this.tbWorkoutDay.Size = new System.Drawing.Size(199, 50);
            this.tbWorkoutDay.TabIndex = 3;
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
            this.tbTargetArea.Location = new System.Drawing.Point(76, 132);
            this.tbTargetArea.MaxLength = 50;
            this.tbTargetArea.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTargetArea.Multiline = false;
            this.tbTargetArea.Name = "tbTargetArea";
            this.tbTargetArea.Size = new System.Drawing.Size(199, 50);
            this.tbTargetArea.TabIndex = 2;
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
            this.tbWorkoutName.Location = new System.Drawing.Point(76, 76);
            this.tbWorkoutName.MaxLength = 50;
            this.tbWorkoutName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWorkoutName.Multiline = false;
            this.tbWorkoutName.Name = "tbWorkoutName";
            this.tbWorkoutName.Size = new System.Drawing.Size(199, 50);
            this.tbWorkoutName.TabIndex = 1;
            this.tbWorkoutName.Text = "";
            this.tbWorkoutName.TrailingIcon = null;
            // 
            // EditWorkoutListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.btnEditWorkoutList);
            this.Controls.Add(this.tbWorkoutDay);
            this.Controls.Add(this.tbTargetArea);
            this.Controls.Add(this.tbWorkoutName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWorkoutListForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenman Listesi Düzenle";
            this.Shown += new System.EventHandler(this.EditWorkoutList_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnEditWorkoutList;
        private MaterialSkin.Controls.MaterialTextBox tbWorkoutDay;
        private MaterialSkin.Controls.MaterialTextBox tbTargetArea;
        private MaterialSkin.Controls.MaterialTextBox tbWorkoutName;
    }
}

