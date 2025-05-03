namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    partial class TrainerStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerStudents));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.dtTrainerStudents = new MaterialSkin.Controls.MaterialListView();
            this.btnDeleteStudent = new MaterialSkin.Controls.MaterialButton();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnExitForm);
            this.pnlTitle.Controls.Add(this.pnlTitleSeperator);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(544, 31);
            this.pnlTitle.TabIndex = 5;
            // 
            // btnExitForm
            // 
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.Location = new System.Drawing.Point(499, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(45, 30);
            this.btnExitForm.TabIndex = 0;
            this.btnExitForm.Text = "X";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(0, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(544, 1);
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
            this.lblTitle.Text = "Antrenör Öğrencileri";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtTrainerStudents
            // 
            this.dtTrainerStudents.AutoSizeTable = false;
            this.dtTrainerStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtTrainerStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtTrainerStudents.Depth = 0;
            this.dtTrainerStudents.FullRowSelect = true;
            this.dtTrainerStudents.HideSelection = false;
            this.dtTrainerStudents.Location = new System.Drawing.Point(25, 60);
            this.dtTrainerStudents.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtTrainerStudents.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtTrainerStudents.MouseState = MaterialSkin.MouseState.OUT;
            this.dtTrainerStudents.Name = "dtTrainerStudents";
            this.dtTrainerStudents.OwnerDraw = true;
            this.dtTrainerStudents.Size = new System.Drawing.Size(500, 350);
            this.dtTrainerStudents.TabIndex = 6;
            this.dtTrainerStudents.UseCompatibleStateImageBehavior = false;
            this.dtTrainerStudents.View = System.Windows.Forms.View.Details;
            this.dtTrainerStudents.SelectedIndexChanged += new System.EventHandler(this.dtTrainerStudents_SelectedIndexChanged);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.AutoSize = false;
            this.btnDeleteStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteStudent.Depth = 0;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.HighEmphasis = true;
            this.btnDeleteStudent.Icon = null;
            this.btnDeleteStudent.Location = new System.Drawing.Point(279, 436);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteStudent.Size = new System.Drawing.Size(142, 44);
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.Text = "Öğrenciyi Sil";
            this.btnDeleteStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteStudent.UseAccentColor = false;
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AutoSize = false;
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.HighEmphasis = true;
            this.btnAddStudent.Icon = null;
            this.btnAddStudent.Location = new System.Drawing.Point(129, 436);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Size = new System.Drawing.Size(142, 44);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Öğrenci Ekle";
            this.btnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStudent.UseAccentColor = false;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // TrainerStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.dtTrainerStudents);
            this.Controls.Add(this.pnlTitle);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerStudents";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antrenör Öğrencileri";
            this.Shown += new System.EventHandler(this.TrainerStudents_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Button btnExitForm;
        private MaterialSkin.Controls.MaterialListView dtTrainerStudents;
        private MaterialSkin.Controls.MaterialButton btnDeleteStudent;
        private MaterialSkin.Controls.MaterialButton btnAddStudent;
    }
}