using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Classes;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberPayments : MaterialForm
    {

        /*

            1-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            2-) Ödeme Yap (PayAsync)
            3-) Butonlar
                3.1-) Öde
                3.2-) Formu Kapat
            4-) Üyelik Kontrolü(CheckAndUpdatePaymentStatusesAsync)
         */

        private string member_id;
        public MemberPayments(string member_id)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.member_id = member_id;
        }

        // 1-)
        private void ButtonControl()
        {
            if (dtData.SelectedItems.Count > 0)
            {
                btnPay.Enabled = true;
            }
            else
            {
                btnPay.Enabled = false;
            }
        }

        // 2-)
        private async void PayAsync(string memberId)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                // 1. Üyelik bilgilerini çek
                SqlCommand cmd = new SqlCommand(@"
            SELECT mt.membership_price, m.membership_end_date, m.membership_type
            FROM memberships m
            JOIN membership_types mt ON m.membership_type_id = mt.membership_type_id
            WHERE m.member_id = @member_id", connection);

                cmd.Parameters.AddWithValue("@member_id", memberId);

                decimal amount = 0;
                DateTime? endDate = null;
                string membershipType = "";

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        amount = reader.GetDecimal(0);
                        if (!reader.IsDBNull(1))
                            endDate = reader.GetDateTime(1);
                        membershipType = reader.GetString(2);
                    }
                    else
                    {
                        MessageBox.Show("Üye bilgisi bulunamadı.");
                        return;
                    }
                }

                if (endDate == null)
                {
                    MessageBox.Show("Üyelik bitiş tarihi tanımlı değil. Ödeme yapılamaz.");
                    return;
                }

                // 2. Son ödeme durumu kontrolü
                SqlCommand lastPaymentCmd = new SqlCommand(@"
            SELECT TOP 1 payment_status
            FROM payments
            WHERE member_id = @member_id
            ORDER BY payment_date DESC", connection);

                lastPaymentCmd.Parameters.AddWithValue("@member_id", memberId);

                string lastStatus = "";
                object result = await lastPaymentCmd.ExecuteScalarAsync();
                if (result != null)
                    lastStatus = result.ToString();

                // 3. Yeni bitiş tarihini belirle
                DateTime newEndDate;
                DateTime today = DateTime.Today;

                if (lastStatus == "Üyelik Sonlandırılmış")
                {
                    newEndDate = membershipType.Contains("Yıllık")
                        ? today.AddYears(1)
                        : today.AddMonths(1);
                }
                else
                {
                    newEndDate = membershipType.Contains("Yıllık")
                        ? endDate.Value.AddYears(1)
                        : endDate.Value.AddMonths(1);
                }

                // 4. Ödeme kaydını ekle
                SqlCommand insertCmd = new SqlCommand(@"
            INSERT INTO payments (member_id, payment_status, payment_date, amount)
            VALUES (@member_id, @status, @date, @amount)", connection);

                insertCmd.Parameters.AddWithValue("@member_id", memberId);
                insertCmd.Parameters.AddWithValue("@status", "Ödendi");
                insertCmd.Parameters.AddWithValue("@date", today);
                insertCmd.Parameters.AddWithValue("@amount", amount);

                await insertCmd.ExecuteNonQueryAsync();

                // 5. Üyelik bitiş tarihini güncelle
                SqlCommand updateCmd = new SqlCommand(@"
            UPDATE memberships
            SET membership_end_date = @new_end_date
            WHERE member_id = @member_id", connection);

                updateCmd.Parameters.AddWithValue("@new_end_date", newEndDate);
                updateCmd.Parameters.AddWithValue("@member_id", memberId);

                await updateCmd.ExecuteNonQueryAsync();

                MessageBox.Show("Ödeme başarılı! Yeni üyelik bitiş tarihi: " + newEndDate.ToString("dd.MM.yyyy"));

                ButtonControl();
            }
        }


        private async void MemberPayments_Shown(object sender, EventArgs e)
        {
            await Functions.GetDataByMemberIDAsync("payments", member_id, dtData);
            await CheckAndUpdatePaymentStatusesAsync();
        }

        private void dtData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnPay_Click(object sender, EventArgs e)
        {
            PayAsync(member_id);
            await Functions.GetDataByMemberIDAsync("payments", member_id, dtData);
        }

        // 3.2-)
        private void btnFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 4-)
        public async Task CheckAndUpdatePaymentStatusesAsync()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await conn.OpenAsync();

                string query = @"
            -- 40 günü geçenler: Gecikmiş + üyeliği sonlandır
            UPDATE payments
            SET payment_status = 'Üyelik Sonlandırılmış'
            WHERE DATEDIFF(DAY, payment_date, GETDATE()) > 40;

            UPDATE memberships
            SET membership_end_date = CAST(GETDATE() AS DATE)
            WHERE member_id IN (
                SELECT member_id FROM payments
                WHERE DATEDIFF(DAY, payment_date, GETDATE()) > 40
            );

            -- 30-40 gün arası: Gecikmiş
            UPDATE payments
            SET payment_status = 'Gecikmiş'
            WHERE DATEDIFF(DAY, payment_date, GETDATE()) > 30
              AND DATEDIFF(DAY, payment_date, GETDATE()) <= 40;

            -- 20-30 gün arası: Beklemede
            UPDATE payments
            SET payment_status = 'Beklemede'
            WHERE DATEDIFF(DAY, payment_date, GETDATE()) > 20
              AND DATEDIFF(DAY, payment_date, GETDATE()) <= 30;
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
