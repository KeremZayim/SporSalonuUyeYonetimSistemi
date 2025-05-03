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
    public partial class EditMemberWorkoutListForm : MaterialForm
    {

        /*

            1-) Bilgileri Forma Doldurma (LoadWorkoutByMemberIdAsync)
            2-) Antrenman Listesini Güncelle (UpdateWorkoutByMemberIdAsync)
            3-) Butonlar
                3.1-) Antrenman Listesini Düzenle
                3.2-) Formu Kapat

         */

        readonly string memberID;
        public EditMemberWorkoutListForm(string memberID)
        {
            InitializeComponent();
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }

        // 1-)
        private async Task LoadWorkoutByMemberIdAsync(string memberId)
        {
            string query = "SELECT workout_name, target_area, workout_day FROM workout_list WHERE member_id = @memberId";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@memberId", memberId);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                tbWorkoutName.Text = reader["workout_name"].ToString();
                                tbTargetArea.Text = reader["target_area"].ToString();
                                tbWorkoutDay.Text = reader["workout_day"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Bu üyeye ait antrenman bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbWorkoutName.Clear();
                                tbTargetArea.Clear();
                                tbWorkoutDay.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Antrenman verileri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2-)
        private async Task UpdateWorkoutByMemberIdAsync(string memberId)
        {
            string query = "UPDATE workout_list SET workout_name = @workout_name, target_area = @target_area, workout_day = @workout_day WHERE member_id = @memberId";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@workout_name", tbWorkoutName.Text.Trim());
                        command.Parameters.AddWithValue("@target_area", tbTargetArea.Text.Trim());
                        command.Parameters.AddWithValue("@workout_day", tbWorkoutDay.Text.Trim());
                        command.Parameters.AddWithValue("@memberId", memberId);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Antrenman başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek antrenman bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Antrenman güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private async void EditMemberWorkoutListForm_Shown(object sender, EventArgs e)
        {
            await LoadWorkoutByMemberIdAsync(memberID);
        }

        // 3-)
        // 3.1-)
        private async void btnEdditWorkoutList_Click(object sender, EventArgs e)
        {
            await UpdateWorkoutByMemberIdAsync(memberID);
        }

        // 3.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
