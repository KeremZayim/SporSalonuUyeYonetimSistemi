using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Classes;
using System.Data.SqlClient;

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
        private async void PayAsync(string memberId, MaterialCheckbox AraVerdiMi)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                SqlCommand cmd = new SqlCommand(@"
            SELECT mt.membership_price, m.membership_end_date, m.membership_type
            FROM memberships m
            JOIN membership_types mt ON m.membership_type_id = mt.membership_type_id
            WHERE m.member_id = @member_id", connection);

                cmd.Parameters.AddWithValue("@member_id", memberId);

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        decimal amount = reader.GetDecimal(0);
                        DateTime? endDate = null;
                        if (!reader.IsDBNull(1))
                        {
                            endDate = reader.GetDateTime(1);
                        }

                        string membershipType = reader.GetString(2); // Üyelik tipi (Aylık / Yıllık)

                        DateTime today = DateTime.Today;

                        if (endDate == null)
                        {
                            MessageBox.Show("Üyelik bitiş tarihi tanımlı değil. Ödeme yapılamaz.");
                            return;
                        }

                        TimeSpan kalanSure = endDate.Value - today;

                        if (kalanSure.TotalDays > 30)
                        {
                            MessageBox.Show("Üyelik bitmesine 1 aydan fazla kaldı. Şu an ödeme yapılamaz.");
                            return;
                        }

                        reader.Close();

                        SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO payments (member_id, payment_status, payment_date, amount)
                    VALUES (@member_id, @status, @date, @amount)", connection);

                        insertCmd.Parameters.AddWithValue("@member_id", memberId);
                        insertCmd.Parameters.AddWithValue("@status", "Ödendi");
                        insertCmd.Parameters.AddWithValue("@date", today);
                        insertCmd.Parameters.AddWithValue("@amount", amount);

                        await insertCmd.ExecuteNonQueryAsync();

                        DateTime yeniEndDate;

                        if (AraVerdiMi.Checked)
                        {
                            if (membershipType == "Aylık")
                            {
                                yeniEndDate = endDate.Value.AddMonths(1);
                            }
                            else if (membershipType == "Yıllık")
                            {
                                yeniEndDate = endDate.Value.AddYears(1);
                            }
                            else
                            {
                                yeniEndDate = endDate.Value;
                            }
                        }
                        else
                        {
                            yeniEndDate = endDate.Value;
                        }

                        SqlCommand updateCmd = new SqlCommand(@"
                    UPDATE memberships
                    SET membership_end_date = @new_end_date
                    WHERE member_id = @member_id", connection);

                        updateCmd.Parameters.AddWithValue("@new_end_date", yeniEndDate);
                        updateCmd.Parameters.AddWithValue("@member_id", memberId);

                        await updateCmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Ödeme başarılı! Yeni üyelik bitiş tarihi: " + yeniEndDate.ToString("dd.MM.yyyy"));
                    }
                    else
                    {
                        MessageBox.Show("Üyenin üyelik tipi bulunamadı!");
                    }
                    ButtonControl();
                }
            }
        }

        private async void MemberPayments_Shown(object sender, EventArgs e)
        {
            await Functions.GetDataByMemberIDAsync("payments", member_id, dtData);
        }

        private void dtData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnPay_Click(object sender, EventArgs e)
        {
            PayAsync(member_id, cbAraVerdiMi);
            await Functions.GetDataByMemberIDAsync("payments", member_id, dtData);
        }

        // 3.2-)
        private void btnFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
