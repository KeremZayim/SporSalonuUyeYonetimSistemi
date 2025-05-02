using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

    1-) Girilen Tablo Adındaki Bütün Verileri Bir ListView'e Listeleme Fonksiyonu (GetDataAsync)
    2-) Girilen Sorguya Özel Verileri Bir ListView'e Listeleme Fonksiyonu (GetDatasManualAsync)
    3-) Belirli Kullanıcının Girilen Tabloda Adındaki Bütün Verilerini Listeleyen Fonksiyon (GetDataByMemberIDAsync)
    4-) Belirtilen MaterialCombobox'a Bütün Üyelerin Ad Soyadlarını "{Ad} {Soyad}" Şeklinde Listeler ve En Üste "Herkes" Seçeneği Koyar. (FillMemberList)

*/


namespace SporSalonuUyeYonetimSistemi.Classes
{
    internal class Functions
    {
        // 1-)
        public static async Task GetDatasAsync(string Tablo, MaterialListView materialListView)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    string query = $"SELECT * FROM {Tablo}";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        materialListView.Columns.Clear();
                        materialListView.Items.Clear();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string originalColumnName = reader.GetName(i);
                            string translatedColumnName = Translate.TranslateColumn(originalColumnName);
                            materialListView.Columns.Add(translatedColumnName);
                        }

                        while (await reader.ReadAsync())
                        {
                            var item = new ListViewItem(reader[0].ToString().Trim());

                            for (int i = 1; i < reader.FieldCount; i++)
                            {
                                item.SubItems.Add(reader[i].ToString().Trim());
                            }

                            materialListView.Items.Add(item);
                        }
                    }
                    reader.Close();

                    foreach (ColumnHeader column in materialListView.Columns)
                    {
                        column.Width = materialListView.Width / materialListView.Columns.Count;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler getirilemedi: " + ex.Message);
                }
            }
        }

        // 2-)
        public static async Task GetDatasManualAsync(string query, MaterialListView materialListView)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            materialListView.Columns.Clear();
                            materialListView.Items.Clear();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string originalColumnName = reader.GetName(i);
                                string translatedColumnName = Translate.TranslateColumn(originalColumnName);
                                materialListView.Columns.Add(translatedColumnName);
                            }

                            while (await reader.ReadAsync())
                            {
                                var item = new ListViewItem(reader[0]?.ToString().Trim() ?? string.Empty);

                                for (int i = 1; i < reader.FieldCount; i++)
                                {
                                    // Özel kontrol: Eğer bu bir birleştirilmiş "{ad} {soyad}" sütunuysa
                                    if (reader.GetName(i).Equals("Üye", StringComparison.OrdinalIgnoreCase))
                                    {
                                        string fullName = reader[i]?.ToString().Trim() ?? string.Empty;
                                        // Fazla boşlukları temizle
                                        fullName = string.Join(" ", fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                                        item.SubItems.Add(fullName);
                                    }
                                    else
                                    {
                                        item.SubItems.Add(reader[i]?.ToString().Trim() ?? string.Empty);
                                    }
                                }

                                materialListView.Items.Add(item);
                            }
                        }
                    }

                    foreach (ColumnHeader column in materialListView.Columns)
                    {
                        column.Width = materialListView.Width / materialListView.Columns.Count;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler getirilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3-)
        public static async Task GetDataByMemberIDAsync(string tablo, string member_id, MaterialListView materialListView)
        {
            using (SqlConnection con = new SqlConnection(DatabaseServer.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();

                    string query = $@"
                SELECT t.* 
                FROM {tablo} t
                INNER JOIN members m ON t.member_id = m.member_id
                WHERE m.member_id = @member_id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@member_id", member_id);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                materialListView.Columns.Clear();
                                materialListView.Items.Clear();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string originalColumnName = reader.GetName(i);
                                    string translatedColumnName = Translate.TranslateColumn(originalColumnName);
                                    materialListView.Columns.Add(translatedColumnName);
                                }

                                while (await reader.ReadAsync())
                                {
                                    var item = new ListViewItem(reader[0].ToString().Trim());

                                    for (int i = 1; i < reader.FieldCount; i++)
                                    {
                                        item.SubItems.Add(reader[i].ToString().Trim());
                                    }

                                    materialListView.Items.Add(item);
                                }
                            }
                        }
                    }
                    foreach (ColumnHeader column in materialListView.Columns)
                    {
                        int maxLength = 0;

                        foreach (ListViewItem item in materialListView.Items)
                        {
                            int index = column.Index;
                            if (item.SubItems.Count > index)
                            {
                                maxLength = Math.Max(maxLength, item.SubItems[index].Text.Length);
                            }
                        }

                        maxLength = Math.Max(maxLength, column.Text.Length);

                        column.Width = maxLength * 10 + 20;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler getirilemedi: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        // 4-)
        public static async Task FillMemberList(MaterialComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Herkes");

            using (SqlConnection conn = new SqlConnection(DatabaseServer.ConnectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand("SELECT member_name, member_surname FROM members", conn))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string ad = reader["member_name"].ToString().Trim();
                            string soyad = reader["member_surname"].ToString().Trim();
                            string fullName = $"{ad} {soyad}";

                            cb.Items.Add(fullName);
                        }
                    }
                }
            }

            cb.SelectedIndex = 0;
            cb.Refresh();
        }
    }
}
