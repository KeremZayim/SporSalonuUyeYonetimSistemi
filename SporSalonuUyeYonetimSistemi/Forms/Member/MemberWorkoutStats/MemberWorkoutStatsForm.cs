using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutStats
{
    public partial class MemberWorkoutStatsForm : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Üye Antrenman Listesi Silme
            3-) Butonlar
                3.1-) Ekle
                3.2-) Düzenle
                3.3-) Sil
                3.4-) Formu Kapat

         */

        readonly string memberID;
        public MemberWorkoutStatsForm(string memberID)
        {
            InitializeComponent();
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }
        private async void MemberWorkoutStatsForm_Shown(object sender, EventArgs e)
        {
            await Functions.GetDataByMemberIDAsync("workout_stats", memberID, dtMemberWorkoutStats);
        }

        // 1-)
        private void ButtonControl()
        {
            if (dtMemberWorkoutStats.SelectedItems.Count > 0)
            {
                btnDeleteWorkoutStats.Enabled = true;
                btnEditWorkoutStats.Enabled = true;
            }
            else
            {
                btnEditWorkoutStats.Enabled = false;
                btnDeleteWorkoutStats.Enabled = false;
            }
        }

        // 2-)
        private async Task DeleteWorkoutStatAsync(string workoutId)
        {
            if (string.IsNullOrEmpty(workoutId))
            {
                MessageBox.Show("Geçerli bir Workout ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bu egzersiz kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string deleteQuery = "DELETE FROM workout_stats WHERE workout_id = @id";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", workoutId);

                        int affected = await cmd.ExecuteNonQueryAsync();

                        if (affected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID'ye ait kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtMemberWorkoutStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnAddWorkoutList_Click(object sender, EventArgs e)
        {
            MemberWorkoutAddStatsForm memberWorkoutAddStatsForm = new MemberWorkoutAddStatsForm(memberID);
            memberWorkoutAddStatsForm.ShowDialog();
            dtMemberWorkoutStats.SelectedItems.Clear();
            await Functions.GetDataByMemberIDAsync("workout_stats", memberID, dtMemberWorkoutStats);
        }

        // 3.2-)
        private async void btnEditWorkoutStats_Click(object sender, EventArgs e)
        {
            string workoutID = dtMemberWorkoutStats.SelectedItems[0].SubItems[0].Text.Trim();
            MemberWorkoutEditStatsForm memberWorkoutEditStatsForm = new MemberWorkoutEditStatsForm(workoutID);
            memberWorkoutEditStatsForm.ShowDialog();
            dtMemberWorkoutStats.SelectedItems.Clear();
            await Functions.GetDataByMemberIDAsync("workout_stats", memberID, dtMemberWorkoutStats);
        }

        // 3.3-)
        private async void btnDeleteWorkoutStats_Click(object sender, EventArgs e)
        {
            string WorkoutID = dtMemberWorkoutStats.SelectedItems[0].SubItems[0].Text.Trim();
            await DeleteWorkoutStatAsync(WorkoutID);
            dtMemberWorkoutStats.SelectedItems.Clear();
            await Functions.GetDataByMemberIDAsync("workout_stats", memberID, dtMemberWorkoutStats);
        }

        // 3.4-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
