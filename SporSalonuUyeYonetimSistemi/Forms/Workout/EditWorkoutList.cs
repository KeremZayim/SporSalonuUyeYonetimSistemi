using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    public partial class EditWorkoutList : MaterialForm
    {

        /*

            1-) Bilgileri Forma Doldurma (LoadWorkoutList)
            2-) Bilgileri Güncelleme (UpdateWorkoutListAsync)
            3-) Butonlar
                3.1-) Düzenleme
                3.2-) Form Kapatma

         */

        string workoutID;
        public EditWorkoutList(string workoutID)
        {
            InitializeComponent();
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.workoutID = workoutID;
        }

        // 1-)
        private async Task LoadWorkoutList(string workoutId)
        {
            string query = "SELECT workout_name, target_area, workout_day FROM workout_list WHERE workout_id = @id";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", workoutId);
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tbWorkoutName.Text = reader["workout_name"].ToString();
                                tbTargetArea.Text = reader["target_area"].ToString();
                                tbWorkoutDay.Text = reader["workout_day"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Antrenman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2-)
        private async Task UpdateWorkoutListAsync(string workoutId)
        {
            string query = "UPDATE workout_list SET workout_name = @workout_name, target_area = @target_area, workout_day = @workout_day WHERE workout_id = @id";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@workout_name", tbWorkoutName.Text);
                        command.Parameters.AddWithValue("@target_area", tbTargetArea.Text);
                        command.Parameters.AddWithValue("@workout_day", tbWorkoutDay.Text);
                        command.Parameters.AddWithValue("@id", workoutId);

                        int affectedRows = await command.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Antrenman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void EditWorkoutList_Shown(object sender, EventArgs e)
        {
            await LoadWorkoutList(workoutID);
        }

        // 3-)
        // 3.1-)
        private async void btnEditWorkoutList_Click(object sender, EventArgs e)
        {
            await UpdateWorkoutListAsync(workoutID);
        }

        // 3.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
