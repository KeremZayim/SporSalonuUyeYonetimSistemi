using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SporSalonuUyeYonetimSistemi.Classes;

namespace SporSalonuUyeYonetimSistemi.Forms.Member
{
    public partial class MemberPayments : MaterialForm
    {
        private string member_id;
        public MemberPayments(string member_id)
        {
            InitializeComponent();
            this.member_id = member_id;
        }

        private async void MemberPayments_Load(object sender, EventArgs e)
        {
            await Functions.detayGetir("payments", member_id, dtData);
        }
    }
}
