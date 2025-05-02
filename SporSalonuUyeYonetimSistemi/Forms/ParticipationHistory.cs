using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using System;

namespace SporSalonuUyeYonetimSistemi.Forms
{
    public partial class ParticipationHistory : MaterialForm
    {
        /*
         
            1-) Listeleme ve Filtreleme    

        */

        public ParticipationHistory()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        // 1-)
        private async void ListParticipationHistory()
        {
            string query = "SELECT m.member_id, m.member_name, m.member_surname, a.check_in_time, a.check_out_time " +
               "FROM members AS m " +
               "JOIN attendance AS a ON a.member_id = m.member_id " +
               "WHERE " +
                   "(CAST(m.member_id AS NVARCHAR) LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name + ' ' + m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%')";

            await Functions.GetDatasManualAsync(query, dtParticipationHistory);
        }

        private void ParticipationHistory_Shown(object sender, EventArgs e)
        {
            ListParticipationHistory();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            ListParticipationHistory();
        }
    }
}
