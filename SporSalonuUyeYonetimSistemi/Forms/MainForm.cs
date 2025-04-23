using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi
{
    public partial class MainForm : Form
    {
        /*
         
         1-) Form Ayarları
            1.1-) Form Başlık Form Taşıma Eventi Ekleme
         
         2-) Child Form
         
         */

        // 1-)
        public MainForm()
        {
            InitializeComponent();

            // 1.1-)
            lblTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };
            pnlTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };

        }

        // 2-)
        private Form aktifForm = null;
        private void ChildFormAc(Form childForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close(); // Önceki açık formu kapat
            }

            //Çerçevesiz ve tam boyuta ayarlama
            aktifForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChildForm.Controls.Clear(); // Paneli temizle
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
