using System;
using System.Windows.Forms;

namespace BTL_Nhom1_QLMB
{
    internal static class Program
    {
        public static NguoiDung nguoidung;
        public static KhachHang khachHang;
        public static string macb;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_DangNhap());
        }
    }
}