using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    public partial class EditMembershipType : MaterialForm
    {

        /*

            1-) Forma Üyelik Türünün Özelliklerini Doldurur (GetMembershipTypeAsync)
            2-) Üyelik Türünü Güncelle (UpdateMembershipTypeAsync)
            3-) Butonlar
                3.1-) Düzenle
                3.2-) Formu Kapat

         */

        string membershipTypeID;
        public EditMembershipType(string membershipTypeID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbPrice.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
            this.membershipTypeID = membershipTypeID;
        }

        // 1-)
        private async Task GetMembershipTypeAsync(string membershipTypeId)
        {
            string query = "SELECT membership_type, membership_price FROM membership_types WHERE membership_type_id = @id";

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", membershipTypeId);

                try
                {
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            tbMembershipType.Text = reader["membership_type"].ToString().Trim();
                            tbPrice.Text = reader["membership_price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen ID ile üyelik türü bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // 2-)
        private async Task UpdateMembershipTypeAsync(string membershipTypeId)
        {
            string yeniTur = tbMembershipType.Text.Trim();
            string yeniFiyatText = tbPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(yeniTur) || string.IsNullOrWhiteSpace(yeniFiyatText))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(yeniFiyatText, out decimal yeniFiyat))
            {
                MessageBox.Show("Fiyat geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"UPDATE membership_types 
                     SET membership_type = @type, membership_price = @price 
                     WHERE membership_type_id = @id";

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@type", yeniTur);
                cmd.Parameters.AddWithValue("@price", yeniFiyat);
                cmd.Parameters.AddWithValue("@id", membershipTypeId);

                try
                {
                    await conn.OpenAsync();
                    int affectedRows = await cmd.ExecuteNonQueryAsync();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Üyelik türü başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek bir üyelik türü bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void EditMembershipType_Shown(object sender, EventArgs e)
        {
            await GetMembershipTypeAsync(membershipTypeID);
        }
        
        // 3-)
        // 3.1-)
        private async void btnEditMembershipType_Click(object sender, EventArgs e)
        {
            await UpdateMembershipTypeAsync(membershipTypeID);
        }

        // 3.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
