using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom15_QuanLySanPham.Models;
using Nhom15_QuanLySanPham.Controllers;

namespace Nhom15_QuanLySanPham.Views
{
    public partial class frmNCC : Form
    {

        List<NCC> listNCCs;
        BindingSource source = new BindingSource();
        DateTimePicker dtp;

        public frmNCC(ref List<NCC> listncc)
        {
            listNCCs = listncc;
            
            InitializeComponent();

            this.cNCCname.DataPropertyName = nameof(NCC.NCCname);
            this.cNCCcode.DataPropertyName = nameof(NCC.NCCcode);
            this.cAddress.DataPropertyName = nameof(NCC.address);
            this.cSDT.DataPropertyName = nameof(NCC.SDT);
            this.cEmail.DataPropertyName = nameof(NCC.email);
            this.cDaCungCap.DataPropertyName = nameof(NCC.DaCungCap);
            this.cDangCungCap.DataPropertyName = nameof(NCC.DangCungCap);
            this.cNgayLanDauCungCap.DataPropertyName = nameof(NCC.NLDCC);

            this.source.DataSource = NCCController.getListNCCs();
            dataNCCs.AutoGenerateColumns = false;
            this.dataNCCs.DataSource = source;



            this.helpProvider1.SetShowHelp(txtNCCcode, true);
            this.helpProvider1.SetHelpString(this.txtNCCcode, "Nhap NCC name ");

            this.helpProvider1.SetShowHelp(txtNCCname, true);
            this.helpProvider1.SetHelpString(this.txtNCCname, "Nhap ma NCC");

            this.helpProvider1.SetShowHelp(datetimeNLDCC, true);
            this.helpProvider1.SetHelpString(this.datetimeNLDCC, "Chon Ngay lan dau cung cap");

            this.helpProvider1.SetShowHelp(dataNCCs, true);
            this.helpProvider1.SetHelpString(this.dataNCCs, "Hien thi thong tin cua User");

            this.helpProvider1.SetShowHelp(btAddNCC, true);
            this.helpProvider1.SetHelpString(this.btAddNCC, "Nhan de them NCC vao danh sach");

            this.helpProvider1.SetShowHelp(btUndo, true);
            this.helpProvider1.SetHelpString(this.btUndo, "Quay lai trang chu ");

            /*
            source = new BindingSource();
            source.DataSource = itemController.getListitem();
            this.dataitem.DataSource = source;      */
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btOut_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            //this.dataitem.CurrentCell.Value = this.dtp.Value.ToString();

            this.dataNCCs.CurrentRow.Cells[3].Value = this.dtp.Value.Date.ToString("dd/MM/yyyy");

            this.dataNCCs.CurrentCell.Value = this.dtp.Value.ToString();
            NCC ncc = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
            if (this.dataNCCs.CurrentCell.ColumnIndex == 3)
            {
                ncc.NLDCC = this.dtp.Value;
            }
           
           

            NCCController.UpdateNCC(ncc);

        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (this.dataNCCs.SelectedRows.Count <= 0)
                return;
            NCC nCC = NCCController.getNCC(this.dataNCCs.SelectedRows[0].Cells[0].Value.ToString());
            NCCController.DeleteNCC(nCC);

            /////Hien thi datagridview
            BindingSource source = new BindingSource();
            source.DataSource = NCCController.getListNCCs();
            this.dataNCCs.DataSource = source;

/*
            try
            {
                this.dataitem.Rows.RemoveAt(this.dataitem.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Hay chon dong can xoa");
            }
*/
        }

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int x = 1;

            if (this.txtNCCcode.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtNCCcode, "Hãy nhập ma NCC!");
                x = 0;
            }
            else if (NCCController.getNCC(this.txtNCCcode.Text.Trim()) != null)
            {
                this.errorProvider.SetError(this.txtNCCcode, "NCC da ton tai");
                return;
            }
            if (this.txtNCCname.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtNCCname, "Hãy nhập tên NCC");
                x = 0;
            }

            if (this.txtNCCname.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtAddress, "Hãy nhập dia chi NCC");
                x = 0;
            }

            if (DateTime.Now.Year < datetimeNLDCC.Value.Year)
            {
                this.errorProvider.SetError(this.datetimeNLDCC, "Loi ngay lan dau tien cung cap");
                x = 0;
            }

            if (this.txtSDT.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtSDT, "Hãy nhập SĐT");
                x = 0;
            }

            if (this.txtEmail.Text.Trim().Length <= 0)
            {
                this.errorProvider.SetError(this.txtEmail, "Hãy nhập Email");
                x = 0;
            }

            if (x == 0)
                return;
            else
                errorProvider.Clear();

            //string[] row = { this.txtUsername.Text.Trim(), this.txtFullname.Text.Trim(), this.cbBox.Text.ToString(), this.datetimeBirthday.Value.ToString("dd/MM/yy") };
            //this.dataitem.Rows.Add(row);

            NCC nCC = new NCC();
            nCC.NCCcode =   this.txtNCCcode.Text.Trim();
            nCC.NCCname = this.txtNCCname.Text.Trim();
            nCC.address = this.txtAddress.Text.Trim();
            nCC.NLDCC = this.datetimeNLDCC.Value;
            nCC.SDT = this.txtSDT.Text.Trim();
            nCC.email = this.txtEmail.Text.Trim();
            nCC.DangCungCap = int.Parse(this.txtDangCungCap.Text.Trim());
            nCC.DaCungCap = int.Parse(this.txtDaCungCap.Text.Trim());

            // .Value.ToString("dd/MM/yy");

            //them NCC vao csdl
            if (NCCController.AddNCC(nCC) == false)
            {
                MessageBox.Show("Loi them NCC");
                return;
            }
            txtNCCcode.Clear();
            txtNCCname.Clear();
            txtAddress.Clear();
            datetimeNLDCC.Value = DateTime.Now;
            txtSDT.Clear();
            txtEmail.Clear();
            txtDaCungCap.Clear();
            txtDangCungCap.Clear();


            source = new BindingSource();
            source.DataSource = NCCController.getListNCCs();
            this.dataNCCs.DataSource = source;
            ///////
            this.txtNCCcode.ResetText();
            this.txtNCCname.ResetText();

            this.txtAddress.ResetText();
            this.datetimeNLDCC.ResetText();
            this.txtSDT.ResetText();
            this.txtEmail.ResetText();
            this.txtDaCungCap.ResetText();
            this.txtDangCungCap.ResetText();

            this.errorProvider.Clear();
        }

        private void dataNCCs_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dataNCCs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (this.dataNCCs.Columns[e.ColumnIndex].DataPropertyName == nameof(NCC.NLDCC))
            {
                try
                {
                    this.dataNCCs.CurrentRow.Cells[0].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập ma NCC");
                    return;
                }
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rect = this.dataNCCs.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.Size = new Size(rect.Width, rect.Height);
                try
                {
                    dtp.Value = DateTime.Parse(this.dataNCCs.CurrentCell.Value.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now;
                }
                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;
                this.dataNCCs.Controls.Add(dtp);
            }
        }

        private void dataNCCs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*
            NCC nCC = new NCC();
            if (nCC.NCCcode is null) return;
            nCC.NCCcode = this.dataNCCs.CurrentRow.Cells[0].Value.ToString();
            if (nCC.NCCcode.Length <= 0) return;
            else
            {
                nCC.NCCcode = this.dataNCCs.CurrentRow.Cells[0].Value.ToString();
            }

            if (this.dataNCCs.CurrentRow.Cells[1].Value is null)
            {
                nCC.NCCname = "";
            }
            else nCC.NCCname = this.dataNCCs.CurrentRow.Cells[1].Value.ToString();

            if (this.dataNCCs.CurrentRow.Cells[2].Value is null)
            {
                nCC.address = "";
            }
            else nCC.address = this.dataNCCs.CurrentRow.Cells[2].Value.ToString();  //remove

            if (this.dataNCCs.CurrentRow.Cells[3].Value is null)
            {
                nCC.NLDCC = new DateTime(01 / 01 / 2000);
            }
            else nCC.NLDCC = DateTime.Parse(this.dataNCCs.CurrentRow.Cells[3].Value.ToString());

            if (this.dataNCCs.CurrentRow.Cells[4].Value is null)
            {
                nCC.SDT = "";
            }
            else nCC.SDT = this.dataNCCs.CurrentRow.Cells[4].Value.ToString();

            if (this.dataNCCs.CurrentRow.Cells[5].Value is null)
            {
                nCC.email = "";
            }
            else nCC.email = this.dataNCCs.CurrentRow.Cells[5].Value.ToString();

            if (this.dataNCCs.CurrentRow.Cells[6].Value is null)
            {
                nCC.DangCungCap = 0;
            }
            else nCC.DangCungCap = int.Parse(this.dataNCCs.CurrentRow.Cells[6].Value.ToString());

            if (this.dataNCCs.CurrentRow.Cells[7].Value is null)
            {
                nCC.DaCungCap = 0;
            }
            else nCC.DaCungCap = int.Parse(this.dataNCCs.CurrentRow.Cells[7].Value.ToString());

            //cap nhat  xuong database
            NCCController.UpdateNCC(nCC);
            /////Hien thi datagridview
            //            BindingSource source = new BindingSource();
            source.DataSource = NCCController.getListNCCs();
            this.dataNCCs.DataSource = source;
            */

            if (e.ColumnIndex == 1)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.NCCname = this.dataNCCs.CurrentRow.Cells[1].Value.ToString();
                NCCController.UpdateNCC(us);
            }

            if (e.ColumnIndex == 2)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.address = this.dataNCCs.CurrentRow.Cells[2].Value.ToString();
                NCCController.UpdateNCC(us);
            }
            if (e.ColumnIndex == 4)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.SDT = this.dataNCCs.CurrentRow.Cells[4].Value.ToString();
                NCCController.UpdateNCC(us);
            }
            if (e.ColumnIndex == 5)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.email = this.dataNCCs.CurrentRow.Cells[5].Value.ToString();
                NCCController.UpdateNCC(us);
            }
            if (e.ColumnIndex == 6)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.DangCungCap = Int32.Parse(this.dataNCCs.CurrentRow.Cells[6].Value.ToString());
                NCCController.UpdateNCC(us);
            }
            if (e.ColumnIndex == 7)
            {
                NCC us = NCCController.getNCC(this.dataNCCs.CurrentRow.Cells[0].Value.ToString());
                us.DaCungCap = Int32.Parse(this.dataNCCs.CurrentRow.Cells[7].Value.ToString());
                NCCController.UpdateNCC(us);
            }
        }
    }
}
