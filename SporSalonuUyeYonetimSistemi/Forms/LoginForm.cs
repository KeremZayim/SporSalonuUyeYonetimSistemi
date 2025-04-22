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
    public partial class LoginForm : Form
    {
        /*
         
         1-) Form Ayarları
            1.1-) Form Başlık Form Taşıma Eventi Ekleme
         
         
         
         
         */

        // 1-)
        public LoginForm()
        {
            InitializeComponent();

            // 1.1-)
            lblTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };
            pnlTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
