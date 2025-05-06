using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberMemberships : MaterialForm
    {

        /*

            1-) Üyelik Aktifliği Kontrolü ve Buton Aktifliği (ControlMembershipStatus)
            2-) Aktiflik Güncellemeleri
                2.1-) Başlat (StartMembershipAsync)
                2.2-) Bitir (EndMembershipAsync)
            3-) Listeleme (ListMemberMemberships)
            4-) Butonlar
                4.1-) Başlat
                4.2-) Bitir
                4.3-) Formu Kapat

         */

        readonly string memberID;
        public MemberMemberships(string memberID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }

        private async void MemberMemberships_Shown(object sender, EventArgs e)
        {
            await ListMemberMemberships();
            await ControlMembershipStatus(memberID);
        }

        // 1-)
        private async Task ControlMembershipStatus(string memberId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
                                SELECT COUNT(*) 
                                FROM memberships 
                                WHERE member_id = @memberId 
                                  AND (membership_end_date IS NULL OR membership_end_date > CAST(GETDATE() AS DATE))";

                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);

                        int activeMembershipCount = (int)await cmd.ExecuteScalarAsync();

                        if (activeMembershipCount > 0)
                        {
                            btnStartMembership.Enabled = false;
                            btnEndMembership.Enabled = true;
                        }
                        else
                        {
                            btnStartMembership.Enabled = true;
                            btnEndMembership.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Üyelik durumu kontrol edilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // 2-)
        // 2.1-)
        private async Task StartMembershipAsync(string memberId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
            UPDATE memberships
            SET 
                membership_start_date = CAST(GETDATE() AS DATE),
                membership_end_date = NULL
            WHERE member_id = @memberId";

                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                            MessageBox.Show("Üyelik başlatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Üyelik bilgisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Üyelik başlatılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2.2-)
        private async Task EndMembershipAsync(string memberId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                string query = @"
            UPDATE memberships
            SET 
                membership_end_date = CAST(GETDATE() AS DATE)
            WHERE member_id = @memberId";

                try
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                            MessageBox.Show("Üyelik sonlandırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Üyelik bilgisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Üyelik sonlandırılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3-)
        private async Task ListMemberMemberships()
        {
            string query = @"
                            SELECT 
                                m.member_name, 
                                m.member_surname, 
                                mt.membership_type, 
                                mt.membership_price, 
                                ms.membership_start_date, 
                                ms.membership_end_date
                            FROM memberships ms
                            INNER JOIN members m ON ms.member_id = m.member_id
                            INNER JOIN membership_types mt ON ms.membership_type_id = mt.membership_type_id
                            WHERE ms.member_id = '" + memberID + "'";

            await Functions.GetDatasManualAsync(query, dtMemberMemberships);
        }

        // 4-)
        // 4.1-)
        private async void btnStartMembership_Click(object sender, EventArgs e)
        {
            await StartMembershipAsync(memberID);
            await ListMemberMemberships();
        }

        // 4.2-)
        private async void btnEndMembership_Click(object sender, EventArgs e)
        {
            await EndMembershipAsync(memberID);
            await ListMemberMemberships();
        }

        // 4.3-)
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
