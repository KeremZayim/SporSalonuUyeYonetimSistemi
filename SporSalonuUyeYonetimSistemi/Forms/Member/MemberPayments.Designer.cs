﻿using SporSalonuUyeYonetimSistemi.Classes;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    partial class MemberPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberPayments));
            this.dtData = new MaterialSkin.Controls.MaterialListView();
            this.btnPay = new MaterialSkin.Controls.MaterialButton();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.pnlTitleSeperator = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtData
            // 
            this.dtData.AutoSizeTable = false;
            this.dtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtData.Depth = 0;
            this.dtData.FullRowSelect = true;
            this.dtData.HideSelection = false;
            this.dtData.Location = new System.Drawing.Point(50, 63);
            this.dtData.MinimumSize = new System.Drawing.Size(200, 100);
            this.dtData.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dtData.MouseState = MaterialSkin.MouseState.OUT;
            this.dtData.Name = "dtData";
            this.dtData.OwnerDraw = true;
            this.dtData.ShowGroups = false;
            this.dtData.Size = new System.Drawing.Size(700, 350);
            this.dtData.TabIndex = 0;
            this.dtData.UseCompatibleStateImageBehavior = false;
            this.dtData.View = System.Windows.Forms.View.Details;
            this.dtData.SelectedIndexChanged += new System.EventHandler(this.dtData_SelectedIndexChanged);
            // 
            // btnPay
            // 
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPay.Depth = 0;
            this.btnPay.Enabled = false;
            this.btnPay.HighEmphasis = true;
            this.btnPay.Icon = null;
            this.btnPay.Location = new System.Drawing.Point(349, 439);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPay.Name = "btnPay";
            this.btnPay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPay.Size = new System.Drawing.Size(103, 36);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Ödeme Yap";
            this.btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPay.UseAccentColor = false;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnExitApplication);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(3, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(794, 30);
            this.pnlTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblTitle.Location = new System.Drawing.Point(70, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(661, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Üye Ödemeleri";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitApplication.Location = new System.Drawing.Point(749, 0);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(45, 30);
            this.btnExitApplication.TabIndex = 2;
            this.btnExitApplication.Text = "X";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnFormExit_Click);
            // 
            // pnlTitleSeperator
            // 
            this.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(40)))));
            this.pnlTitleSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleSeperator.Location = new System.Drawing.Point(3, 30);
            this.pnlTitleSeperator.Name = "pnlTitleSeperator";
            this.pnlTitleSeperator.Size = new System.Drawing.Size(794, 1);
            this.pnlTitleSeperator.TabIndex = 8;
            // 
            // MemberPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlTitleSeperator);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dtData);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberPayments";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ödemeleri";
            this.Shown += new System.EventHandler(this.MemberPayments_Shown);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView dtData;
        private MaterialSkin.Controls.MaterialButton btnPay;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTitleSeperator;
        private System.Windows.Forms.Button btnExitApplication;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
    }
}