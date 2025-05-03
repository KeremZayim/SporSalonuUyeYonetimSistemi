using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberWorkoutList
{
    public partial class MemberWorkoutListForm : MaterialForm
    {

        /*

            1-) Üye Antrenman Listesini Sil (DeleteWorkoutByIDAsync)
            2-) Buton Aktifliği - Tablodan Seçilen Öğe Kontrolü (ButtonControl)
            3-) Butonlar
                3.1-) Ekle
                3.2-) Düzenle
                3.3-) Sil
                3.4-) Formu Kapat
                 
         */

        readonly string memberID;
        public MemberWorkoutListForm(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }

        private async void MemberWorkoutList_Shown(object sender, EventArgs e)
        {
            await Functions.GetDataByMemberIDAsync("workout_list", memberID, dtWorkoutList);
        }

        // 1-)
        private async Task DeleteWorkoutByIdAsync(string workoutId)
        {
            var onay = MessageBox.Show("Bu antrenmanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            string query = "DELETE FROM workout_list WHERE workout_id = @workoutId";

            using (SqlConnection connection = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@workoutId", workoutId);
                        int result = await command.ExecuteNonQueryAsync();

                        if (result > 0)
                        {
                            MessageBox.Show("Antrenman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Antrenman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void ButtonControl()
        {
            if (dtWorkoutList.SelectedItems.Count > 0)
            {
                btnEditWorkoutList.Enabled = true;
                btnDeleteWorkoutList.Enabled = true;
            }
            else
            {
                btnEditWorkoutList.Enabled = false;
                btnDeleteWorkoutList.Enabled = false;
            }
        }

        private void dtWorkoutList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 3-)
        // 3.1-)
        private async void btnAddWorkoutList_Click(object sender, EventArgs e)
        {
            AddMemberWorkoutListForm addMemberWorkoutListForm = new AddMemberWorkoutListForm(memberID);
            addMemberWorkoutListForm.ShowDialog();
            await Functions.GetDataByMemberIDAsync("workout_list", memberID, dtWorkoutList);
            dtWorkoutList.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.2-)
        private async void btnEditWorkoutList_Click(object sender, EventArgs e)
        {
            EditMemberWorkoutListForm editMemberWorkoutListForm = new EditMemberWorkoutListForm(memberID);
            editMemberWorkoutListForm.ShowDialog();
            await Functions.GetDataByMemberIDAsync("workout_list", memberID, dtWorkoutList);
            dtWorkoutList.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.3-)
        private async void btnDeleteWorkoutList_Click(object sender, EventArgs e)
        {
            if (dtWorkoutList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir antrenman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string workoutId = dtWorkoutList.SelectedItems[0].SubItems[0].Text;
            await DeleteWorkoutByIdAsync(workoutId);
            await Functions.GetDataByMemberIDAsync("workout_list", memberID, dtWorkoutList);
            dtWorkoutList.SelectedItems.Clear();
            ButtonControl();
        }

        // 3.4-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
