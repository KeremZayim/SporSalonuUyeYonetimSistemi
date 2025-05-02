using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    public partial class AddMembershipType : MaterialForm
    {
        /*

            1-) Üyelik Türü Ekle (AddMembershipTypeAsync)
            2-) Butonlar
                2.1-) Üyelik Türü Ekle
                2.2-) Formu Kapat

         */

        public AddMembershipType()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbPrice.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        // 1-)
        private async Task AddMembershipTypeAsync()
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

        // 2-)
        // 2.1-)
        private async void btnAddMembershipType_Click(object sender, EventArgs e)
        {
            await AddMembershipTypeAsync();
        }

        // 2.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
