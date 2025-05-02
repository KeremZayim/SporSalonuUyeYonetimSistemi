using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SporSalonuUyeYonetimSistemi.Classes
{
    /*
     
     1-) Form Taşıma
     2-) TextBox Sadece Rakam Girişi
     
    */

    public static class CommonMethods
    {
        // 1-)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MoveForm(IntPtr formHandle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(formHandle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // 2-)
        public static void JustNumberEntering(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlar (0-9) ve Backspace'e izin veriyoruz.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Diğer tuşlara izin verilmiyor.
            }
        }

    }
}
