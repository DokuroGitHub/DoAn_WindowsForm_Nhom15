using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Views;

namespace Nhom15_QuanLySanPham
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //     Application.Run(new frmMainGUI());
            Application.Run(new frmUI());
        }
    }
}
