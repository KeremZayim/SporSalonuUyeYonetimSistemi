using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class AddMember : MaterialForm
    {

        /*

            1-) Combobox Çift Veri Tutma (MembershipType)
            2-) Combobox'a Üyelik Türlerini Listeleme (LoadMembershipTypesAsync)
            3-) Üye Ekle (AddNewMemberAsync)
            4-) Butonlar
                4.1-) Üye Ekle
                4.2-) Formu Kapat

         */

        public AddMember()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            tbEmergencyContactPhone.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
            tbMemberPhoneNumber.KeyPress += (sender, e) => CommonMethods.JustNumberEntering(this.Handle, e);
        }

        // 1-)
        public class MembershipType
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private async void AddMember_Shown(object sender, EventArgs e)
        {
            await LoadMembershipTypesAsync();
        }

        // 2-)
        private async Task LoadMembershipTypesAsync()
        {
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
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        // 3-)
        private async Task AddNewMemberAsync(
        string name, string surname, DateTime birthday, string phoneNumber,
        int membershipTypeId, string notes,
        string medicalConditions, string allergies,
        string emergencyContactName, string emergencyContactPhone
        )
        {
            // Gerekli alanlar boş mu kontrol et
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                birthday == default(DateTime) ||
                string.IsNullOrWhiteSpace(phoneNumber) ||
                membershipTypeId <= 0 ||
                string.IsNullOrWhiteSpace(medicalConditions) ||
                string.IsNullOrWhiteSpace(allergies) ||
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
                    // 1. Members tablosuna ekle
                    string insertMemberQuery = @"INSERT INTO members 
                    (member_name, member_surname, member_birthday, phone_number, notes) 
                    VALUES (@name, @surname, @birthday, @phone, @notes);
                    SELECT SCOPE_IDENTITY();";

                    int memberId;
                    using (SqlCommand cmd = new SqlCommand(insertMemberQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@notes", (object)notes ?? DBNull.Value);

                        memberId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }

                    // 2. Memberships tablosuna ekle
                    string insertMembershipQuery = @"INSERT INTO memberships 
                    (member_id, membership_type_id, membership_start_date)
                    VALUES (@memberId, @typeId, @startDate)";

                    using (SqlCommand cmd = new SqlCommand(insertMembershipQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@typeId", membershipTypeId);
                        cmd.Parameters.AddWithValue("@startDate", DateTime.Today);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    // 3. Health_info tablosuna ekle
                    string insertHealthQuery = @"INSERT INTO health_info 
                    (member_id, medical_conditions, allergies, emergency_contact_name, emergency_contact_phone)
                    VALUES (@memberId, @conditions, @allergies, @contactName, @contactPhone)";

                    using (SqlCommand cmd = new SqlCommand(insertHealthQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@conditions", medicalConditions);
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@contactName", emergencyContactName);
                        cmd.Parameters.AddWithValue("@contactPhone", emergencyContactPhone);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    transaction.Commit();
                    MessageBox.Show("Üye başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4-)
        // 4.1-)
        private async void btnAddMember_Click(object sender, EventArgs e)
        {
            var selectedType = cbMembershipType.SelectedItem as MembershipType;
            if (selectedType == null)
            {
                MessageBox.Show("Lütfen bir üyelik tipi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await AddNewMemberAsync(
                                    tbMemberName.Text,
                                    tbMemberSurname.Text,
                                    dtpBirthday.Value,
                                    tbMemberPhoneNumber.Text,
                                    ((dynamic)cbMembershipType.SelectedItem).Id,
                                    tbNotes.Text,
                                    tbMedicalConditions.Text,
                                    tbAllergies.Text,
                                    tbEmergencyContactName.Text,
                                    tbEmergencyContactPhone.Text
                                    );
        }

        // 4.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
