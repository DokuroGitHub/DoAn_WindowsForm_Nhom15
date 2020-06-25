using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Models;


namespace Nhom15_QuanLySanPham.Controllers
{
    
    public class dbTestController
    {
        public static void initializeDB()
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var iTem = new item { itemcode = "ABC0123", itemname = "Mi tom", NSX = DateTime.Now , HSD=DateTime.Now, NNK = DateTime.Now };
                _context.items.Add(iTem);
                var nCC = new NCC { NCCcode = "123", NCCname = "Mien trung" , NLDCC = DateTime.Now };
                _context.NCCs.Add(nCC);

                _context.SaveChanges();
            }
            MessageBox.Show("finish"); 

        }
    }

    
}
