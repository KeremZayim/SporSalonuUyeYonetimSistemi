using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Classes;
using System.Data.SqlClient;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberPayments : MaterialForm
    {
        private string member_id;
        public MemberPayments(string member_id)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.member_id = member_id;
        }

        private async void MemberPayments_Load(object sender, EventArgs e)
        {
            await Functions.DetayGetirAsync("payments", member_id, dtData);
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            odemeYap(member_id,cbAraVerdiMi);
            await Functions.DetayGetirAsync("payments", member_id, dtData);
        }
        async void odemeYap(string memberId,MaterialCheckbox AraVerdiMi)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                // 1. Membership price ve end_date çekiliyor
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

                        // Eğer üyeliğin bitiş tarihi yoksa (sınırsızsa) veya bitmesine 1 aydan fazla varsa → Ödeme reddedilir
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

                        // 2. Ödeme kaydı ekleniyor
                        reader.Close();

                        SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO payments (member_id, payment_status, payment_date, amount)
                    VALUES (@member_id, @status, @date, @amount)", connection);

                        insertCmd.Parameters.AddWithValue("@member_id", memberId);
                        insertCmd.Parameters.AddWithValue("@status", "Ödendi");
                        insertCmd.Parameters.AddWithValue("@date", today);
                        insertCmd.Parameters.AddWithValue("@amount", amount);

                        await insertCmd.ExecuteNonQueryAsync();

                        // 3. Yeni end date hesaplanıyor (AraVerdiMi'ye göre 1 ay veya 1 yıl ekleniyor)
                        DateTime yeniEndDate;

                        if (AraVerdiMi.Checked)
                        {
                            // Üyelik türüne göre süre ekle
                            if (membershipType == "Aylık")
                            {
                                yeniEndDate = endDate.Value.AddMonths(1); // 1 ay ekle
                            }
                            else if (membershipType == "Yıllık")
                            {
                                yeniEndDate = endDate.Value.AddYears(1); // 1 yıl ekle
                            }
                            else
                            {
                                // Diğer üyelik tipleri için end date değişmiyor
                                yeniEndDate = endDate.Value;
                            }
                        }
                        else
                        {
                            // AraVerdiMi işaretli değilse end date değişmez
                            yeniEndDate = endDate.Value;
                        }

                        // 4. Yeni end date'i güncelle
                        SqlCommand updateCmd = new SqlCommand(@"
                    UPDATE memberships
                    SET membership_end_date = @new_end_date
                    WHERE member_id = @member_id", connection);

                        updateCmd.Parameters.AddWithValue("@new_end_date", yeniEndDate);
                        updateCmd.Parameters.AddWithValue("@member_id", memberId);

                        await updateCmd.ExecuteNonQueryAsync();

                        // 5. Kullanıcıya mesaj ver
                        MessageBox.Show("Ödeme başarılı! Yeni üyelik bitiş tarihi: " + yeniEndDate.ToString("dd.MM.yyyy"));
                    }
                    else
                    {
                        MessageBox.Show("Üyenin üyelik tipi bulunamadı!");
                    }
                }
            }
        }

        private void btnFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
