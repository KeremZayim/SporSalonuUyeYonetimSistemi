using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    public partial class WorkoutList : MaterialForm
    {

        /*

            1-) ViewList'i Doldurma (FillList)
            2-) Antrenman Listesini Silme (DeleteWorkoutAsync)
            3-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            4-) Butonlar
                4.1-) Ekle
                4.2-) Düzenle
                4.3-) Sil

         */

        public WorkoutList()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        // 1-)
        private async void FillList()
        {
            string query = @"
                        SELECT 
                            workout_list.workout_id,
                            members.member_name + ' ' + members.member_surname AS Üye,
                            workout_list.workout_name,
                            workout_list.target_area,
                            workout_list.workout_day
                        FROM workout_list
                        INNER JOIN members ON workout_list.member_id = members.member_id;
                        ";

            await Functions.GetDatasManualAsync(query, dtWorkoutList);
        }

        // 2-)
        private async Task DeleteWorkoutAsync(string workoutId)
        {
            DialogResult result = MessageBox.Show(
                "Bu antrenmanı silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "DELETE FROM workout_list WHERE workout_id = @id";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", workoutId);
                        int affectedRows = await command.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Antrenman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Silinecek antrenman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3-)
        private void ButtonControl()
        {
            if (dtWorkoutList.SelectedItems.Count > 0)
            {
                btnDeleteWorkoutList.Enabled = true;
                btnEditWorkoutList.Enabled = true;
            }
            else
            {
                btnEditWorkoutList.Enabled = false;
                btnDeleteWorkoutList.Enabled = false;
            }
        }

        private void WorkoutList_Shown(object sender, EventArgs e)
        {
            FillList();
        }
        private void dtWorkoutList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 4-)

        // 4.1-)
        private void btnAddWorkoutList_Click(object sender, EventArgs e)
        {
            AddWorkoutList addWorkoutList = new AddWorkoutList();
            addWorkoutList.ShowDialog();
            FillList();
            dtWorkoutList.SelectedItems.Clear();
            ButtonControl();
        }

        // 4.2-)
        private void btnEditWorkoutList_Click(object sender, EventArgs e)
        {
            string workoutID = dtWorkoutList.SelectedItems[0].SubItems[0].Text;
            EditWorkoutList editWorkoutList = new EditWorkoutList(workoutID);
            editWorkoutList.ShowDialog();
            FillList();
            dtWorkoutList.SelectedItems.Clear();
            ButtonControl();
        }

        // 4.3-)
        private async void btnDeleteWorkoutList_Click(object sender, EventArgs e)
        {
            string workout_id = dtWorkoutList.SelectedItems[0].SubItems[0].Text;
            await DeleteWorkoutAsync(workout_id);
            FillList();
        }
    }
}
