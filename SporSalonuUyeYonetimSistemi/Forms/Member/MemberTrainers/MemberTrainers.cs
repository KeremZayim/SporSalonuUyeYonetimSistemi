﻿using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberTrainers : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Antrenör Öğrencisini Sil (DeleteMemberTrainerAsync)
            3-) Butonlar
                3.1-) Ekle
                3.2-) Sil
                3.3-) Formu Kapat

         */

        string memberID;
        public MemberTrainers(string memberID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }

        // 1-)
        private void ButtonControl()
        {
            if (dtMemberTrainers.SelectedItems.Count > 0)
            {
                btnDeleteTrainer.Enabled = true;
            }
            else
            {
                btnDeleteTrainer.Enabled = false;
            }
        }

        // 2-)
        private async Task DeleteMemberTrainerAsync(string memberId, string trainerId)
        {
            DialogResult result = MessageBox.Show(
                "Bu üyenin antrenörünü silmek istediğinize emin misiniz?",
                "Onayla",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                    {
                        await connection.OpenAsync();

                        string query = "DELETE FROM member_trainers WHERE member_id = @memberId AND trainer_id = @trainerId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@memberId", memberId);
                            command.Parameters.AddWithValue("@trainerId", trainerId);

                            int affectedRows = await command.ExecuteNonQueryAsync();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Üyenin antrenörü başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen üye-antrenör eşleşmesi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void MemberTrainers_Shown(object sender, EventArgs e)
        {
            string query = @"
                SELECT t.trainer_id, t.trainer_name, t.trainer_surname, t.phone_number
                FROM member_trainers mt
                JOIN trainers t ON mt.trainer_id = t.trainer_id
                WHERE mt.member_id = '" + memberID + "'";
            await Functions.GetDatasManualAsync(query, dtMemberTrainers);
        }
        private void dtMemberTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnAddTrainer_Click(object sender, EventArgs e)
        {
            AddMemberTrainer addMemberTrainer = new AddMemberTrainer(memberID);
            addMemberTrainer.ShowDialog();
            string query = @"
                SELECT t.trainer_id, t.trainer_name, t.trainer_surname, t.phone_number
                FROM member_trainers mt
                JOIN trainers t ON mt.trainer_id = t.trainer_id
                WHERE mt.member_id = '" + memberID + "'";
            await Functions.GetDatasManualAsync(query, dtMemberTrainers);
        }

        // 3.2-)
        private async void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            string memberId = memberID;
            string trainerId = dtMemberTrainers.SelectedItems[0].SubItems[0].Text;
            await DeleteMemberTrainerAsync(memberId, trainerId);
            string query = @"
                             SELECT t.trainer_id, t.trainer_name, t.trainer_surname, t.phone_number
                             FROM member_trainers mt
                             JOIN trainers t ON mt.trainer_id = t.trainer_id
                             WHERE mt.member_id = '" + memberID + "'";
            await Functions.GetDatasManualAsync(query, dtMemberTrainers);
        }

        // 3.3-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
