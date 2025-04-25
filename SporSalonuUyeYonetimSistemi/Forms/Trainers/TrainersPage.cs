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

namespace SporSalonuUyeYonetimSistemi.Forms.Trainers
{
    public partial class TrainersPage : MaterialForm
    {
        public TrainersPage()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
        }

        private async void TrainersPage_Shown(object sender, EventArgs e)
        {
            await Functions.VerileriGetirAsync("trainers",dtTrainerInfo);
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            AddTrainer addTrainer = new AddTrainer();
            addTrainer.ShowDialog();
        }
    }
}
