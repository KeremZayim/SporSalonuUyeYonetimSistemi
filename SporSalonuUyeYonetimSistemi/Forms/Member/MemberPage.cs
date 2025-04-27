using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Forms.Trainers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation
{
    public partial class MemberPage : MaterialForm
    {
        public MemberPage()
        {
            InitializeComponent();
        }
        private async void MemberPage_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("members", dtMemberInfo);
        }
        void buttonControl()
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
        private void dtMemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberPayments paymentsForm = new MemberPayments(memberId);
            paymentsForm.ShowDialog();
            buttonControl();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberMemberships membershipsForm = new MemberMemberships(memberId);
            membershipsForm.ShowDialog();
            buttonControl();
        }

        private void btnMemberTrainers_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberTrainers membershipsForm = new MemberTrainers(memberId);
            membershipsForm.ShowDialog();
            buttonControl();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberParticipationHistory membershipsForm = new MemberParticipationHistory(memberId);
            membershipsForm.ShowDialog();
            buttonControl();
        }

        private void btnHealthInfo_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberHealthInformation membershipsForm = new MemberHealthInformation(memberId);
            membershipsForm.ShowDialog();
            buttonControl();
        }
        public static async Task UyeSilAsync(int memberId)
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

        private async void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dtMemberInfo.SelectedItems[0].SubItems[0].Text, out int memberId))
            {
                await UyeSilAsync(memberId);
            }
            else
            {
                MessageBox.Show("Geçerli bir MemberID girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            await Functions.VerileriGetirAsync("members", dtMemberInfo);
        }
    }
}
