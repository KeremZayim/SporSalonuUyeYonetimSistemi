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

namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    public partial class Exercise : MaterialForm
    {
        public Exercise()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        private async Task UyeListesiniDoldurAsync()
        {
            cbMember.Items.Clear();
            cbMember.Items.Add("Herkes");

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand("SELECT member_name, member_surname FROM members", conn))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string ad = reader["member_name"].ToString().Trim();
                            string soyad = reader["member_surname"].ToString().Trim();
                            string fullName = $"{ad} {soyad}";

                            cbMember.Items.Add(fullName);
                        }
                    }
                }
            }

            cbMember.SelectedIndex = 0;
        }

        private async Task EgzersizleriFiltreleAsync()
        {
            if (cbMember.SelectedItem == null)
                return;

            string selectedMember = cbMember.SelectedItem.ToString().Trim();
            dtExercise.Items.Clear();

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await conn.OpenAsync();

                SqlCommand cmd;

                if (selectedMember == "Herkes")
                {
                    cmd = new SqlCommand("SELECT exercise_Name, set_count, repetition_count FROM exercise", conn);
                }
                else
                {
                    string[] adSoyad = selectedMember.Split(' ');

                    if (adSoyad.Length < 2)
                    {
                        MessageBox.Show("Geçerli bir üye seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string ad = adSoyad[0];
                    string soyad = adSoyad[1];

                    // Üyenin ID'sini bul
                    SqlCommand findMemberCmd = new SqlCommand("SELECT member_id FROM members WHERE member_name = @ad AND member_surname = @soyad", conn);
                    findMemberCmd.Parameters.AddWithValue("@ad", ad);
                    findMemberCmd.Parameters.AddWithValue("@soyad", soyad);

                    object result = await findMemberCmd.ExecuteScalarAsync();

                    if (result == null)
                    {
                        MessageBox.Show("Üye bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int uyeId = Convert.ToInt32(result);

                    cmd = new SqlCommand("SELECT exercise_Name, set_count, repetition_count FROM exercise WHERE workout_id IN (SELECT workout_id FROM workout_list WHERE member_id = @uyeId)", conn);
                    cmd.Parameters.AddWithValue("@uyeId", uyeId);
                }

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string exerciseName = reader["exercise_Name"].ToString();
                        string setCount = reader["set_count"].ToString();
                        string repetitionCount = reader["repetition_count"].ToString();

                        ListViewItem item = new ListViewItem(exerciseName);
                        item.SubItems.Add(setCount);
                        item.SubItems.Add(repetitionCount);

                        dtExercise.Items.Add(item);
                    }
                }
            }
        }


        private async void Exercise_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("exercise", dtExercise);
            await UyeListesiniDoldurAsync();
        }

        void buttonControl()
        {
            bool aktiflik;
            if (dtExercise.SelectedItems.Count > 0)
            {
                aktiflik = true;
            }
            else
            {
                aktiflik = false;
            }
            foreach (Control item in tabExercise.Controls)
            {
                if (item is MaterialButton materialButton)
                {
                    if (materialButton.Name != "btnAddExercise")
                    {
                        materialButton.Enabled = aktiflik;
                    }
                }
            }
        }
        public static async Task DeleteSelectedExerciseAsync(MaterialListView listView)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir egzersiz seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listView.SelectedItems[0];

            if (!int.TryParse(selectedItem.SubItems[0].Text, out int selectedExerciseId))
            {
                MessageBox.Show("Seçilen egzersizin ID'si okunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili egzersizi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
                    {
                        await conn.OpenAsync();

                        string query = "DELETE FROM exercise WHERE exercise_id = @exercise_id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@exercise_id", selectedExerciseId);
                            int affectedRows = await cmd.ExecuteNonQueryAsync();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Egzersiz başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Egzersiz silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dtExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl();
        }

        private async void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            await DeleteSelectedExerciseAsync(dtExercise);
            await Functions.VerileriGetirAsync("exercise", dtExercise);
        }

        private async void btnAddExercise_Click(object sender, EventArgs e)
        {
            AddExercise addExercise = new AddExercise();
            addExercise.ShowDialog();
            await Functions.VerileriGetirAsync("exercise", dtExercise);
        }

        private async void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            await EgzersizleriFiltreleAsync();
        }
    }
}
