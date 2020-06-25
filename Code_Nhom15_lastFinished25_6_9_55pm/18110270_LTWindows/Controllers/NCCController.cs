using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Models;
using Nhom15_QuanLySanPham.Views;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Nhom15_QuanLySanPham.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using NCC = Nhom15_QuanLySanPham.Models.NCC;


namespace Nhom15_QuanLySanPham.Controllers
{
    public class NCCController
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var id = (from t in _context.NCCs
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

        public static bool AddNCC(NCC nCC)
        {
/*
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                if (nCC.listitem != null)
                {
                    foreach (var iTem in nCC.listitem)
                    {
                        var itemdb = (from i in _context.items
                                      where i.itemcode == iTem.itemcode
                                      select i).Single();
                        //                      itemdb.NCCs.Add(nCC);
                    }
                }
                if (nCC.listitem != null)
                {
                    nCC.listitem.Clear();
                }
                _context.NCCs.AddOrUpdate(nCC);
                _context.SaveChanges();
                return true;
            }
*/
            try
            {
                using (var _context = new DBQuanLyBangBarcodeEntities())
                {
                    _context.NCCs.Add(nCC);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static List<NCC> getListNCCs()
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var nCC = (from u in _context.NCCs.AsEnumerable()
                           select new
                           {
                               NCCcode = u.NCCcode,
                               NCCname = u.NCCname,
                               address = u.address,
                               NLDCC = u.NLDCC,
                               SDT = u.SDT,
                               email = u.email,
                               DangCungCap = u.DangCungCap,
                               DaCungCap = u.DaCungCap
                           })
                            .Select(x => new NCC
                            {
                                NCCcode = x.NCCcode,
                                NCCname = x.NCCname,
                                address = x.address,
                                NLDCC = x.NLDCC,
                                SDT = x.SDT,
                                email = x.email,
                                DangCungCap = x.DangCungCap,
                                DaCungCap = x.DaCungCap
                            });
                return nCC.ToList();
            }
        }

        public static bool UpdateNCC(NCC nCC)
        {
            try
            {
                using (var _context = new DBQuanLyBangBarcodeEntities())
                {
                    /*
                                        foreach (var iTem in nCC.listitem)
                                        {
                                            var iTemdb = (from u in _context.items
                                                          where u.itemcode == iTem.itemcode
                                                          select u).Single();
                                            iTemdb.listNCC.Add(nCC);
                                        }
                                        nCC.listitem.Clear();
                    */
                    _context.NCCs.AddOrUpdate(nCC);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static NCC getNCC(string nCCcode)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var nCC = (from u in _context.NCCs.Include("listitem")
                           where u.NCCcode == nCCcode
                           select u).ToList();
                if (nCC.Count == 1)
                {
                    return nCC[0];
                }
                else return null;
            }
        }

        public static List<NCC> getListNCCs(string NCCnamesearch)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var nCC = (from u in _context.NCCs.AsEnumerable()
                           where u.NCCcode.Contains(NCCnamesearch)
                           select u)
                            .Select(x => new NCC
                            {
                                NCCcode = x.NCCcode,
                                NCCname = x.NCCname,
                                address = x.address,
                                NLDCC = x.NLDCC,
                                SDT = x.SDT,
                                email = x.email,
                                DangCungCap = x.DangCungCap,
                                DaCungCap = x.DaCungCap,
                            }).ToList();
                return nCC;
            }
        }

        public static bool DeleteNCC(NCC nCC)
        {
            using (var _context = new DBQuanLyBangBarcodeEntities())
            {
                var dbnCC = (from u in _context.NCCs
                             where u.NCCcode == nCC.NCCcode
                             select u).SingleOrDefault();

                _context.NCCs.Remove(dbnCC);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
