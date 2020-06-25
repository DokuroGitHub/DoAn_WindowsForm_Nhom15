using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Nhom15_QuanLySanPham.Models
{
    [Table("item")]

    public class item
    {
 
       

        [Key]
        public string itemcode { get; set; }
        public int ID { get; set; }
        public string itemname { get; set; }
        public string form { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        public DateTime NNK { get; set; }
        public string price { get; set; }
        public string NCC { get; set; }
        public byte[] image { get; set; }

        public virtual ICollection<NCC> listNCC { get; set; }
/*
        public item()
        {
            this.listNCC = new List<NCC>();
        }
*/
        public override string ToString()
        {
            return this.itemcode;
        }

        public string All()
        {
            string all = ("Mã sản phẩm:"+ itemcode +"\n" + "Tên sản phẩm: " + itemname + "\n" + "Loại: " +form + "\n" + "Giá : " + price + "\n" + "Nhà cung cấp: "+ NCC + "\nNgày sản xuất: "+NSX.ToShortDateString().ToString() +"\nHạn sử dụng:" + HSD.ToShortDateString().ToString()+"\nNgày nhập khẩu: " + NNK.ToShortDateString().ToString() ) ;
            return all;
        }

        public void ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Bmp);
                image = ms.ToArray();
            }
        }

        public Image byteArrayToImage()
        {
            using (MemoryStream memstr = new MemoryStream(image))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
    }
}
