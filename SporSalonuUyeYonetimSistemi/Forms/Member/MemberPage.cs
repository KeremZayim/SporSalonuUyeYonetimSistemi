using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Forms.Trainers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SporSalonuUyeYonetimSistemi.Forms.Member.MemberInformation
{
    public partial class MemberPage : MaterialForm
    {
        public MemberPage()
        {
            InitializeComponent();
        }
        private async void MemberPage_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("members", dtMemberInfo);
        }
        void buttonControl()
        {
            bool aktiflik;
            if (dtMemberInfo.SelectedItems.Count > 0)
            {
                aktiflik = true;
            }
            else
            {
                aktiflik = false;
            }
            foreach (Control item in tabMemberInfo.Controls)
            {
                if (item is MaterialButton materialButton)
                {
                    materialButton.Enabled = aktiflik;
                }
            }
        }
        private void dtMemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonControl();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            string memberId = dtMemberInfo.SelectedItems[0].SubItems[0].Text;
            MemberPayments paymentsForm = new MemberPayments(memberId);
            paymentsForm.ShowDialog();
        }
    }
}
