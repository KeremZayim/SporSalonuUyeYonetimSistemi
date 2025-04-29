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
    public partial class AddMembershipType : MaterialForm
    {
        public AddMembershipType()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbPrice.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task UyelikTuruEkleAsync()
        {
            string membershipType = tbMembershipType.Text.Trim();
            string priceText = tbPrice.Text.Trim();

            if (string.IsNullOrWhiteSpace(membershipType) || !int.TryParse(priceText, out int price))
            {
                MessageBox.Show("Lütfen geçerli üyelik türü ve fiyat girin.");
                return;
            }

            string query = "INSERT INTO membership_types (membership_type, membership_price) VALUES (@type, @price)";

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@type", membershipType);
                cmd.Parameters.AddWithValue("@price", price);

                try
                {
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("Üyelik türü başarıyla eklendi.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private async void btnAddMembershipType_Click(object sender, EventArgs e)
        {
            await UyelikTuruEkleAsync();
        }
    }
}
