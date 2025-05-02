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

namespace SporSalonuUyeYonetimSistemi.Forms.Workout
{
    public partial class AddWorkoutList : MaterialForm
    {
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public AddWorkoutList()
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task LoadMembersAsync()
        {
            cbMember.Items.Clear();

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT member_id, member_name, member_surname FROM members";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int memberId = reader.GetInt32(0);
                            string fullName = $"{reader.GetString(1).Trim()} {reader.GetString(2).Trim()}";

                            cbMember.Items.Add(new ComboBoxItem(fullName, memberId));
                        }
                    }
                }
            }
        }

        private async void AddWorkout_Shown(object sender, EventArgs e)
        {
            await LoadMembersAsync();
        }
        void selectionControl()
        {
            if (cbMember.SelectedIndex != -1)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is MaterialTextBox mtb)
                    {
                        mtb.Enabled = true;
                    }
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is MaterialTextBox mtb)
                    {
                        mtb.Enabled = false;
                    }
                }
            }
        }
        public async Task AddWorkoutListInfo(string memberID)
        {
            if (cbMember.SelectedItem == null || string.IsNullOrWhiteSpace(tbWorkoutName.Text) || string.IsNullOrWhiteSpace(tbTargetArea.Text) || string.IsNullOrWhiteSpace(tbWorkoutDay.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = "INSERT INTO workout_list (workout_name, target_area, workout_day, member_id) VALUES (@name, @area, @day, @member_id)";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@name", tbWorkoutName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@area", tbTargetArea.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@day", tbWorkoutDay.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@member_id", memberID);

                        int affectedRows = await insertCmd.ExecuteNonQueryAsync();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Antrenman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Antrenman eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionControl();
        }

        private async void btnAddWorkoutList_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedItem is ComboBoxItem selectedMember)
            {
                string memberID = selectedMember.Value.ToString();
                await AddWorkoutListInfo(memberID);
            }
        }
    }
}
