namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    partial class EditExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExercise));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditExercise = new MaterialSkin.Controls.MaterialButton();
            this.cbRepetitionCount = new MaterialSkin.Controls.MaterialComboBox();
            this.cbSetCount = new MaterialSkin.Controls.MaterialComboBox();
            this.tbExerciseName = new MaterialSkin.Controls.MaterialTextBox();
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
            this.pnlTitle.Size = new System.Drawing.Size(294, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(249, 0);
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(294, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(28, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Egzersiz Düzenle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.AutoSize = false;
            this.btnEditExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditExercise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditExercise.Depth = 0;
            this.btnEditExercise.HighEmphasis = true;
            this.btnEditExercise.Icon = null;
            this.btnEditExercise.Location = new System.Drawing.Point(76, 270);
            this.btnEditExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditExercise.Size = new System.Drawing.Size(149, 51);
            this.btnEditExercise.TabIndex = 10;
            this.btnEditExercise.Text = "Egzersizi Düzenle";
            this.btnEditExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditExercise.UseAccentColor = false;
            this.btnEditExercise.UseVisualStyleBackColor = true;
            this.btnEditExercise.Click += new System.EventHandler(this.btnEditExercise_Click);
            // 
            // cbRepetitionCount
            // 
            this.cbRepetitionCount.AutoResize = false;
            this.cbRepetitionCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRepetitionCount.Depth = 0;
            this.cbRepetitionCount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbRepetitionCount.DropDownHeight = 174;
            this.cbRepetitionCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRepetitionCount.DropDownWidth = 121;
            this.cbRepetitionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbRepetitionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRepetitionCount.FormattingEnabled = true;
            this.cbRepetitionCount.Hint = "Tekrar Sayısı";
            this.cbRepetitionCount.IntegralHeight = false;
            this.cbRepetitionCount.ItemHeight = 43;
            this.cbRepetitionCount.Location = new System.Drawing.Point(51, 184);
            this.cbRepetitionCount.MaxDropDownItems = 4;
            this.cbRepetitionCount.MouseState = MaterialSkin.MouseState.OUT;
            this.cbRepetitionCount.Name = "cbRepetitionCount";
            this.cbRepetitionCount.Size = new System.Drawing.Size(199, 49);
            this.cbRepetitionCount.StartIndex = 0;
            this.cbRepetitionCount.TabIndex = 8;
            // 
            // cbSetCount
            // 
            this.cbSetCount.AutoResize = false;
            this.cbSetCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSetCount.Depth = 0;
            this.cbSetCount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSetCount.DropDownHeight = 174;
            this.cbSetCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetCount.DropDownWidth = 121;
            this.cbSetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSetCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSetCount.FormattingEnabled = true;
            this.cbSetCount.Hint = "Set Sayısı";
            this.cbSetCount.IntegralHeight = false;
            this.cbSetCount.ItemHeight = 43;
            this.cbSetCount.Location = new System.Drawing.Point(51, 129);
            this.cbSetCount.MaxDropDownItems = 4;
            this.cbSetCount.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSetCount.Name = "cbSetCount";
            this.cbSetCount.Size = new System.Drawing.Size(199, 49);
            this.cbSetCount.StartIndex = 0;
            this.cbSetCount.TabIndex = 9;
            // 
            // tbExerciseName
            // 
            this.tbExerciseName.AnimateReadOnly = false;
            this.tbExerciseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbExerciseName.Depth = 0;
            this.tbExerciseName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbExerciseName.Hint = "Egzersiz Adı";
            this.tbExerciseName.LeadingIcon = null;
            this.tbExerciseName.Location = new System.Drawing.Point(51, 73);
            this.tbExerciseName.MaxLength = 50;
            this.tbExerciseName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbExerciseName.Multiline = false;
            this.tbExerciseName.Name = "tbExerciseName";
            this.tbExerciseName.Size = new System.Drawing.Size(199, 50);
            this.tbExerciseName.TabIndex = 5;
            this.tbExerciseName.Text = "";
            this.tbExerciseName.TrailingIcon = null;
            // 
            // EditExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.btnEditExercise);
            this.Controls.Add(this.cbRepetitionCount);
            this.Controls.Add(this.cbSetCount);
            this.Controls.Add(this.tbExerciseName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditExercise";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egzersizleri Düzenle";
            this.Shown += new System.EventHandler(this.EditExercise_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialButton btnEditExercise;
        private MaterialSkin.Controls.MaterialComboBox cbRepetitionCount;
        private MaterialSkin.Controls.MaterialComboBox cbSetCount;
        private MaterialSkin.Controls.MaterialTextBox tbExerciseName;
    }
}

