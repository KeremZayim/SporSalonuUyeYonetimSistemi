using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation;
using SporSalonuUyeYonetimSistemi.Forms;
using System;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Forms.Trainers;
using SporSalonuUyeYonetimSistemi.Forms.Exercise;

namespace SporSalonuUyeYonetimSistemi
{
    public partial class MainForm : Form
    {
        /*
         
         1-) Form Ayarları
            1.1-) Form Başlık Form Taşıma Eventi Ekleme

         2-) Child Form

         3-) Butonlar
            3.1-) Ana Sayfa
            3.2-) Üyeler
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

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ChildFormAc(new MemberPage());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnMembers.Text;
        }

        private void btnParticipationHistory_Click(object sender, EventArgs e)
        {
            ChildFormAc(new ParticipationHistory());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnParticipationHistory.Text;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Payments());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnPayments.Text;
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            ChildFormAc(new TrainersPage());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnTrainers.Text;
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            ChildFormAc(new Exercise());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnExercises.Text;
        }
    }
}
