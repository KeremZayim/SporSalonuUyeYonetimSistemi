using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class TrainersPage : MaterialForm
    {
        /*

            1-) Antrenör Silme (TrainerDelete)
            2-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            3-) Butonlar
                3.1-) Öğrenciler
                3.2-) Ekle
                3.3-) Düzenle
                3.4-) Sil

         */

        public TrainersPage()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        // 1-)
        private async Task TrainerDelete(int trainerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await con.OpenAsync();

                    string query = "DELETE FROM trainers WHERE trainer_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", trainerId);
                        int result = await cmd.ExecuteNonQueryAsync();

                        if (result > 0)
                        {
                            MessageBox.Show("Antrenör ve ilişkili tüm veriler başarıyla silindi.");
                            await Functions.GetDatasAsync("trainers", dtTrainerInfo);
                        }
                        else
                        {
                            MessageBox.Show("Antrenör bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        // 2-)
        private void ButtonControl()
        {
            bool aktiflik;
            if (dtTrainerInfo.SelectedItems.Count > 0)
            {
                aktiflik = false;
            }
            else
            {
                aktiflik = true;
            }
            foreach (Control item in tabTrainers.Controls)
            {
                if (item is MaterialButton materialButton)
                {
                    if (materialButton.Name != "btnAddTrainer")
                    {
                        materialButton.Enabled = !aktiflik;
                    }
                }
            }
        }
        private async void TrainersPage_Shown(object sender, EventArgs e)
        {
            await Functions.GetDatasAsync("trainers", dtTrainerInfo);
        }
        private void dtTrainerInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnStudents_Click(object sender, EventArgs e)
        {
            string trainerID = dtTrainerInfo.SelectedItems[0].SubItems[0].Text;
            TrainerStudents trainerStudents = new TrainerStudents(trainerID);
            trainerStudents.ShowDialog();
            await Functions.GetDatasAsync("trainers", dtTrainerInfo);
            dtTrainerInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.2-)
        private async void btnAddTrainer_Click(object sender, EventArgs e)
        {
            AddTrainer addTrainer = new AddTrainer();
            addTrainer.ShowDialog();
            await Functions.GetDatasAsync("trainers", dtTrainerInfo);
            dtTrainerInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.3-)
        private async void btnEditTrainer_Click(object sender, EventArgs e)
        {
            string trainerID = dtTrainerInfo.SelectedItems[0].SubItems[0].Text;
            EditTrainer trainerStudents = new EditTrainer(trainerID);
            trainerStudents.ShowDialog();
            await Functions.GetDatasAsync("trainers", dtTrainerInfo);
            dtTrainerInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.4-)
        private async void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (dtTrainerInfo.SelectedItems.Count > 0)
            {
                int trainerId = Convert.ToInt32(dtTrainerInfo.SelectedItems[0].SubItems[0].Text);

                DialogResult result = MessageBox.Show(
                    $"Seçilen antrenörü (ID: {trainerId}) silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    await TrainerDelete(trainerId);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz antrenörü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
