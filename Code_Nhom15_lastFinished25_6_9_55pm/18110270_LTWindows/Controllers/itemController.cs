using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Models;
using Nhom15_QuanLySanPham.Views;
using System.Data.Entity.Migrations;
using Nhom15_QuanLySanPham.Controllers;

namespace Nhom15_QuanLySanPham.Controllers
{
    public class itemController
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var id = (from t in _context.items
                          select t.ID).ToArray();
                //return id.Max() + 1;
                if (id.Length <= 0) return 1;
                int i;
                for (i = 0; i < id.Length - 1; i++)
                {
                    if (id[i + 1] != id[i] + 1)
                        return i + 1;
                }
                return i + 1;
            }

        }

        public static bool Additem(item iTem)
        {
            try
            {
                using (var _context = new DBQuanLyBangBarcodeEntities())
                {
                    foreach (var nCC in iTem.listNCC)
                    {
                        var nCCbd = (from u in _context.NCCs
                                     where u.NCCcode == nCC.NCCcode
                                     select u).Single();
                        nCCbd.listitem.Add(iTem);
                    }
                    iTem.listNCC.Clear();
                    _context.items.AddOrUpdate(iTem);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static item getitem(string itemcode)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var iTem = (from u in _context.items
                            where u.itemcode == itemcode
                            select u).ToList();
                if (iTem.Count == 1)
                {
                    return iTem[0];
                }
                else return null;
            }
        }
        //truy xuat list item khong co ncc
        public static List<item> getListitem()
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {        
                          var iTem = (from u in _context.items.AsEnumerable()
                                      select new
                                      {
                                          itemcode = u.itemcode,
                                          itemname = u.itemname,
                                          form = u.form,
                                          NSX = u.NSX,
                                          HSD = u.HSD,
                                          price = u.price,
                                          NCC = u.NCC,
                                          NNK = u.NNK,
                                      }).Select(x => new item
                                      {
                                          itemcode = x.itemcode,
                                          itemname = x.itemname,
                                          form = x.form,
                                          NSX = x.NSX,
                                          HSD = x.HSD,
                                          price = x.price,
                                          NCC = x.NCC,
                                          NNK = x.NNK,
                                      }).ToList();
                          return iTem;    
            }
        }

        //use for NCCcode search in frmitem
        public static List<item> getListitem(string namesearch)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var iTem = (from u in _context.items.AsEnumerable()
                            where u.itemcode.Contains(namesearch)
                            select u).Select(x => new item
                            {
                                itemcode = x.itemcode,
                                itemname = x.itemname,
                                form = x.form,
                                NSX = x.NSX,
                                HSD = x.HSD,
                                price = x.price,
                                NCC = x.NCC,
                                NNK = x.NNK,
                            }).ToList();
                return iTem;
            }
        }

        public static bool Updateitem(item iTem)
        {
            try
            {
                using (var _context = new DBQuanLyBangBarcodeEntities())
                {
                    _context.items.AddOrUpdate(iTem);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool Deleteitem(item iTem)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                //xoa item
                var dbiTem = (from u in _context.items
                              where u.itemcode == iTem.itemcode
                              select u).SingleOrDefault();
/*
                foreach (var x in dbiTem.listNCC)
                {
                    foreach (var u in x.listitem)
                    {
                        if (u.itemcode == iTem.itemcode)
                        {
                            x.listitem.Remove(u);
                            break;
                        }
                    }
                }
*/
                //delete
                _context.items.Remove(dbiTem);
                _context.SaveChanges();
                return true;
            }
        }
    }

}
