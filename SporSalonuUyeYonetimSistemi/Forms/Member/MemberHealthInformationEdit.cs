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

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberHealthInformationEdit : MaterialForm
    {
        string memberID;
        public MemberHealthInformationEdit(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbEmergencyContactPhone.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }
        private async Task LoadHealthInfoAsync(string memberId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = @"SELECT 
                                medical_conditions,
                                allergies,
                                emergency_contact_name,
                                emergency_contact_phone
                             FROM 
                                health_info
                             WHERE 
                                member_id = @memberId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberId", memberId);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tbMedicalConditions.Text = reader["medical_conditions"]?.ToString();
                                tbAllergies.Text = reader["allergies"]?.ToString();
                                tbEmergencyContactName.Text = reader["emergency_contact_name"]?.ToString();
                                tbEmergencyContactPhone.Text = reader["emergency_contact_phone"]?.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Bu üyeye ait sağlık bilgisi bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Textboxları temizle
                                tbMedicalConditions.Clear();
                                tbAllergies.Clear();
                                tbEmergencyContactName.Clear();
                                tbEmergencyContactPhone.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sağlık bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MemberHealthInformationEdit_Load(object sender, EventArgs e)
        {
            await LoadHealthInfoAsync(memberID);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMedicalConditions.Text) ||
                string.IsNullOrWhiteSpace(tbAllergies.Text) ||
                string.IsNullOrWhiteSpace(tbEmergencyContactName.Text) ||
                string.IsNullOrWhiteSpace(tbEmergencyContactPhone.Text))
            {
                MessageBox.Show("Lütfen tüm sağlık bilgilerini eksiksiz doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = @"UPDATE health_info
                             SET 
                                medical_conditions = @medical_conditions,
                                allergies = @allergies,
                                emergency_contact_name = @emergency_contact_name,
                                emergency_contact_phone = @emergency_contact_phone
                             WHERE 
                                member_id = @memberId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@medical_conditions", tbMedicalConditions.Text);
                        command.Parameters.AddWithValue("@allergies", tbAllergies.Text);
                        command.Parameters.AddWithValue("@emergency_contact_name", tbEmergencyContactName.Text);
                        command.Parameters.AddWithValue("@emergency_contact_phone", tbEmergencyContactPhone.Text);
                        command.Parameters.AddWithValue("@memberId", memberID);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sağlık bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek sağlık bilgisi bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sağlık bilgileri güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
