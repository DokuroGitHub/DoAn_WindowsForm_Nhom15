

// my my


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using BarcodeLib;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Models;
using Nhom15_QuanLySanPham.Controllers;
using NCC = Nhom15_QuanLySanPham.Models.NCC;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Nhom15_QuanLySanPham.Views
{
    public partial class frmitem : Form
    {

        private int ID;
        DateTimePicker dtp;
        BindingSource source = new BindingSource();
        ComboBox cb;

        private List<NCC> listNCC;
        private List<item> listITEM;
      //  string temp;
   //     int choose;

      //  string filename;    
        
      //  SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-060FAJ2; Initial Catalog=BTCuoiKi_TEST; Integrated Security=true");
    

        public frmitem(ref List<item> items)
        {
            InitializeComponent();
            //     loadData();
            //           this._listitem = items;

            listNCC = NCCController.getListNCCs();
            listITEM = itemController.getListitem();

            this.citemCode.DataPropertyName = nameof(item.itemcode);
            this.citemname.DataPropertyName = nameof(item.itemname);
            this.citemForm.DataPropertyName = nameof(item.form);
            this.cNSX.DataPropertyName = nameof(item.NSX);
            this.cHSD.DataPropertyName = nameof(item.HSD);
            this.cNNK.DataPropertyName = nameof(item.NNK);
            this.cPrice.DataPropertyName = nameof(item.price);
            this.cNCC.DataPropertyName = nameof(item.NCC);
          

            this.helpProvider1.SetShowHelp(txtitemcode, true);
            this.helpProvider1.SetHelpString(this.txtitemcode, "Nhap item code ");

            this.helpProvider1.SetShowHelp(txtitemname, true);
            this.helpProvider1.SetHelpString(this.txtitemname, "Nhap ten item");

            this.helpProvider1.SetShowHelp(cbBox, true);
            this.helpProvider1.SetHelpString(this.cbBox, "Chon form ");

            this.helpProvider1.SetShowHelp(datetimeNSX, true);
            this.helpProvider1.SetHelpString(this.datetimeNSX, "Chon NSX");

            this.helpProvider1.SetShowHelp(dataitems, true);
            this.helpProvider1.SetHelpString(this.dataitems, "Hien thi thong tin cua item");

            this.helpProvider1.SetShowHelp(btnAdditem, true);
            this.helpProvider1.SetHelpString(this.btnAdditem, "Nhan de them item vao danh sach");


            source = new BindingSource();
            this.source.DataSource = itemController.getListitem();
            //hide unuse cols
            dataitems.AutoGenerateColumns = false;
            this.dataitems.DataSource = source;
     
        }
        /*
        void loadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HinhAnh",conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataitems.DataSource = dt;
            conn.Close();
        }
        */

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int x = 1;

            //Kiem tra du lieu nhap vao
            if (this.txtitemcode.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtitemcode, "Hãy nhập mã sản phẩm!");
                x = 0;
            }
            else if (itemController.getitem(this.txtitemcode.Text.Trim()) != null)
            {
                this.errorProvider.SetError(this.txtitemcode, "item da ton tai");
                return;
            }
            if (this.txtitemname.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtitemname, "Hãy nhập ten san pham");
                x = 0;
            }

            if (cbBox.SelectedItem == null)
            {
                this.errorProvider.SetError(this.cbBox, "Hãy chọn form");
                x = 0;
            }

            if (DateTime.Now.Year < datetimeNSX.Value.Year)
            {
                this.errorProvider.SetError(this.datetimeNSX, "NSX > timeNow");
                x = 0;
            }

            if (this.txtPrice.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtPrice, "Hãy nhập Gia san pham");
                x = 0;
            }
/*
            if (this.lstNCC.Items.ToString().Length <= 0)
            {
                this.errorProvider.SetError(this.lstNCC, "Hãy nhập nha cung cap");
                x = 0;
            }
*/

            if (x == 0)
                return;
            else
                errorProvider.Clear();


            item iTem = new item();
            this.ID = itemController.getIDfromDB();
            iTem.ID = this.ID;
            iTem.itemcode = this.txtitemcode.Text.Trim();
            iTem.itemname = this.txtitemname.Text.Trim();
            iTem.form = this.cbBox.SelectedItem.ToString();
            iTem.NSX = this.datetimeNSX.Value;
            iTem.HSD = this.datetimeHSD.Value;
            iTem.NNK = this.datetimeNNK.Value;
            iTem.price = this.txtPrice.Text.Trim();
            //   iTem.NCC = this.lstNCC.Text.Trim();

            iTem.listNCC = new List<NCC>();
            string displayNCCs = "";
            for (int i = 0; i < this.lstNCC.Items.Count; i++)
            {
                displayNCCs = displayNCCs.ToString() + this.lstNCC.Items[i].ToString() + " ";
                iTem.listNCC.Add(this.lstNCC.Items[i] as NCC);
            }
            iTem.NCC = displayNCCs;

            // datetimeBirthday.Value.ToString("dd/MM/yy");

            //them item vao csdl
            
            //tao qr code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(txtDataQRCode.Text, QRCodeGenerator.ECCLevel.Q));
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode( iTem.All(), QRCodeGenerator.ECCLevel.Q));
            //QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
            pictureBox_QRCode.Image = qrCode.GetGraphic(10, Color.Black, Color.White, false);
       //    iTem.ImageToByteArray(pictureBox_QRCode.Image);

            
            //add item to database
            if (itemController.Additem(iTem) == false)
            {
                MessageBox.Show("Loi them item");
                return;
            }


            //Hien thi datagridview
            source = new BindingSource();
            source.DataSource = itemController.getListitem();
            this.dataitems.DataSource = source;
            //reset boxes
            this.txtitemcode.ResetText();
            this.txtitemname.ResetText();
            this.cbBox.ResetText();
            this.datetimeNSX.ResetText();
            this.datetimeHSD.ResetText();
            this.datetimeNNK.ResetText();     
            this.txtPrice.ResetText();
         //   this.txtNCC.ResetText();
            this.lstNCC.Items.Clear();
            this.errorProvider.Clear();

        }

   

        private void dataitems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0)
            {
                return;
            }
           

            if (this.dataitems.Columns[e.ColumnIndex].DataPropertyName == nameof(item.NSX))
            {
                try
                {
                    this.dataitems.CurrentRow.Cells[0].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập ma item");
                    return;
                }
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rect = this.dataitems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.Size = new Size(rect.Width, rect.Height);

                try
                {
                    dtp.Value = DateTime.Parse(this.dataitems.CurrentCell.Value.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now; 
                }

                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;
                this.dataitems.Controls.Add(dtp);
            }
            if (this.dataitems.Columns[e.ColumnIndex].DataPropertyName == nameof(item.HSD))
            {
                try
                {
                    this.dataitems.CurrentRow.Cells[0].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập ma item");
                    return;
                }
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rect = this.dataitems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.Size = new Size(rect.Width, rect.Height);

                try
                {
                    dtp.Value = DateTime.Parse(this.dataitems.CurrentCell.Value.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now;
                }

                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;
                this.dataitems.Controls.Add(dtp);
            }
            if (this.dataitems.Columns[e.ColumnIndex].DataPropertyName == nameof(item.NNK))
            {
                try
                {
                    this.dataitems.CurrentRow.Cells[0].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập ma item");
                    return;
                }
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rect = this.dataitems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.Size = new Size(rect.Width, rect.Height);

                try
                {
                    dtp.Value = DateTime.Parse(this.dataitems.CurrentCell.Value.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now;
                }

                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;
                this.dataitems.Controls.Add(dtp);
            }

            //Combobox
            if (this.dataitems.Columns[e.ColumnIndex].DataPropertyName == nameof(item.form))
            {
               

                cb = new ComboBox();
                cb.Visible = true;                     
                Rectangle rect1 = this.dataitems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cb.Location = new Point(rect1.X, rect1.Y);
                cb.Size = new Size(rect1.Width, rect1.Height);
                cb.Items.Add("Hộp/Lon");
                cb.Items.Add("Gói/Bịch");
                cb.Items.Add("Thùng");
                cb.Items.Add("Kg");
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                try
                {
                    cb.SelectedItem = this.dataitems.CurrentCell.Value.ToString();
                }
                catch
                {
                    cb.SelectedItem = "Chưa nhập";
                }
                cb.DropDownClosed += Cb_DropDownClosed;
                cb.SelectionChangeCommitted += Cb_SelectionChangeCommitted;
           //     cb.SelectedValueChanged += Cb_SelectedValueChanged;
                
                this.dataitems.Controls.Add(cb);
            }
                
                               

            //  int r = dataitems.CurrentCell.RowIndex;
/*
            if (e.ColumnIndex == 0)
            {
                if (temp != null)
                {
                    temp = this.dataitems.CurrentRow.Cells[0].Value.ToString();
                }
                else return;
            }
            choose = e.RowIndex;
*/
        }

        private void Cb_SelectionChangeCommitted(object sender, EventArgs e)
        {


            this.dataitems.CurrentRow.Cells[2].Value = cb.SelectedItem;
            item iTem = itemController.getitem(this.dataitems.CurrentRow.Cells[0].Value.ToString());
            iTem.form = cb.SelectedItem.ToString();
            itemController.Updateitem(iTem);
        }

        private void Cb_SelectedValueChanged(object sender, EventArgs e)
        {
            
         //   cap nhat item xuong database

            
            this.source.DataSource = itemController.getListitem();
            //hide unuse cols
            dataitems.AutoGenerateColumns = false;
            this.dataitems.DataSource = source;

            this.dataitems.CurrentRow.Cells[2].Value = this.cb.SelectedItem.ToString();
            item iTem = itemController.getitem(this.dataitems.CurrentRow.Cells[0].Value.ToString());
            iTem.form = cb.SelectedItem.ToString();
            itemController.Updateitem(iTem);
        }

        private void Cb_DropDownClosed(object sender, EventArgs e)
        {
            //cb.Visible = false;
            //cb.Dispose();    
            //cb.Enabled = false;

            this.dataitems.CurrentCell.Value = this.cb.SelectedItem;
            cb.Visible = false;
            cb.Dispose();
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            //this.dataitems.CurrentCell.Value = this.dtp.Value.ToString();

            //           this.dataitems.CurrentRow.Cells[3].Value = this.dtp.Value.Date.ToString("dd/MM/yyyy");
            this.dataitems.CurrentCell.Value = this.dtp.Value.ToString();
            item iTem = itemController.getitem(this.dataitems.CurrentRow.Cells[0].Value.ToString());
            if (this.dataitems.CurrentCell.ColumnIndex == 3)
            {
                iTem.NSX = this.dtp.Value;
            }
            else if (this.dataitems.CurrentCell.ColumnIndex == 4)
            {
                iTem.NSX = this.dtp.Value;
            }
            else if (this.dataitems.CurrentCell.ColumnIndex == 5)
            {
                iTem.HSD = this.dtp.Value;
            }
            iTem.NNK = this.dtp.Value;

            itemController.Updateitem(iTem);
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void dataitems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*
            item iTem = new item();
            if (iTem.itemcode is null) return;
            iTem.itemcode = this.dataitems.CurrentRow.Cells[0].Value.ToString();
 
            if (iTem.itemcode.Length <= 0) return;
            else
            {
                iTem.itemcode = this.dataitems.CurrentRow.Cells[0].Value.ToString();
            }

            if (this.dataitems.CurrentRow.Cells[1].Value is null)
            {
                iTem.itemcode = "";
            }
            else iTem.itemname = this.dataitems.CurrentRow.Cells[1].Value.ToString();

            if (this.dataitems.CurrentRow.Cells[2].Value is null)
            {
                iTem.form = "Kg";
            }
            else iTem.form = this.dataitems.CurrentRow.Cells[2].Value.ToString();  //remove

            if (this.dataitems.CurrentRow.Cells[3].Value is null)
            {
                iTem.NSX = new DateTime(01 / 01 / 2000);
            }
            else iTem.NSX = DateTime.Parse(this.dataitems.CurrentRow.Cells[3].Value.ToString());

            if (this.dataitems.CurrentRow.Cells[4].Value is null)
            {
                iTem.HSD = new DateTime(01 / 01 / 2000);
            }
            else iTem.HSD = DateTime.Parse(this.dataitems.CurrentRow.Cells[4].Value.ToString());

            if (this.dataitems.CurrentRow.Cells[5].Value is null)
            {
                iTem.NNK = new DateTime(01 / 01 / 2000);
            }
            else iTem.NNK = DateTime.Parse(this.dataitems.CurrentRow.Cells[5].Value.ToString());

            if (this.dataitems.CurrentRow.Cells[6].Value is null)
            {
                iTem.price = "";
            }
            else iTem.price = this.dataitems.CurrentRow.Cells[6].Value.ToString();

            if (this.dataitems.CurrentRow.Cells[7].Value is null)
            {
                iTem.NCC = "";
            }
            else iTem.NCC = this.dataitems.CurrentRow.Cells[7].Value.ToString();


            //cap nhat  xuong database
            itemController.Updateitem(iTem);
            /////Hien thi datagridview
            //            BindingSource source = new BindingSource();
            source.DataSource = itemController.getListitem();
            this.dataitems.DataSource = source;
            */
            if (e.ColumnIndex == 1)
            {
                item it = itemController.getitem(this.dataitems.CurrentRow.Cells[0].Value.ToString());
                it.itemname = this.dataitems.CurrentRow.Cells[1].Value.ToString();
                itemController.Updateitem(it);
            }
          
            if (e.ColumnIndex == 6)
            {
                item it = itemController.getitem(this.dataitems.CurrentRow.Cells[0].Value.ToString());
                it.price = this.dataitems.CurrentRow.Cells[6].Value.ToString();
                itemController.Updateitem(it);
            }

        }

        private void dataitems_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (this.dataitems.SelectedRows.Count <= 0)
                return;
            item iTem = itemController.getitem(this.dataitems.SelectedRows[0].Cells[0].Value.ToString());
            if (itemController.Deleteitem(iTem) != true)
            {
                MessageBox.Show("Error!");
                return;
            }
            /////Hien thi datagridview
            source = new BindingSource();
            source.DataSource = itemController.getListitem();
            this.dataitems.DataSource = source;

            /*
                        try
                        {
                            this.dataitems.Rows.RemoveAt(this.dataitems.CurrentCell.RowIndex);
                        }
                        catch
                        {
                            MessageBox.Show("Hay chon dong can xoa");
                        }
            */
            this.txtitemcode.ResetText();
            this.txtitemname.ResetText();
            this.cbBox.ResetText();
            this.datetimeNSX.ResetText();
            this.datetimeHSD.ResetText();
            this.datetimeNNK.ResetText();
            this.txtPrice.ResetText();
      //      this.txtNCC.ResetText();
            this.lstNCC.Items.Clear();
            this.errorProvider.Clear();
            this.pictureBox_QRCode.Image = null;
        }

        private void cbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmitem_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtitemcode, true);
            this.helpProvider1.SetHelpString(this.txtitemcode, "Enter ma  item");

            this.helpProvider1.SetShowHelp(this.txtitemname, true);
            this.helpProvider1.SetHelpString(this.txtitemname, "Enter ten item");

            this.helpProvider1.SetShowHelp(this.cbBox, true);
            this.helpProvider1.SetHelpString(this.cbBox, "Choose form san pham");

            this.helpProvider1.SetShowHelp(this.datetimeNSX, true);
            this.helpProvider1.SetHelpString(this.datetimeNSX, "Enter ngay san xuat");

            this.helpProvider1.SetShowHelp(this.datetimeHSD, true);
            this.helpProvider1.SetHelpString(this.datetimeHSD, "Enter han su dung");

            this.helpProvider1.SetShowHelp(this.datetimeNNK, true);
            this.helpProvider1.SetHelpString(this.datetimeNNK, "Enter ngay nhap kho");

            this.helpProvider1.SetShowHelp(this.txtPrice, true);
            this.helpProvider1.SetHelpString(this.txtPrice, "Enter gia san pham");

       //     this.helpProvider1.SetShowHelp(this.txtNCC, true);
         //   this.helpProvider1.SetHelpString(this.txtNCC, "Enter nha cung cap");

            this.helpProvider1.SetShowHelp(this.txtSearchname, true);
            this.helpProvider1.SetHelpString(this.txtSearchname, "Chon nha cung cap");

        }


        private void dataitems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }


        private void lstSearchName_DoubleClick(object sender, EventArgs e)
        {

            if (this.lstSearchName.SelectedIndex >= 0)
            {
                if (this.lstNCC.Items.Contains(this.lstSearchName.SelectedItem))
                {
                    MessageBox.Show("NCC đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.lstNCC.Items.Add(this.lstSearchName.SelectedItem);
            }

        }

        private void pictureBox_QRCode_Click(object sender, EventArgs e)
        {

            /*
            OpenFileDialog open = new OpenFileDialog();
            if( open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_QRCode.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
            */
        }

        private void dataitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //     var item = itemController.getitem(dataitems.CurrentRow.Cells[0].Value.ToString());
            //      pictureBox_QRCode.Image = item.byteArrayToImage();


            this.lstNCC.Items.Clear();

            if (e.RowIndex >= 0)

            {

                DataGridViewRow row = this.dataitems.Rows[e.RowIndex];

                txtitemcode.Text = row.Cells["citemCode"].Value.ToString();

                txtitemname.Text = row.Cells["citemname"].Value.ToString();

                cbBox.Text = row.Cells["citemForm"].Value.ToString();

                datetimeNSX.Text = row.Cells["cNSX"].Value.ToString();

                datetimeHSD.Text = row.Cells["cHSD"].Value.ToString();

                datetimeNNK.Text = row.Cells["cNNK"].Value.ToString();

                txtPrice.Text = row.Cells["cPrice"].Value.ToString();

                //    txtNCC.Text = row.Cells["cNCC"].Value.ToString();


                

                string userOfTask  = row.Cells["cNCC"].Value.ToString();
                string aUser = "";

                for (int i = 0; i < userOfTask.Length; i++)
                {
                    if (userOfTask[i] != 32)
                    {
                        aUser = aUser + userOfTask[i];
                    }
                    if (userOfTask[i] == 32 || i == userOfTask.Length - 1)
                    {
                        for (int j = 0; j < listNCC.Count; j++)
                        {
                            if (listNCC[j].NCCcode == aUser)
                            {
                                this.lstNCC.Items.Add(listNCC[j]);
                            }
                        }
                        aUser = "";
                    }
                }
              //  lstNCC.Items.ToString


                string all = ("Mã sản phẩm:" + txtitemcode.Text + "\n" + "Tên sản phẩm: " + txtitemname.Text + "\n" + "Loại: " + cbBox.Text + "\n" + "Giá : " + txtPrice.Text + "\n" + "Nhà cung cấp: " + userOfTask + "\nNgày sản xuất: " + datetimeNSX.Text.ToString() + "\nHạn sử dụng:" + datetimeHSD.Text.ToString() + "\nNgày nhập khẩu: " + datetimeNNK.Text.ToString());



                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                //QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(txtDataQRCode.Text, QRCodeGenerator.ECCLevel.Q));
                QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(all, QRCodeGenerator.ECCLevel.Q));
                //QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
                pictureBox_QRCode.Image = qrCode.GetGraphic(10, Color.Black, Color.White, false);
              //  iTem.ImageToByteArray(pictureBox_QRCode.Image);

            }

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
           
        }

        private void lstNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNCC_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstNCC.SelectedIndex >= 0)
            {
                this.lstNCC.Items.RemoveAt(this.lstNCC.SelectedIndex);
            }
        }

        private void txtSearchNCCname_TextChanged(object sender, EventArgs e)
        {
            this.lstSearchName.Items.Clear();
            // tim NCCname trong listNCCs
            List<NCC> searchNCCs = NCCController.getListNCCs(this.txtSearchname.Text.Trim());
            if (searchNCCs.Count > 0)
            {
                this.lstSearchName.Visible = true;
            }
            else
            {
                this.lstSearchName.Visible = false;
            }
            for (int i = 0; i < searchNCCs.Count; i++)
            {
                this.lstSearchName.Items.Add(searchNCCs[i]);
            }
            /*
                        if (this.txtSearchname.Text == "")
                        {
                            this.lstSearchName.Items.Clear();
                            this.lstSearchName.Visible = false;
                        }
            */
            //var c = this.lstSearchName.Items[0];

        }

        private void btnQR_Click_1(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage    += printDoc_PrintPage;

            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();

        }
        private void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            Bitmap qr = new Bitmap(pictureBox_QRCode.Width, pictureBox_QRCode.Height);
            pictureBox_QRCode.DrawToBitmap(qr, new Rectangle(0, 0, pictureBox_QRCode.Width, pictureBox_QRCode.Height));
            e.Graphics.DrawImage(qr, 0, 0);
            qr.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            item iTem = new item();
            this.ID = itemController.getIDfromDB();
            iTem.ID = this.ID;
            iTem.itemcode = this.txtitemcode.Text;
            iTem.itemname = this.txtitemname.Text;
            iTem.form = this.cbBox.SelectedItem.ToString();
            iTem.NSX = this.datetimeNSX.Value;
            iTem.HSD = this.datetimeHSD.Value;
            iTem.NNK = this.datetimeNNK.Value;
            iTem.price = this.txtPrice.Text;
            //   iTem.NCC = this.lstNCC.Text.Trim();

            iTem.listNCC = new List<NCC>();
            string displayNCCs = "";
            for (int i = 0; i < this.lstNCC.Items.Count; i++)
            {
                displayNCCs = displayNCCs.ToString() + this.lstNCC.Items[i].ToString() + " ";
                iTem.listNCC.Add(this.lstNCC.Items[i] as NCC);
            }
            iTem.NCC = displayNCCs;

            // datetimeBirthday.Value.ToString("dd/MM/yy");
           
            //them item vao csdl

            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            //QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(txtDataQRCode.Text, QRCodeGenerator.ECCLevel.Q));
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(iTem.All(), QRCodeGenerator.ECCLevel.Q));
            //QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
            pictureBox_QRCode.Image = qrCode.GetGraphic(10, Color.Black, Color.White, false);
         //   iTem.ImageToByteArray(pictureBox_QRCode.Image);
            

            //add item to database
            if (itemController.Updateitem(iTem) == false)
            {
                MessageBox.Show("Loi them item");
                return;
            }

          

            //Hien thi datagridview
            source = new BindingSource();
            source.DataSource = itemController.getListitem();
            this.dataitems.DataSource = source;
        }
    }
}
