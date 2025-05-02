using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class AddTrainer : MaterialForm
    {
        /*

            1-) Antrenör Ekle (AddTrainerAsync)
            2-) Butonlar
                2.1-) Antrenör Ekle
                2.2-) Formu Kapat

         */

        public AddTrainer()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbTrainerPhoneNumber.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        // 1-)
        private static async Task AddTrainerAsync(string trainerName, string trainerSurname, string phoneNumber)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await con.OpenAsync();

                    string query = "INSERT INTO trainers (trainer_name, trainer_surname, phone_number) " +
                                   "VALUES (@trainer_name, @trainer_surname, @phone_number)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@trainer_name", trainerName);
                        cmd.Parameters.AddWithValue("@trainer_surname", trainerSurname);
                        cmd.Parameters.AddWithValue("@phone_number", phoneNumber);

                        int result = await cmd.ExecuteNonQueryAsync();

                        if (result > 0)
                        {
                            Console.WriteLine("Veri başarıyla eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Veri eklenirken bir sorun oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        // 2-)
        // 2.1-)
        private async void btnAddTrainer_Click(object sender, EventArgs e)
        {
            if (tbTrainerName.Text != "" && tbTrainerSurname.Text != "" && tbTrainerPhoneNumber.Text.Length == 11)
            {
                string ad = tbTrainerName.Text;
                string soyad = tbTrainerSurname.Text;
                string telno = tbTrainerPhoneNumber.Text;

                await AddTrainerAsync(ad, soyad, telno);
                MessageBox.Show("Antrenör Başarıyla Eklendi");
                this.Close();
            }
            else
            {
                if (tbTrainerPhoneNumber.Text == "")
                {
                    MessageBox.Show("Lütfen Boşluk Bırakmayın!");
                }
                else
                {
                    MessageBox.Show("Lütfen Telefon Numarasını Düzgün Yazın: 0(5xx xxx xx xx");
                }

            }
        }

        // 2.2-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
