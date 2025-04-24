using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Classes
{
    internal class Functions
    {
        public static async Task VerileriGetirAsync(string Tablo, MaterialListView materialListView)
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
        public static async Task detayGetir(string tablo, string member_id, MaterialListView materialListView)
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


    }
}
