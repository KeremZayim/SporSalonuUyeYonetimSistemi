using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutStats
{
    public partial class MemberWorkoutAddStatsForm : MaterialForm
    {

        /*

            1-) Antrenman İstatistiği Ekle (AddWorkoutStatsAsync)
            2-) Combobox'ı Antrenman Listeleriyle Doldurma (LoadWorkoutsAsync)
            3-) Combobox'ta İki Veriyi Tutma (ComboBoxItem)
            4-) Butonlar
                4.1-) Ekle
                4.2-) Formu Kapat

         */

        string memberID;
        public MemberWorkoutAddStatsForm(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }
        private async void MemberWorkoutAddStatsForm_Shown(object sender, EventArgs e)
        {
            await LoadWorkoutsAsync(memberID);
        }

        // 1-)
        private async Task AddWorkoutStatsAsync(string memberId)
        {
            if (Convert.ToInt32(memberId) <= 0 || cbWorkouts.SelectedItem == null)
            {
                MessageBox.Show("Üye ve antrenman seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbHeight.Text.Trim(), out decimal height) ||
                !decimal.TryParse(tbWeight.Text.Trim(), out decimal weight) ||
                !decimal.TryParse(tbBodyFatPercentage.Text.Trim(), out decimal bodyFat) ||
                !decimal.TryParse(tbMuscleMass.Text.Trim(), out decimal muscleMass))
            {
                MessageBox.Show("Lütfen eksiksiz ve geçerli sayısal değerler girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string goal = tbGoal.Text.Trim();
            int workoutId = ((ComboBoxItem)cbWorkouts.SelectedItem).Value;

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
            INSERT INTO workout_stats 
                (member_id, height, weight, body_fat_percentage, muscle_mass, goal)
            VALUES 
                (@memberId, @height, @weight, @bodyFat, @muscleMass, @goal)";

                try
                {
                    await conn.OpenAsync();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@bodyFat", bodyFat);
                        cmd.Parameters.AddWithValue("@muscleMass", muscleMass);
                        cmd.Parameters.AddWithValue("@goal", goal);

                        await cmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Veriler başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // 2-)
        private async Task LoadWorkoutsAsync(string memberId)
        {
            cbWorkouts.Items.Clear();

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                // member_id'ye göre workout'ları listelemek için WHERE koşulu ekliyoruz.
                string query = @"
            SELECT w.workout_id, w.workout_name 
            FROM workout_list w
            INNER JOIN workout_stats ws ON ws.workout_id = w.workout_id
            WHERE ws.member_id = @MemberId";

                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Parametreyi ekliyoruz.
                        cmd.Parameters.AddWithValue("@MemberId", memberId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int workoutId = Convert.ToInt32(reader["workout_id"]);
                                string workoutName = reader["workout_name"].ToString();

                                cbWorkouts.Items.Add(new ComboBoxItem
                                {
                                    Text = workoutName,
                                    Value = workoutId
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Antrenmanlar yüklenirken hata oluştu: " + ex.Message);
                }
            }

            if (cbWorkouts.Items.Count > 0)
                cbWorkouts.SelectedIndex = 0;
        }


        // 3-)
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        // 4-)
        // 4.1-)
        private async void btnAddWorkoutStats_Click(object sender, EventArgs e)
        {
            await AddWorkoutStatsAsync(memberID);
        }

        // 4.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
