using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    public partial class AddExercise : MaterialForm
    {

        /*

            1-) Combobox'ta İki Veriyi De Saklayan Class (ComboBoxItem)
            2-) Combobox'a 1-100 Arası Sayıları Ekler (NumberFill)
            3-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            4-) Combobox'a Üyeleri Doldurur (LoadMembersAsync)
            5-) Combobox'a Antrenman Adlarını Doldurur (LoadWorkoutsAsync)
            6-) Egzersiz Ekle (AddExerciseAsync)
            7-) Butonlar
                7.1-) Ekle
                7.2-) Formu Kapat

         */

        // 1-)
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public AddExercise()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            NumberFill(cbSetCount);
            NumberFill(cbRepetitionCount);
        }

        private async void AddExercise_Shown(object sender, EventArgs e)
        {
            await LoadMembersAsync();
        }

        // 2-)
        private void NumberFill(MaterialComboBox cb)
        {
            for (int i = 1; i <= 100; i++)
            {
                cb.Items.Add(i.ToString());
            }
        }

        // 3-)
        private void ButtonControl()
        {
            if (cbMember.SelectedItem != null)
            {
                tbExerciseName.Enabled = true;
                cbRepetitionCount.Enabled = true;
                cbSetCount.Enabled = true;
                cbWorkout.Enabled = true;
            }
            else
            {
                tbExerciseName.Enabled = false;
                cbRepetitionCount.Enabled = false;
                cbSetCount.Enabled = false;
                cbWorkout.Enabled = false;
            }
        }

        // 4-)
        private async Task LoadMembersAsync()
        {
            cbMember.Items.Clear();

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT member_id, member_name, member_surname FROM members";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int memberId = reader.GetInt32(0);
                            string fullName = $"{reader.GetString(1).Trim()} {reader.GetString(2).Trim()}";

                            cbMember.Items.Add(new ComboBoxItem(fullName, memberId));
                        }
                    }
                }
            }
        }

        // 5-)
        private async Task LoadWorkoutsAsync(string memberId)
        {
            cbWorkout.Items.Clear();

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT workout_id, workout_name FROM workout_list WHERE member_id = @memberId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@memberId", memberId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int workoutId = reader.GetInt32(0);
                            string workoutName = reader.GetString(1).Trim();

                            cbWorkout.Items.Add(new ComboBoxItem(workoutName, workoutId));
                        }
                    }
                }
            }
        }

        // 6-)
        private async Task AddExerciseAsync()
        {
            if (cbWorkout.SelectedItem == null || cbSetCount.SelectedItem == null || cbRepetitionCount.SelectedItem == null || string.IsNullOrWhiteSpace(tbExerciseName.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedWorkoutName = cbWorkout.SelectedItem.ToString();
            string exerciseName = tbExerciseName.Text.Trim();
            int setCount = Convert.ToInt32(cbSetCount.SelectedItem);
            int repetitionCount = Convert.ToInt32(cbRepetitionCount.SelectedItem);

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string selectWorkoutIdQuery = "SELECT workout_id FROM workout_list WHERE workout_name = @workoutName";

                    int? workoutId = null;
                    using (SqlCommand selectCmd = new SqlCommand(selectWorkoutIdQuery, connection))
                    {
                        selectCmd.Parameters.AddWithValue("@workoutName", selectedWorkoutName);
                        object result = await selectCmd.ExecuteScalarAsync();

                        if (result != null)
                            workoutId = Convert.ToInt32(result);
                    }

                    if (workoutId == null)
                    {
                        MessageBox.Show("Seçilen antrenmana ait kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertExerciseQuery = @"INSERT INTO exercise (exercise_Name, set_count, repetition_count, workout_id) 
                                           VALUES (@exerciseName, @setCount, @repetitionCount, @workoutId)";

                    using (SqlCommand insertCmd = new SqlCommand(insertExerciseQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@exerciseName", exerciseName);
                        insertCmd.Parameters.AddWithValue("@setCount", setCount);
                        insertCmd.Parameters.AddWithValue("@repetitionCount", repetitionCount);
                        insertCmd.Parameters.AddWithValue("@workoutId", workoutId.Value);

                        await insertCmd.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("Egzersiz başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();

            if (cbMember.SelectedItem is ComboBoxItem selectedMember)
            {
                string memberId = selectedMember.Value.ToString();
                await LoadWorkoutsAsync(memberId);
            }

            tbExerciseName.Text = "";
            cbSetCount.SelectedIndex = -1;
            cbRepetitionCount.SelectedIndex = -1;
            cbWorkout.SelectedIndex = -1;

            tbExerciseName.Refresh();
            cbSetCount.Refresh();
            cbRepetitionCount.Refresh();
            cbWorkout.Refresh();
        }

        // 7-)
        // 7.1-)
        private async void btnAddExercise_Click(object sender, EventArgs e)
        {
            await AddExerciseAsync();
        }

        // 7.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
