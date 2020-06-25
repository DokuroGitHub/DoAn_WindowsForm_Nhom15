using Nhom15_QuanLySanPham.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nhom15_QuanLySanPham.Views
{
    public partial class frmUI : Form
    {
        bool isMouseDown;
        int xLast;
        int yLast;

        frmNCC formNCC;
        frmitem formitem;
        List<item> listitem;
        List<NCC> listNCC;


        public frmUI()
        {
            InitializeComponent();
            SidePanel.Height = btnQuanLi.Height;
            SidePanel.Top = btnQuanLi.Top;
           
        }

      

        private void PbRe_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PbRe.Visible = false;
            PbMaxsize.Visible = true;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbMinisize_Click(object sender, EventArgs e)
        {          
            WindowState = FormWindowState.Minimized;
            
        }


        private void PbMaxsize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PbMaxsize.Visible = false;
            PbRe.Visible = true;
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            xLast = e.X;
            yLast = e.Y;

            base.OnMouseDown(e);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int newY = this.Top + (e.Y - yLast);
                int newX = this.Left + (e.X - xLast);

                this.Location = new Point(newX, newY);
            }

            base.OnMouseMove(e);
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            base.OnMouseUp(e);
        }

        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.Red;
            SidePanel.Height = btnQuanLi.Height;
            SidePanel.Top = btnQuanLi.Top;
            lbHome.Text = "Kho hàng";
            PbHome.Image = PbQuanLi.Image;

            ShowPanel.Controls.Clear();


            this.formitem = new frmitem(ref listitem);
                //       this.formitem.MdiParent = this;
            formitem.TopLevel = false;
            ShowPanel.Controls.Add(formitem);
            formitem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            formitem.Dock = DockStyle.Fill;
            this.formitem.Show();
            
            
        }

        private void PbQuanLi_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.Red;
            SidePanel.Height = btnQuanLi.Height;
            SidePanel.Top = btnQuanLi.Top;
            lbHome.Text = "Kho hàng";
            PbHome.Image = PbQuanLi.Image;

            ShowPanel.Controls.Clear();

         

                this.formitem = new frmitem(ref listitem);
                //      this.formitem.MdiParent = this;
                formitem.TopLevel = false;
                ShowPanel.Controls.Add(formitem);
                formitem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                formitem.Dock = DockStyle.Fill;
                this.formitem.Show();
         
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.Red;          
            SidePanel.Height = btnNhaCungCap.Height;
            SidePanel.Top = btnNhaCungCap.Top;
            lbHome.Text = "Nhà cung cấp";
            PbHome.Image = PbNCC.Image;

            ShowPanel.Controls.Clear();

                this.formNCC = new frmNCC(ref listNCC);
                //      this.formNCC.MdiParent = this;
                formNCC.TopLevel = false;
                ShowPanel.Controls.Add(formNCC);
                formNCC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                formNCC.Dock = DockStyle.Fill;
                this.formNCC.Show();
         
        }

        private void PbNCC_Click(object sender, EventArgs e)
        {
            SidePanel.BackColor = Color.Red;
            SidePanel.Height = btnNhaCungCap.Height;
            SidePanel.Top = btnNhaCungCap.Top;
            lbHome.Text = "Nhà cung cấp";
            PbHome.Image = PbNCC.Image;

            ShowPanel.Controls.Clear();

          
                this.formNCC = new frmNCC(ref listNCC);
                //       this.formNCC.MdiParent = this;
                formNCC.TopLevel = false;
                ShowPanel.Controls.Add(formNCC);
                formNCC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                formNCC.Dock = DockStyle.Fill;
                this.formNCC.Show();
          
        }
    }
}
