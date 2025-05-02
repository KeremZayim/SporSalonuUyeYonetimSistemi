using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    public partial class EditWorkoutList : MaterialForm
    {
        string workoutID;
        public EditWorkoutList(string workoutID)
        {
            InitializeComponent();
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.workoutID = workoutID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async Task LoadWorkoutList(string workoutId)
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
        public async Task UpdateWorkoutListAsync(string workoutId)
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

        private async void btnEditWorkoutList_Click(object sender, EventArgs e)
        {
            await UpdateWorkoutListAsync(workoutID);
        }
    }
}
