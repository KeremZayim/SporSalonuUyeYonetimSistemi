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

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class TrainerStudentAdd : MaterialForm
    {

        /*

            1-) Öğrenci Bilgileri (Stuednts)
            2-) Üyeleri Combobox'a Listeler (ListMembersAsync)
            3-) Öğrenci Ekle (AddStudentAsync)
            4-) Butonlar
                4.1-) Öğrenci Ekle
                4.2-) Formu Kapat

         */

        string trainerID;
        public TrainerStudentAdd(string trainerID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.trainerID = trainerID;
        }

        // 1-)
        private class Student
        {
            public int Id { get; set; }
            public string FullName { get; set; }
        }

        // 2-)
        private static async Task ListMembersAsync(ComboBox cbStudents)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT member_id, member_name, member_surname FROM members";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        List<Student> students = new List<Student>();

                        while (await reader.ReadAsync())
                        {
                            students.Add(new Student
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("member_id")),
                                FullName = $"{reader["member_name"].ToString().Trim()} {reader["member_surname"].ToString().Trim()}"
                            });
                        }

                        cbStudents.DataSource = null;
                        cbStudents.Items.Clear();

                        cbStudents.DataSource = students;
                        cbStudents.DisplayMember = "FullName";
                        cbStudents.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenciler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3-)
        private static async Task AddStudentAsync(string trainerId, ComboBox cbStudents)
        {
            if (cbStudents.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student selectedStudent = cbStudents.SelectedItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Geçersiz öğrenci verisi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberId = selectedStudent.Id;

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = "INSERT INTO member_trainers (member_id, trainer_id) VALUES (@memberId, @trainerId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberId", memberId);
                        command.Parameters.AddWithValue("@trainerId", trainerId);

                        await command.ExecuteNonQueryAsync();

                        MessageBox.Show("Öğrenci başarılı bir şekilde eğitmene atandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation (aynı öğrenci-trainer daha önce eklenmişse)
                {
                    MessageBox.Show("Bu öğrenci zaten bu eğitmene atanmış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Öğrenci atanırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void TrainerStudentAdd_Shown(object sender, EventArgs e)
        {
            await ListMembersAsync(cbStudents);
        }

        // 4-)
        // 4.1-)
        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            await AddStudentAsync(trainerID,cbStudents);
            this.Close();
        }

        // 4.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
