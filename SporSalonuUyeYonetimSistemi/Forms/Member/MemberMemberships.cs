using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;
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
    public partial class MemberMemberships : MaterialForm
    {
        string memberId;
        public MemberMemberships(string memberId)
        {
            InitializeComponent();
            lblTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            pnlTitle.MouseDown += (sender, e) => CommonMethods.MoveForm(this.Handle, e);
            this.memberId = memberId;
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void MemberMemberships_Shown(object sender, EventArgs e)
        {
            string query = @"
SELECT 
    m.member_name, 
    m.member_surname, 
    mt.membership_type, 
    mt.membership_price, 
    ms.membership_start_date, 
    ms.membership_end_date
FROM memberships ms
INNER JOIN members m ON ms.member_id = m.member_id
INNER JOIN membership_types mt ON ms.membership_type_id = mt.membership_type_id
WHERE ms.member_id = '" + memberId + "'";

            await Functions.VerileriGetirManualAsync(query, dtMemberMemberships);
        }
    }
}
