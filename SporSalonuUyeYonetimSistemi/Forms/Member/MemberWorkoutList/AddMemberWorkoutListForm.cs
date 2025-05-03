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

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutList
{
    public partial class AddMemberWorkoutListForm : MaterialForm
    {

        /*

            1-) Antrenman Listesi Ekleme (AddWorkoutListInfo)
            2-) Butonlar
                2.1-) Antrenman Listesi Ekle
                2.2-) Formu Kapat

         */

        readonly string memberID;
        public AddMemberWorkoutListForm(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }

        // 1-)
        private async Task AddWorkoutListInfo(string memberID)
        {
            if (string.IsNullOrWhiteSpace(tbWorkoutName.Text) || string.IsNullOrWhiteSpace(tbTargetArea.Text) || string.IsNullOrWhiteSpace(tbWorkoutDay.Text))
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

        // 2-)
        // 2.1-)

        // 2.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddWorkoutList_Click(object sender, EventArgs e)
        {
            await AddWorkoutListInfo(memberID);
        }
    }
}
