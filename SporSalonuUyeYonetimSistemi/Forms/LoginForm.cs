using MaterialSkin;
using MaterialSkin.Controls;
using SporSalonuUyeYonetimSistemi.Classes;
using SporSalonuUyeYonetimSistemi.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Forms
{
    public partial class LoginForm : MaterialForm
    {
        /*
         
         1-) Form Ayarları
            1.1-) Form Başlık Form Taşıma Eventi Ekleme
            1.2-) Beni Hatırla Kontrolü

         2-) Giriş Yap Butonu
            2.1-) Giriş Yapma
            2.2-) Beni Hatırla Butonu Kaydı

         3-) Şifre Göster/Gizle

         4-) Beni Hatırla
            4.1-) Kullanıcı Adı Doldurma
            4.2-) Kullanıcı Adı Kaydetme

         5-) Enter Tuşu İle Giriş

         */

        SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString);

        // 1-)
        public LoginForm()
        {
            InitializeComponent();
            ThemeProperties.ApplyLightTheme(this);
            // 1.1-)
            lblTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };
            pnlTitle.MouseDown += (sender, e) =>
            {
                CommonMethods.MoveForm(this.Handle, e);
            };

            // 1.2-)
            LoadRememberMe();
        }


        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 2-)
        private void btnLogin_Click(object sender, EventArgs e)
        {

            // 2.1-)
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT username,password FROM admins WHERE username = @username AND password = @password";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@username", tbUsername.Text);
                    command.Parameters.AddWithValue("@password", tbPassword.Text);

                    SqlDataReader dataReader = command.ExecuteReader();
                    bool foundUser = false;

                    while (dataReader.Read())
                    {
                        foundUser = true;
                        MainForm anasayfa = new MainForm();
                        this.Hide();
                        anasayfa.Show();
                        // 2.2-)
                        CheckRememberMe();
                    }

                    dataReader.Close();
                    command.Dispose();

                    if (!foundUser)
                    {
                        MessageBox.Show("Kullanıcı adın veya şifren yanlış!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sunucu Bağlantı Hatası!\n{ex}", "Hata!");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        // 3-)
        private void tbPassword_TrailingIconClick(object sender, EventArgs e)
        {
            if ((string)tbPassword.Tag == "visible")
            {
                tbPassword.TrailingIcon = Properties.Resources.Closed_Eye_1;
                tbPassword.Tag = "hidden";
                tbPassword.UseSystemPasswordChar = true; // Gizle
            }
            else
            {
                tbPassword.TrailingIcon = Properties.Resources.Eye;
                tbPassword.Tag = "visible";
                tbPassword.UseSystemPasswordChar = false; // Göster
            }
        }

        // 4-) Beni Hatırla
        // 4.1-)
        void LoadRememberMe()
        {
            if (Settings.Default.username != "")
            {
                tbUsername.Text = Settings.Default.username;
                switchRememberMe.Checked = true;
                tbPassword.SelectAll();
            }
            else
            {
                tbUsername.SelectAll();
            }
        }

        // 4.2-)
        void CheckRememberMe()
        {
            if (switchRememberMe.Checked)
            {
                Settings.Default.username = tbUsername.Text;
            }
            else if (!switchRememberMe.Checked)
            {
                Settings.Default.username = "";
            }
            Settings.Default.Save();
        }

        // 5-)
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); // Burada tıklanmasını istediğin butonu çağır
                e.SuppressKeyPress = true; // Enter tuşunun normal çalışmasını engelle
            }
        }
    }
}