using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
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

namespace SporSalonuUyeYonetimSistemi.Forms.Membership_Types
{
    public partial class MembershipTypes : Form
    {
        public MembershipTypes()
        {
            InitializeComponent();
        }

        private async void membership_types_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("membership_types",dtMembershipTypes);
        }

        async Task DeleteMembershipTypes()
        {
            if (dtMembershipTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir üyelik türü seçin.");
                return;
            }

            int membershipTypeId = Convert.ToInt32(dtMembershipTypes.SelectedItems[0].SubItems[0].Text);

            var result = MessageBox.Show("Seçili üyelik türünü silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    string query = "DELETE FROM membership_types WHERE membership_type_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", membershipTypeId);
                        int affectedRows = await cmd.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Üyelik türü başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu. Üyelik türü bulunamadı.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        private async void btnDeleteMembershipType_Click(object sender, EventArgs e)
        {
            await DeleteMembershipTypes();
            await Functions.VerileriGetirAsync("membership_types", dtMembershipTypes);
        }
        void ButtonControl()
        {
            bool aktiflik;
            if (dtMembershipTypes.SelectedItems.Count > 0)
            {
                aktiflik = false;
            }
            else
            {
                aktiflik = true;
            }
            foreach (Control item in tabMembership_types.Controls)
            {
                if (item is MaterialButton materialButton)
                {
                    if (materialButton.Name != "btnAddMembershipType")
                    {
                        materialButton.Enabled = !aktiflik;
                    }
                }
            }
        }
        private void dtMembershipTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        private async void btnAddMembershipType_Click(object sender, EventArgs e)
        {
            AddMembershipType addMembershipType = new AddMembershipType();
            addMembershipType.ShowDialog();
            await Functions.VerileriGetirAsync("membership_types", dtMembershipTypes);
        }

        private async void btnEditMembershipType_Click(object sender, EventArgs e)
        {
            string membershipTypeID = dtMembershipTypes.SelectedItems[0].SubItems[0].Text;
            EditMembershipType editMembershipType = new EditMembershipType(membershipTypeID);
            editMembershipType.ShowDialog();
            await Functions.VerileriGetirAsync("membership_types", dtMembershipTypes);
        }
    }
}
