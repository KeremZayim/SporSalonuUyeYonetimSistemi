/*

 
    Buradan Material Skin Kütüphanesini Kullanan Komponentler İçin Tema Renk Ayarlarını Yapabilirsiniz.
    
    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600,
                                                      Primary.Green700,
                                                      Primary.Green200,
                                                      Accent.Orange700,
                                                      TextShade.BLACK);

 */

using MaterialSkin;
using MaterialSkin.Controls;

namespace SporSalonuUyeYonetimSistemi.Classes
{
    public static class ThemeProperties
    {
        public static void ApplyLightTheme(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600,
                Primary.Orange700,
                Primary.Orange200,
                Accent.Orange700,
                TextShade.BLACK
            );
        }
    }
}
