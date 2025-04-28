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
    public partial class Exercise : Form
    {
        public Exercise()
        {
            InitializeComponent();
        }

        private async void Exercise_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("exercise", dtExercise);
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

            // İlk seçili öğeyi alıyoruz
            ListViewItem selectedItem = listView.SelectedItems[0];

            // ID bilgisini çekiyoruz (ID sütununun indexi 0 ise)
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
    }
}
