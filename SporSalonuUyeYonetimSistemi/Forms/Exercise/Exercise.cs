﻿using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Exercise
{
    public partial class Exercise : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Egzersizi Sil (DeleteSelectedExerciseAsync)
            3-) Üye ID'sini Bul (GetMemberIdAsync)
            4-) Seçili Üyeye Göre Filtre
            5-) Butonlar
                5.1-) Ekle
                5.2-) Düzenle
                5.3-) Sil

         */

        public Exercise()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        private async void Exercise_Shown(object sender, EventArgs e)
        {
            string query = @"
                            SELECT 
                                e.exercise_id,
                                e.exercise_name, 
                                e.set_count, 
                                e.repetition_count, 
                                w.workout_id,
                                m.member_name + ' ' + m.member_surname AS Üye
                            FROM exercise e
                            INNER JOIN workout_list w ON e.workout_id = w.workout_id
                            INNER JOIN members m ON w.member_id = m.member_id";


            await Functions.GetDatasManualAsync(query, dtExercise);
            await Functions.FillMemberList(cbMember);
        }

        // 1-)
        void ButtonControl()
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
        
        // 2-)
        private static async Task DeleteSelectedExerciseAsync(MaterialListView listView)
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
            ButtonControl();
        }

        // 3-)
        private async Task<string> GetMemberIdAsync(string fullName)
        {
            string memberId = null;

            string[] parts = fullName.Split(' ');
            if (parts.Length < 2)
                return null;

            string firstName = parts[0];
            string lastName = parts[1];

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await conn.OpenAsync();

                string query = "SELECT member_id FROM members WHERE member_name = @firstName AND member_surname = @lastName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

                    var result = await cmd.ExecuteScalarAsync();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                        memberId = id.ToString();
                }
            }

            return memberId;
        }

        // 4-)
        private async void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex != -1)
            {
                if (cbMember.SelectedItem.ToString() == "Herkes")
                {
                    string query = @"
                            SELECT 
                                e.exercise_id,
                                e.exercise_name, 
                                e.set_count, 
                                e.repetition_count, 
                                w.workout_id,
                                m.member_name + ' ' + m.member_surname AS Üye
                            FROM exercise e
                            INNER JOIN workout_list w ON e.workout_id = w.workout_id
                            INNER JOIN members m ON w.member_id = m.member_id";


                    await Functions.GetDatasManualAsync(query, dtExercise);
                }
                else
                {
                    string memberID = await GetMemberIdAsync(cbMember.SelectedItem.ToString().Trim());
                    string query = $@"
                            SELECT 
                                e.exercise_id,
                                e.exercise_name, 
                                e.set_count, 
                                e.repetition_count, 
                                w.workout_id,
                                m.member_name + ' ' + m.member_surname AS Üye
                            FROM exercise e
                            INNER JOIN workout_list w ON e.workout_id = w.workout_id
                            INNER JOIN members m ON w.member_id = m.member_id
                            WHERE m.member_id = {memberID}";

                    await Functions.GetDatasManualAsync(query, dtExercise);
                }
            }
        }

        // 5-)
        // 5.1-)
        private async void btnAddExercise_Click(object sender, EventArgs e)
        {
            AddExercise addExercise = new AddExercise();
            addExercise.ShowDialog();
            await Functions.GetDatasAsync("exercise", dtExercise);
            dtExercise.SelectedItems.Clear();
        }

        // 5.2-)
        private async void btnEditExercise_Click(object sender, EventArgs e)
        {
            string exerciseID = dtExercise.SelectedItems[0].SubItems[0].Text.ToString().Trim();
            EditExercise editExercise = new EditExercise(exerciseID);
            editExercise.ShowDialog();
            string query = @"
                            SELECT 
                                e.exercise_id,
                                e.exercise_name, 
                                e.set_count, 
                                e.repetition_count, 
                                w.workout_id,
                                m.member_name + ' ' + m.member_surname AS Üye
                            FROM exercise e
                            INNER JOIN workout_list w ON e.workout_id = w.workout_id
                            INNER JOIN members m ON w.member_id = m.member_id";


            await Functions.GetDatasManualAsync(query, dtExercise);
            dtExercise.SelectedItems.Clear();
            ButtonControl();
        }

        // 5.3-)
        private async void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            await DeleteSelectedExerciseAsync(dtExercise);
            await Functions.GetDatasAsync("exercise", dtExercise);
            dtExercise.SelectedItems.Clear();
        }
    }
}
