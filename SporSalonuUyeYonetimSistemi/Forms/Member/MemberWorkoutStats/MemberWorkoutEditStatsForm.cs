using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutStats
{
    public partial class MemberWorkoutEditStatsForm : MaterialForm
    {

        /*

            1-) Forma Verileri Yükleme (LoadWorkoutStatsByIdAsync)
            2-) Düzenle (UpdateWorkoutStatsAsync)
            3-) Butonlar
                3.1-) Düzenle
                3.2-) Formu Kapat

         */
        readonly string workoutID;
        public MemberWorkoutEditStatsForm(string workoutID)
        {
            InitializeComponent();
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.workoutID = workoutID;
        }

        private async void MemberWorkoutEditStatsForm_Shown(object sender, EventArgs e)
        {
            await LoadWorkoutStatsByIdAsync(workoutID);
        }

        // 1-)
        private async Task LoadWorkoutStatsByIdAsync(string workoutId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
            SELECT height, weight, body_fat_percentage, muscle_mass, goal
            FROM workout_stats
            WHERE workout_id = @workoutId";

                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@workoutId", workoutId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tbHeight.Text = reader["height"]?.ToString();
                                tbWeight.Text = reader["weight"]?.ToString();
                                tbBodyFatPercentage.Text = reader["body_fat_percentage"]?.ToString();
                                tbMuscleMass.Text = reader["muscle_mass"]?.ToString();
                                tbGoal.Text = reader["goal"]?.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Bu Workout ID'ye ait kayıt bulunamadı.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2-)
        private async Task UpdateWorkoutStatsAsync(string workoutId)
        {
            if (!int.TryParse(workoutId, out int workout_id) || workout_id <= 0)
            {
                MessageBox.Show("Geçerli bir Workout ID girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbHeight.Text.Trim(), out decimal height) ||
                !decimal.TryParse(tbWeight.Text.Trim(), out decimal weight) ||
                !decimal.TryParse(tbBodyFatPercentage.Text.Trim(), out decimal bodyFat) ||
                !decimal.TryParse(tbMuscleMass.Text.Trim(), out decimal muscleMass))
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string goal = tbGoal.Text.Trim();

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
            UPDATE workout_stats
            SET 
                height = @height,
                weight = @weight,
                body_fat_percentage = @bodyFat,
                muscle_mass = @muscleMass,
                goal = @goal
            WHERE workout_id = @workoutId";

                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@workoutId", workoutId);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@bodyFat", bodyFat);
                        cmd.Parameters.AddWithValue("@muscleMass", muscleMass);
                        cmd.Parameters.AddWithValue("@goal", goal);

                        int affectedRows = await cmd.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen Workout ID'ye ait kayıt bulunamadı.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // 3-)
        // 3.1-)
        private async void btnEditWorkoutStats_Click(object sender, EventArgs e)
        {
            await UpdateWorkoutStatsAsync(workoutID);
        }

        // 3.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
