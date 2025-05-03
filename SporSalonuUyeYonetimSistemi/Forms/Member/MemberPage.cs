using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutList;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation
{
    public partial class MemberPage : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Üye Sil (DeleteMemberAsync)
            3-) Butonlar
                3.1-) Üye Ekle
                3.2-) Üye Düzenle
                3.3-) Üye Sil
                3.4-) Üyelik Bilgileri
                3.5-) Sağlık Bilgileri
                3.6-) Antrenörler
                3.7-) Antrenman Bilgileri
                3.8-) Antrenman Listeleri
                3.9-) Ödeme Bilgileri
                3.10-) Giriş-Çıkışlar

         */

        public MemberPage()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }
        private async void MemberPage_Shown(object sender, EventArgs e)
        {
            await Functions.GetDatasAsync("members", dtMemberInfo);
        }

        // 1-)
        private void ButtonControl()
        {
            bool aktiflik;
            if (dtMemberInfo.SelectedItems.Count > 0)
            {
                aktiflik = true;
            }
            else
            {
                aktiflik = false;
            }
            foreach (Control item in tabMemberInfo.Controls)
            {
                if (item is MaterialButton materialButton)
                {
                    if (materialButton.Name != "btnAddMember")
                    {
                        materialButton.Enabled = aktiflik;
                    }
                }
            }
        }

        // 2-)
        private static async Task DeleteMemberAsync(int memberId)
        {
            DialogResult result = MessageBox.Show("Üyeyi ve tüm bağlı verileri silmek istediğinizden emin misiniz?",
                                                  "Onay",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                    {
                        await connection.OpenAsync();

                        string query = "DELETE FROM members WHERE member_id = @memberId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@memberId", memberId);

                            int rowsAffected = await command.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Üye ve tüm bağlı verileri başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen ID'ye sahip bir üye bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Üye silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Üye silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtMemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private void btnAddMember_Click(object sender, EventArgs e)
        {

        }

        // 3.2-)
        private void btnEditMember_Click(object sender, EventArgs e)
        {

        }

        // 3.3-)
        private async void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dtMemberInfo.SelectedItems[0].SubItems[0].Text, out int memberId))
            {
                await DeleteMemberAsync(memberId);
            }
            else
            {
                MessageBox.Show("Geçerli bir MemberID girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            await Functions.GetDatasAsync("members", dtMemberInfo);
        }

        // 3.4-)
        private void btnMembership_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberMemberships membershipsForm = new MemberMemberships(memberId);
            membershipsForm.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.5-)
        private void btnHealthInfo_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberHealthInformation membershipsForm = new MemberHealthInformation(memberId);
            membershipsForm.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.6-)
        private void btnMemberTrainers_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberTrainers membershipsForm = new MemberTrainers(memberId);
            membershipsForm.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.7-)
        private void btnTrainingInfo_Click(object sender, EventArgs e)
        {

        }

        // 3.8-)
        private void btnWorkoutList_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberWorkoutListForm memberWorkoutList = new MemberWorkoutListForm(memberId);
            memberWorkoutList.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.9-)
        private void btnPayments_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberPayments paymentsForm = new MemberPayments(memberId);
            paymentsForm.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.10-)
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberParticipationHistory membershipsForm = new MemberParticipationHistory(memberId);
            membershipsForm.ShowDialog();
            dtMemberInfo.SelectedItems.Clear();
            ButtonControl();
        }

    }
}
