using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuUyeYonetimSistemi.Classes
{
    /*
     
        Veri Tabanından Çekilen Veriler Otomatik Olarak Çekildiği İçin Sütun Adlarını Değiştirmemiz Gerek.
        Buradan Yeni Veri Eklemesi veya Düzenlemesi Yapabilirsiniz.
     
     */
    public static class Translate
    {
        public static Dictionary<string, string> ColumnTranslations = new Dictionary<string, string>()
        {
            { "member_id", "Üye ID" },
            { "member_name", "Üye Adı" },
            { "member_surname", "Üye Soyadı" },
            { "member_birthday", "Doğum Tarihi" },
            { "phone_number", "Telefon Numarası" },
            { "notes", "Notlar" },
            { "membership_id", "Üyelik ID" },
            { "membership_type", "Üyelik Türü" },
            { "membership_start_date", "Başlangıç Tarihi" },
            { "membership_end_date", "Bitiş Tarihi" },
            { "payment_id", "Ödeme ID" },
            { "payment_status", "Ödeme Durumu" },
            { "payment_date", "Ödeme Tarihi" },
            { "amount", "Tutar" },
            { "workout_id", "Antrenman ID" },
            { "height", "Boy (cm)" },
            { "weight", "Kilo (kg)" },
            { "body_fat_percentage", "Vücut Yağ Oranı" },
            { "muscle_mass", "Kas Kütlesi" },
            { "goal", "Hedef" },
            { "workout_name", "Antrenman Adı" },
            { "target_area", "Hedef Bölge" },
            { "workout_day", "Antrenman Günü" },
            { "exercise_Name", "Egzersiz Adı" },
            { "set_count", "Set Sayısı" },
            { "repetition_count", "Tekrar Sayısı" },
            { "trainer_id", "Antrenör ID" },
            { "trainer_name", "Antrenör Adı" },
            { "trainer_surname", "Antrenör Soyadı" },
            { "attendance_id", "Devam Takip ID" },
            { "check_in_time", "Giriş Zamanı" },
            { "check_out_time", "Çıkış Zamanı" },
            { "health_id", "Sağlık ID" },
            { "medical_conditions", "Sağlık Durumu" },
            { "allergies", "Alerjiler" },
            { "emergency_contact_name", "Acil Durum İletişim Adı" },
            { "emergency_contact_phone", "Acil Durum İletişim Numarası" },
            { "username", "Kullanıcı Adı" },
            { "password", "Şifre" }
        };

        public static string TranslateColumn(string columnName)
        {
            if (ColumnTranslations.ContainsKey(columnName))
            {
                return ColumnTranslations[columnName];
            }
            return columnName;
        }
    }
}
