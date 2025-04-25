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

namespace SporSalonuUyeYonetimSistemi.Forms
{
    public partial class Payments : MaterialForm
    {
        public Payments()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }
        private async void listele()
        {
            string query = "SELECT p.payment_id, m.member_id, m.member_name, m.member_surname, p.payment_status, p.payment_date, p.amount " +
               "FROM members AS m " +
               "JOIN payments AS p ON p.member_id = m.member_id " +
               "WHERE " +
                   "(CAST(m.member_id AS NVARCHAR) LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name + ' ' + m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%')";
            await Functions.VerileriGetirManualAsync(query,dtPayments);
        }
        private void Payments_Shown(object sender, EventArgs e)
        {
            listele();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
}
