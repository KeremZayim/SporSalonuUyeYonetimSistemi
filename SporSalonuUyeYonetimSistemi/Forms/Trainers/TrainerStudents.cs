﻿using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class TrainerStudents : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Butonlar
                2.1-) Ekle
                2.2-) Sil
                2.3-) Formu Kapat

         */

        string trainerID;
        public TrainerStudents(string trainerID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.trainerID = trainerID;
        }

        // 1-)
        private void ButtonControl()
        {
            if (dtTrainerStudents.SelectedItems.Count > 0)
            {
                btnDeleteStudent.Enabled = true;
            }
            else
            {
                btnDeleteStudent.Enabled = false;
            }
        }

        private async void TrainerStudents_Shown(object sender, EventArgs e)
        {
            string query = "SELECT m.member_name, m.member_surname " +
               "FROM member_trainers mt " +
               "JOIN members m ON m.member_id = mt.member_id " +
               "WHERE mt.trainer_id = " + trainerID;

            await Functions.GetDatasManualAsync(query, dtTrainerStudents);
        }
        private void dtTrainerStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 2-)
        // 2.1-)
        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            TrainerStudentAdd trainerStudentAdd = new TrainerStudentAdd(trainerID);
            trainerStudentAdd.ShowDialog();

            string query = "SELECT mt.trainer_id, m.member_id, m.member_name, m.member_surname " +
               "FROM member_trainers mt " +
               "JOIN members m ON m.member_id = mt.member_id " +
               "WHERE mt.trainer_id = " + trainerID;

            await Functions.GetDatasManualAsync(query, dtTrainerStudents);
            dtTrainerStudents.SelectedItems.Clear();
            ButtonControl();
        }

        // 2.2-)
        private async void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dtTrainerStudents.SelectedItems.Count > 0)
            {
                var trainerId = dtTrainerStudents.SelectedItems[0].SubItems[0].Text;
                var memberId = dtTrainerStudents.SelectedItems[0].SubItems[1].Text;

                var result = MessageBox.Show("Bu öğrenciyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    string query = "DELETE FROM member_trainers WHERE trainer_id = @trainerId AND member_id = @memberId";

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
                        {
                            await conn.OpenAsync();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@trainerId", trainerId);
                            cmd.Parameters.AddWithValue("@memberId", memberId);

                            int rowsAffected = await cmd.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Öğrenci başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string query2 = "SELECT mt.trainer_id, m.member_id, m.member_name, m.member_surname " +
               "FROM member_trainers mt " +
               "JOIN members m ON m.member_id = mt.member_id " +
               "WHERE mt.trainer_id = " + trainerID;

                await Functions.GetDatasManualAsync(query2, dtTrainerStudents);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin.", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dtTrainerStudents.SelectedItems.Clear();
            ButtonControl();
        }

        // 2.3-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
