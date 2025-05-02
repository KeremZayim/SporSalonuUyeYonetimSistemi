using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;

namespace SporSalonuUyeYonetimSistemi.Forms
{
    public partial class Payments : MaterialForm
    {
        /*
         
            1-) Filtreleme ve Listeleme

        */

        public Payments()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        // 1-)
        private async void ListPayments()
        {
            string query = "SELECT p.payment_id, m.member_id, m.member_name, m.member_surname, p.payment_status, p.payment_date, p.amount " +
               "FROM members AS m " +
               "JOIN payments AS p ON p.member_id = m.member_id " +
               "WHERE " +
                   "(CAST(m.member_id AS NVARCHAR) LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name + ' ' + m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%')";
            await Functions.GetDatasManualAsync(query,dtPayments);
        }

        private void Payments_Shown(object sender, EventArgs e)
        {
            ListPayments();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ListPayments();
        }
    }
}
