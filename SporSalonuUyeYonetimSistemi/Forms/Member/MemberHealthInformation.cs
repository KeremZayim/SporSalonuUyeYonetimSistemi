using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberHealthInformation : MaterialForm
    {

        /*

            1-)
            2-)
                2.1-) üzenle
                2.2-) Formu Kapat

         */

        string memberID;
        public MemberHealthInformation(string memberID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }

        // 1-)
        void ButtonControl()
        {
            if (dtMemberHealthInfo.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private async void MemberHealthInformation_Shown(object sender, EventArgs e)
        {
            string query = @"SELECT 
                    health_id,
                    medical_conditions,
                    allergies,
                    emergency_contact_name,
                    emergency_contact_phone
                 FROM 
                    health_info
                 WHERE 
                    member_id = '" + memberID + "'";

            await Functions.GetDatasManualAsync(query, dtMemberHealthInfo);
        }

        private void dtMemberHealthInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonControl();
        }

        // 2-)
        // 2.1-)

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            MemberHealthInformationEdit membershipsForm = new MemberHealthInformationEdit(memberID);
            membershipsForm.ShowDialog();
            ButtonControl();

            string query = @"SELECT 
                    health_id,
                    medical_conditions,
                    allergies,
                    emergency_contact_name,
                    emergency_contact_phone
                 FROM 
                    health_info
                 WHERE 
                    member_id = '" + memberID + "'";

            await Functions.GetDatasManualAsync(query, dtMemberHealthInfo);
        }

        // 2.2-)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
