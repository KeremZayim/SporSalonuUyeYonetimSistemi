using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberParticipationHistory : MaterialForm
    {
        string memberID;
        public MemberParticipationHistory(string memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
        }

        private async void MemberParticipationHistory_Load(object sender, EventArgs e)
        {
            string query = @"SELECT 
                    attendance_id,
                    check_in_time,
                    check_out_time
                 FROM 
                    attendance
                 WHERE 
                    member_id = '" + memberID + @"'
                 ORDER BY 
                    check_in_time DESC";

            await Functions.GetDatasManualAsync(query,dtMemberParticipationHistory);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
