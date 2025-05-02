using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class EditTrainer : MaterialForm
    {

        /*

            1-) Forma Bilgileri Doldurma (GetInformation)
            2-) Antrenman Bilgilerini Düzenle (EditTrainerInfo)
            3-) Butonlar
                3.1-) Düzenle
                3.2-) Formu Kapat

         */

        string trainerID;

        public EditTrainer(string trainerID)
        {
            InitializeComponent();
            this.trainerID = trainerID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbTrainerPhoneNumber.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        // 1-)
        private async Task GetInformation(MaterialTextBox tbTrainerName, MaterialTextBox tbTrainerSurname, MaterialTextBox tbTrainerPhoneNumber, string trainerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await con.OpenAsync();

                    string query = "SELECT trainer_name, trainer_surname, phone_number FROM trainers WHERE trainer_id = @trainerId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@trainerId", trainerId);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tbTrainerName.Text = reader["trainer_name"].ToString().Trim();
                                tbTrainerSurname.Text = reader["trainer_surname"].ToString().Trim();
                                tbTrainerPhoneNumber.Text = reader["phone_number"].ToString().Trim();
                            }
                            else
                            {
                                MessageBox.Show("Antrenör bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekilirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2-)
        private async Task EditTrainerInfo(MaterialTextBox tbTrainerName, MaterialTextBox tbTrainerSurname, MaterialTextBox tbTrainerPhoneNumber, string trainerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await con.OpenAsync();

                    string name = tbTrainerName.Text.Trim();
                    string surname = tbTrainerSurname.Text.Trim();
                    string phone = tbTrainerPhoneNumber.Text.Trim();

                    string query = @"
                                    UPDATE trainers
                                    SET trainer_name = @name,
                                        trainer_surname = @surname,
                                        phone_number = @phone
                                    WHERE trainer_id = @trainerId
                                    ";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@trainerId", trainerId);

                        int affectedRows = await cmd.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Antrenör bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Antrenör bulunamadı veya güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EditTrainer_Shown(object sender, EventArgs e)
        {
            await GetInformation(tbTrainerName, tbTrainerSurname, tbTrainerPhoneNumber, trainerID);
        }

        // 3-)
        // 3.1-)
        private async void btnEditTrainer_Click(object sender, EventArgs e)
        {
            await EditTrainerInfo(tbTrainerName,tbTrainerSurname,tbTrainerPhoneNumber,trainerID);
        }

        // 3.2-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
