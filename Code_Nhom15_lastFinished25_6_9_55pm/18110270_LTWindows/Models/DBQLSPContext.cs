using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Nhom15_QuanLySanPham.Models;

namespace Nhom15_QuanLySanPham.Models
{


    public class DBQuanLyBangBarcodeEntities : DbContext
    {
        public DBQuanLyBangBarcodeEntities()
            : base("name=DBQuanLyBangBarcodeEntities")
        {

        }

        public DbSet<NCC> NCCs { set; get; }
        public DbSet<item> items { set; get; }

    }


}