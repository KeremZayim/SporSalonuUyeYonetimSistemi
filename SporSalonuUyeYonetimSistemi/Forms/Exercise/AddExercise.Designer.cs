namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    partial class AddExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExercise));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tbExerciseName = new MaterialSkin.Controls.MaterialTextBox();
            this.cbSetCount = new MaterialSkin.Controls.MaterialComboBox();
            this.cbRepetitionCount = new MaterialSkin.Controls.MaterialComboBox();
            this.cbWorkout = new MaterialSkin.Controls.MaterialComboBox();
            this.cbMember = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddExercise = new MaterialSkin.Controls.MaterialButton();
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
            this.pnlTitle.Size = new System.Drawing.Size(594, 30);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(549, 0);
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
            this.pnlTitleSeperator.Size = new System.Drawing.Size(594, 1);
            this.pnlTitleSeperator.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(183, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Egzersiz Ekle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbExerciseName
            // 
            this.tbExerciseName.AnimateReadOnly = false;
            this.tbExerciseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbExerciseName.Depth = 0;
            this.tbExerciseName.Enabled = false;
            this.tbExerciseName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbExerciseName.Hint = "Egzersiz Adı";
            this.tbExerciseName.LeadingIcon = null;
            this.tbExerciseName.Location = new System.Drawing.Point(345, 98);
            this.tbExerciseName.MaxLength = 50;
            this.tbExerciseName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbExerciseName.Multiline = false;
            this.tbExerciseName.Name = "tbExerciseName";
            this.tbExerciseName.Size = new System.Drawing.Size(199, 50);
            this.tbExerciseName.TabIndex = 1;
            this.tbExerciseName.Text = "";
            this.tbExerciseName.TrailingIcon = null;
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
            this.cbSetCount.Enabled = false;
            this.cbSetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSetCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSetCount.FormattingEnabled = true;
            this.cbSetCount.Hint = "Set Sayısı";
            this.cbSetCount.IntegralHeight = false;
            this.cbSetCount.ItemHeight = 43;
            this.cbSetCount.Location = new System.Drawing.Point(345, 154);
            this.cbSetCount.MaxDropDownItems = 4;
            this.cbSetCount.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSetCount.Name = "cbSetCount";
            this.cbSetCount.Size = new System.Drawing.Size(199, 49);
            this.cbSetCount.StartIndex = 0;
            this.cbSetCount.TabIndex = 2;
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
            this.cbRepetitionCount.Enabled = false;
            this.cbRepetitionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbRepetitionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRepetitionCount.FormattingEnabled = true;
            this.cbRepetitionCount.Hint = "Tekrar Sayısı";
            this.cbRepetitionCount.IntegralHeight = false;
            this.cbRepetitionCount.ItemHeight = 43;
            this.cbRepetitionCount.Location = new System.Drawing.Point(345, 209);
            this.cbRepetitionCount.MaxDropDownItems = 4;
            this.cbRepetitionCount.MouseState = MaterialSkin.MouseState.OUT;
            this.cbRepetitionCount.Name = "cbRepetitionCount";
            this.cbRepetitionCount.Size = new System.Drawing.Size(199, 49);
            this.cbRepetitionCount.StartIndex = 0;
            this.cbRepetitionCount.TabIndex = 2;
            // 
            // cbWorkout
            // 
            this.cbWorkout.AutoResize = false;
            this.cbWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbWorkout.Depth = 0;
            this.cbWorkout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbWorkout.DropDownHeight = 174;
            this.cbWorkout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkout.DropDownWidth = 121;
            this.cbWorkout.Enabled = false;
            this.cbWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbWorkout.FormattingEnabled = true;
            this.cbWorkout.Hint = "Antrenman Seç";
            this.cbWorkout.IntegralHeight = false;
            this.cbWorkout.ItemHeight = 43;
            this.cbWorkout.Location = new System.Drawing.Point(345, 264);
            this.cbWorkout.MaxDropDownItems = 4;
            this.cbWorkout.MouseState = MaterialSkin.MouseState.OUT;
            this.cbWorkout.Name = "cbWorkout";
            this.cbWorkout.Size = new System.Drawing.Size(199, 49);
            this.cbWorkout.StartIndex = 0;
            this.cbWorkout.TabIndex = 2;
            // 
            // cbMember
            // 
            this.cbMember.AutoResize = false;
            this.cbMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMember.Depth = 0;
            this.cbMember.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMember.DropDownHeight = 174;
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMember.DropDownWidth = 121;
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Hint = "Kişi Seç";
            this.cbMember.IntegralHeight = false;
            this.cbMember.ItemHeight = 43;
            this.cbMember.Location = new System.Drawing.Point(31, 96);
            this.cbMember.MaxDropDownItems = 4;
            this.cbMember.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(199, 49);
            this.cbMember.StartIndex = 0;
            this.cbMember.TabIndex = 2;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.AutoSize = false;
            this.btnAddExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddExercise.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddExercise.Depth = 0;
            this.btnAddExercise.HighEmphasis = true;
            this.btnAddExercise.Icon = null;
            this.btnAddExercise.Location = new System.Drawing.Point(64, 273);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddExercise.Size = new System.Drawing.Size(133, 40);
            this.btnAddExercise.TabIndex = 4;
            this.btnAddExercise.Text = "Egzersiz Ekle";
            this.btnAddExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddExercise.UseAccentColor = false;
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.cbWorkout);
            this.Controls.Add(this.cbRepetitionCount);
            this.Controls.Add(this.cbSetCount);
            this.Controls.Add(this.tbExerciseName);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddExercise";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egzersiz Ekle";
            this.Shown += new System.EventHandler(this.AddExercise_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExit;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox tbExerciseName;
        private MaterialSkin.Controls.MaterialComboBox cbSetCount;
        private MaterialSkin.Controls.MaterialComboBox cbRepetitionCount;
        private MaterialSkin.Controls.MaterialComboBox cbWorkout;
        private MaterialSkin.Controls.MaterialComboBox cbMember;
        private MaterialSkin.Controls.MaterialButton btnAddExercise;
    }
}

