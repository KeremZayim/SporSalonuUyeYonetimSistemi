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
    public partial class ParticipationHistory : MaterialForm
    {
        public ParticipationHistory()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);

        }
        private async void listele()
        {
            string query = "SELECT m.member_id, m.member_name, m.member_surname, a.check_in_time, a.check_out_time " +
               "FROM members AS m " +
               "JOIN attendance AS a ON a.member_id = m.member_id " +
               "WHERE " +
                   "(CAST(m.member_id AS NVARCHAR) LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%') OR " +
                   "(m.member_name + ' ' + m.member_surname LIKE '%" + tbFilter.Text.Trim() + "%')";

            await Functions.VerileriGetirManualAsync(query, dtParticipationHistory);
        }

        private void ParticipationHistory_Shown(object sender, EventArgs e)
        {
            listele();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
}
