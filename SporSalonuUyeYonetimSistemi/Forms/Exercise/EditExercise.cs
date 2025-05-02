using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    public partial class EditExercise : MaterialForm
    {

        /*

            1-) Combobox'lara 1-100 Arası Sayıları Ekler (NumberFill)
            2-) Forma Egzersizin Bilgilerini Doldurur (LoadExerciseByIdAsync)
            3-) Düzenle (UpdateExerciseAsync)
            4-) Butonlar
                4.1-) Düzenle
                4.2-) Formu Kapat

         */

        readonly string exerciseID;
        public EditExercise(string exerciseID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.exerciseID = exerciseID;
            NumberFill(cbRepetitionCount);
            NumberFill(cbSetCount);
        }

        // 1-)
        private void NumberFill(MaterialComboBox cb)
        {
            for (int i = 1; i <= 100; i++)
            {
                cb.Items.Add(i.ToString());
            }
        }

        // 2-)
        private  async Task LoadExerciseByIdAsync(string exerciseId)
        {
            string query = @"
                            SELECT exercise_name, set_count, repetition_count
                            FROM exercise
                            WHERE exercise_id = @exerciseId
                            ";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@exerciseId", exerciseId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            string exerciseName = reader["exercise_name"].ToString().Trim();
                            string setCount = reader["set_count"].ToString().Trim();
                            string repetitionCount = reader["repetition_count"].ToString().Trim();

                            tbExerciseName.Text = exerciseName;

                            if (cbSetCount.Items.Contains(setCount))
                            {
                                cbSetCount.SelectedItem = setCount;
                                cbSetCount.Refresh();
                            }
                            if (cbRepetitionCount.Items.Contains(repetitionCount))
                            {
                                cbRepetitionCount.SelectedItem = repetitionCount;
                                cbRepetitionCount.Refresh();
                            }
                        }
                    }
                }
            }
        }

        // 3-)
        private async Task UpdateExerciseAsync(string exerciseId)
        {
            string name = tbExerciseName.Text.Trim();
            string setText = cbSetCount.Text;
            string repetitionText = cbRepetitionCount.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Egzersiz adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(setText, out int setCount) || !int.TryParse(repetitionText, out int repetitionCount))
            {
                MessageBox.Show("Set veya tekrar sayısı geçerli değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                            UPDATE exercise
                            SET exercise_name = @name,
                                set_count = @setCount,
                                repetition_count = @repetitionCount
                            WHERE exercise_id = @exerciseId
                            ";

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@setCount", setCount);
                        command.Parameters.AddWithValue("@repetitionCount", repetitionCount);
                        command.Parameters.AddWithValue("@exerciseId", exerciseId);

                        int affected = await command.ExecuteNonQueryAsync();

                        if (affected > 0)
                        {
                            MessageBox.Show("Egzersiz başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Egzersiz bulunamadı veya güncellenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void EditExercise_Shown(object sender, EventArgs e)
        {
            await LoadExerciseByIdAsync(exerciseID);
        }

        // 4-)
        // 4.1-)
        private async void btnEditExercise_Click(object sender, EventArgs e)
        {
            await UpdateExerciseAsync(exerciseID);
        }

        // 4.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
