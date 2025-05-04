using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms
{
    public partial class EditMember : MaterialForm
    {

        /*

            1-) Combobox Çift Veri Tutma (MembershipType)
            2-) Combobox'a Üyelik Türlerini Listeleme (LoadMembershipTypesAsync)
            3-) Üyenin Bilgilerini Doldurma (LoadMemberDataAsync)
            4-) Güncelleme (UpdateMemberAsync)
            5-) Butonlar
                5.1-) Üyeyi Düzenle
                5.2-) Formu Kapat

         */

        readonly string memberID;
        public EditMember(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbEmergencyContactPhone.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
            tbMemberPhoneNumber.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        private async void EditMember_Shown(object sender, EventArgs e)
        {
            await LoadMembershipTypesAsync();
            await LoadMemberDataAsync(memberID);
        }

        // 1-)
        private class MembershipType
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        // 2-)
        private async Task LoadMembershipTypesAsync()
        {
            cbMembershipType.Items.Clear();

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT membership_type_id, membership_type FROM membership_types";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        cbMembershipType.Items.Add(new MembershipType
                        {
                            Id = Convert.ToInt32(reader["membership_type_id"]),
                            Name = reader["membership_type"].ToString().Trim()
                        });
                    }
                }
            }
        }

        // 3-)
        private async Task LoadMemberDataAsync(string memberId)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                string query = @"
        SELECT 
            m.member_name,
            m.member_surname,
            m.member_birthday,
            m.phone_number,
            m.notes,
            mt.membership_type,  -- Burayı ekledik
            hi.medical_conditions,
            hi.allergies,
            hi.emergency_contact_name,
            hi.emergency_contact_phone
        FROM members m
        LEFT JOIN memberships ms ON m.member_id = ms.member_id
        LEFT JOIN membership_types mt ON ms.membership_type_id = mt.membership_type_id
        LEFT JOIN health_info hi ON m.member_id = hi.member_id
        WHERE m.member_id = @memberId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            tbMemberName.Text = reader["member_name"].ToString();
                            tbMemberSurname.Text = reader["member_surname"].ToString();
                            dtpBirthday.Value = Convert.ToDateTime(reader["member_birthday"]);
                            tbMemberPhoneNumber.Text = reader["phone_number"].ToString();
                            tbNotes.Text = reader["notes"]?.ToString();

                            tbMedicalConditions.Text = reader["medical_conditions"]?.ToString();
                            tbAllergies.Text = reader["allergies"]?.ToString();
                            tbEmergencyContactName.Text = reader["emergency_contact_name"]?.ToString();
                            tbEmergencyContactPhone.Text = reader["emergency_contact_phone"]?.ToString();

                            string membershipTypeName = reader["membership_type"]?.ToString().Trim();

                            foreach (var item in cbMembershipType.Items)
                            {
                                if (item is MembershipType mt && mt.Name.Equals(membershipTypeName, StringComparison.OrdinalIgnoreCase))
                                {
                                    cbMembershipType.SelectedItem = item;
                                    cbMembershipType.Refresh();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Üye bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        // 4-)
        private async Task UpdateMemberAsync(
                                            string memberId,
                                            string name,
                                            string surname,
                                            DateTime birthday,
                                            string phoneNumber,
                                            int membershipTypeId,
                                            string notes,
                                            string medicalConditions,
                                            string allergies,
                                            string emergencyContactName,
                                            string emergencyContactPhone)
        {
            // Gerekli alanlar kontrolü
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                birthday == default(DateTime) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                membershipTypeId <= 0 ||
                string.IsNullOrWhiteSpace(emergencyContactName) ||
                string.IsNullOrWhiteSpace(emergencyContactPhone))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun. (Not kısmı hariç)", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 1. Members tablosunu güncelle
                    string updateMemberQuery = @"
                UPDATE members
                SET member_name = @name,
                    member_surname = @surname,
                    member_birthday = @birthday,
                    phone_number = @phone,
                    notes = @notes
                WHERE member_id = @memberId";

                    using (SqlCommand cmd = new SqlCommand(updateMemberQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@notes", (object)notes ?? DBNull.Value);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    // 2. Memberships tablosunu güncelle
                    string updateMembershipQuery = @"
                UPDATE memberships
                SET membership_type_id = @typeId
                WHERE member_id = @memberId";

                    using (SqlCommand cmd = new SqlCommand(updateMembershipQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@typeId", membershipTypeId);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    // 3. Health_info tablosunu güncelle
                    string updateHealthQuery = @"
                UPDATE health_info
                SET medical_conditions = @conditions,
                    allergies = @allergies,
                    emergency_contact_name = @contactName,
                    emergency_contact_phone = @contactPhone
                WHERE member_id = @memberId";

                    using (SqlCommand cmd = new SqlCommand(updateHealthQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@conditions", medicalConditions);
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@contactName", emergencyContactName);
                        cmd.Parameters.AddWithValue("@contactPhone", emergencyContactPhone);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    transaction.Commit();
                    MessageBox.Show("Üye bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();  // Rollback işlemi burada senkron yapılır
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // 5-)
        // 5.1-)
        private async void btnEditMember_Click(object sender, EventArgs e)
        {
            await UpdateMemberAsync(
                                    memberID,
                                    tbMemberName.Text,
                                    tbMemberSurname.Text,
                                    dtpBirthday.Value,
                                    tbMemberPhoneNumber.Text,
                                    ((MembershipType)cbMembershipType.SelectedItem).Id,
                                    tbNotes.Text,
                                    tbMedicalConditions.Text,
                                    tbAllergies.Text,
                                    tbEmergencyContactName.Text,
                                    tbEmergencyContactPhone.Text
            );
        }

        // 5.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
