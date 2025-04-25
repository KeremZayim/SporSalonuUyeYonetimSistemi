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

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class AddTrainer : MaterialForm
    {
        public AddTrainer()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }
        public static async Task VeriEkleAsync(string trainerName, string trainerSurname, string phoneNumber)
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

        private async void btnAddTrainer_Click(object sender, EventArgs e)
        {
            if (tbTrainerName.Text != "" && tbTrainerSurname.Text != "" && tbTrainerPhoneNumber.Text.Length == 11)
            {
                string ad = tbTrainerName.Text;
                string soyad = tbTrainerSurname.Text;
                string telno = tbTrainerPhoneNumber.Text;

                await VeriEkleAsync(ad, soyad, telno);
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

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
