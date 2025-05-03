using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class AddMemberTrainer : MaterialForm
    {

        /*

            1-) Combobox'a Antrenörleri Listeler (GetTrainerAsync)
            2-) Üyeye Antrenör Ata (AddMemberTrainerAsync)
            3-) Butonlar
                3.1-) Ekle
                3.2-) Formu Kapat

         */

        string memberID;
        public AddMemberTrainer(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }
        private Dictionary<string, int> trainerDictionary = new Dictionary<string, int>();

        private async Task GetTrainerAsync()
        {
            try
            {
                cbTrainers.Items.Clear();
                trainerDictionary.Clear();

                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT trainer_id, trainer_name, trainer_surname FROM trainers";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int trainerId = reader.GetInt32(0);
                                string trainerName = reader.GetString(1).Trim();
                                string trainerSurname = reader.GetString(2).Trim();
                                string fullName = $"{trainerName} {trainerSurname}";

                                trainerDictionary.Add(fullName, trainerId);
                                cbTrainers.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Antrenörler alınırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task AddMemberTrainerAsync(string memberId)
        {
            if (cbTrainers.SelectedIndex != -1)
            {
                string selectedTrainerName = cbTrainers.SelectedItem.ToString();

                if (trainerDictionary.TryGetValue(selectedTrainerName, out int trainerId))
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                        {
                            await connection.OpenAsync();

                            string checkQuery = "SELECT COUNT(*) FROM member_trainers WHERE member_id = @memberId AND trainer_id = @trainerId";

                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@memberId", memberId);
                                checkCommand.Parameters.AddWithValue("@trainerId", trainerId);

                                int existingCount = (int)await checkCommand.ExecuteScalarAsync();

                                if (existingCount > 0)
                                {
                                    MessageBox.Show("Bu antrenör zaten bu üyeye eklenmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            string insertQuery = "INSERT INTO member_trainers (member_id, trainer_id) VALUES (@memberId, @trainerId)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@memberId", memberId);
                                insertCommand.Parameters.AddWithValue("@trainerId", trainerId);

                                await insertCommand.ExecuteNonQueryAsync();
                                MessageBox.Show("Antrenör başarıyla üyeye eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Antrenör eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen antrenör bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir antrenör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void AddMemberTrainer_Shown(object sender, EventArgs e)
        {
            await GetTrainerAsync();
        }

        // 3-)
        // 3.1-)
        private async void btnAddTrainer_Click(object sender, EventArgs e)
        {
            await AddMemberTrainerAsync(memberID);
        }

        // 3.2-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
