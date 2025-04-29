using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    public partial class EditMembershipType : MaterialForm
    {
        string membershipTypeID;
        public EditMembershipType(string membershipTypeID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbPrice.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
            this.membershipTypeID = membershipTypeID;
        }
        private async Task UyelikTuruGetirAsync(string membershipTypeId)
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
        private async Task UyelikTuruGuncelleAsync(string membershipTypeId)
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
            await UyelikTuruGetirAsync(membershipTypeID);
        }

        private async void btnEditMembershipType_Click(object sender, EventArgs e)
        {
            await UyelikTuruGuncelleAsync(membershipTypeID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
