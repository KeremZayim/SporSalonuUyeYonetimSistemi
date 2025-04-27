using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberHealthInformation : MaterialForm
    {
        string memberID;
        public MemberHealthInformation(string memberID)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberID = memberID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void buttonControl()
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
        private void dtMemberHealthInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl();
        }

        private async void MemberHealthInfo_Load(object sender, EventArgs e)
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

            await Functions.VerileriGetirManualAsync(query,dtMemberHealthInfo);
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            MemberHealthInformationEdit membershipsForm = new MemberHealthInformationEdit(memberID);
            membershipsForm.ShowDialog();
            buttonControl();

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

            await Functions.VerileriGetirManualAsync(query, dtMemberHealthInfo);
        }
    }
}
