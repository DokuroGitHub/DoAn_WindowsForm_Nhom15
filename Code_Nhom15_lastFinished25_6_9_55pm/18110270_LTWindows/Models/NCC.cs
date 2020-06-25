using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom15_QuanLySanPham.Models
{
    [Table("NCC")]

    public class NCC
    {
  

        [Key]
        public string NCCcode { get; set; }
        public int ID { get; set; }
        public string NCCname { get; set; }
        public string address { get; set; }
        public DateTime NLDCC { get; set; }
        public string SDT { get; set; }
        public string email { get; set; }
        public int DangCungCap { get; set; }
        public int DaCungCap { get; set; }

        public virtual ICollection<item> listitem { get; set; }

        //bo .system trong search engine
        public NCC()
        {
            this.listitem = new List<item>();
        }

        public override string ToString()
        {
            return this.NCCcode;
        }
    }
}
