using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation;
using SporSalonuUyeYonetimSistemi.Forms;
using System;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Forms.Trainers;
using SporSalonuUyeYonetimSistemi.Forms.Exercise;
using SporSalonuUyeYonetimSistemi.Forms.Membership_Types;
using SporSalonuUyeYonetimSistemi.Forms.Workout;

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
            3.3-) Üyelik Türleri
            3.4-) Antrenörler
            3.5-) Egzersizler
            3.6-) Antrenman Listeleri
            3.7-) Ödemeler
            3.8-) Giriş Çıkışlar
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
        private void ChildFormOpen(Form childForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }

            aktifForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // 3-)

        // 3.1-)
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new HomePage());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnMainPage.Text;
        }
        
        // 3.2-)
        private void btnMembers_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new MemberPage());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnMembers.Text;
        }

        // 3.3-)
        private void btnMembershipTypes_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new MembershipTypes());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnMembershipTypes.Text;
        }

        // 3.3-)
        private void btnParticipationHistory_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new ParticipationHistory());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnParticipationHistory.Text;
        }

        // 3.4-)
        private void btnTrainers_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new TrainersPage());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnTrainers.Text;
        }

        // 3.5-)
        private void btnExercises_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new Exercise());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnExercises.Text;
        }

        // 3.6-)
        private void btnTraningLists_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new WorkoutList());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnWorkoutLists.Text;
        }

        // 3.7-)
        private void btnPayments_Click(object sender, EventArgs e)
        {
            ChildFormOpen(new Payments());
            lblTitle.Text = "Spor Salonu Üye Yönetim Sistemi | " + btnPayments.Text;
        }

        // 3.8-)
        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
