namespace Nhom15_QuanLySanPham.Views
{
    partial class frmNCC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDaCungCap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDangCungCap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.btAddNCC = new System.Windows.Forms.Button();
            this.datetimeNLDCC = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNCCname = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNCCcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNCCname = new System.Windows.Forms.Label();
            this.dataNCCs = new System.Windows.Forms.DataGridView();
            this.cNCCcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNCCname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayLanDauCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDangCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNCCs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.txtDaCungCap);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtDangCungCap);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btDel);
            this.splitContainer1.Panel1.Controls.Add(this.btUndo);
            this.splitContainer1.Panel1.Controls.Add(this.btAddNCC);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeNLDCC);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtNCCname);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel1.Controls.Add(this.txtNCCcode);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbNCCname);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataNCCs);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 537);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtDaCungCap
            // 
            this.txtDaCungCap.Location = new System.Drawing.Point(533, 132);
            this.txtDaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtDaCungCap.Name = "txtDaCungCap";
            this.txtDaCungCap.Size = new System.Drawing.Size(112, 20);
            this.txtDaCungCap.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số hàng đã cung cấp :";
            // 
            // txtDangCungCap
            // 
            this.txtDangCungCap.Location = new System.Drawing.Point(533, 110);
            this.txtDangCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtDangCungCap.Name = "txtDangCungCap";
            this.txtDangCungCap.Size = new System.Drawing.Size(112, 20);
            this.txtDangCungCap.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số hàng đang cung cấp :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(146, 82);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Địa chỉ :";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(146, 127);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 24);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUndo
            // 
            this.btUndo.Location = new System.Drawing.Point(244, 127);
            this.btUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(74, 24);
            this.btUndo.TabIndex = 5;
            this.btUndo.Text = "Đóng";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btAddNCC
            // 
            this.btAddNCC.Location = new System.Drawing.Point(42, 127);
            this.btAddNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btAddNCC.Name = "btAddNCC";
            this.btAddNCC.Size = new System.Drawing.Size(81, 24);
            this.btAddNCC.TabIndex = 4;
            this.btAddNCC.Text = "Thêm";
            this.btAddNCC.UseVisualStyleBackColor = true;
            this.btAddNCC.Click += new System.EventHandler(this.btnAddNCC_Click);
            // 
            // datetimeNLDCC
            // 
            this.datetimeNLDCC.CustomFormat = "dd/MM/yy";
            this.datetimeNLDCC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNLDCC.Location = new System.Drawing.Point(533, 15);
            this.datetimeNLDCC.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeNLDCC.Name = "datetimeNLDCC";
            this.datetimeNLDCC.Size = new System.Drawing.Size(111, 20);
            this.datetimeNLDCC.TabIndex = 3;
            this.datetimeNLDCC.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(474, 85);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNCCname
            // 
            this.txtNCCname.Location = new System.Drawing.Point(146, 47);
            this.txtNCCname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCCname.Name = "txtNCCname";
            this.txtNCCname.Size = new System.Drawing.Size(187, 20);
            this.txtNCCname.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(474, 49);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(170, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtNCCcode
            // 
            this.txtNCCcode.Location = new System.Drawing.Point(146, 11);
            this.txtNCCcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCCcode.Name = "txtNCCcode";
            this.txtNCCcode.Size = new System.Drawing.Size(187, 20);
            this.txtNCCcode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lần đầu cung cấp : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SĐT : ";
            // 
            // lbNCCname
            // 
            this.lbNCCname.AutoSize = true;
            this.lbNCCname.Location = new System.Drawing.Point(15, 13);
            this.lbNCCname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNCCname.Name = "lbNCCname";
            this.lbNCCname.Size = new System.Drawing.Size(100, 13);
            this.lbNCCname.TabIndex = 0;
            this.lbNCCname.Text = "Mã nhà cung cấp : ";
            // 
            // dataNCCs
            // 
            this.dataNCCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNCCs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNCCcode,
            this.cNCCname,
            this.cAddress,
            this.cNgayLanDauCungCap,
            this.cSDT,
            this.cEmail,
            this.cDangCungCap,
            this.cDaCungCap});
            this.dataNCCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNCCs.Location = new System.Drawing.Point(0, 0);
            this.dataNCCs.Margin = new System.Windows.Forms.Padding(2);
            this.dataNCCs.Name = "dataNCCs";
            this.dataNCCs.RowTemplate.Height = 24;
            this.dataNCCs.Size = new System.Drawing.Size(1161, 304);
            this.dataNCCs.TabIndex = 0;
            this.dataNCCs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNCCs_CellClick);
            this.dataNCCs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNCCs_CellEndEdit);
            // 
            // cNCCcode
            // 
            this.cNCCcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNCCcode.HeaderText = "Mã nhà cung cấp";
            this.cNCCcode.Name = "cNCCcode";
            // 
            // cNCCname
            // 
            this.cNCCname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNCCname.HeaderText = "Tên nhà cung cấp";
            this.cNCCname.Name = "cNCCname";
            // 
            // cAddress
            // 
            this.cAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAddress.HeaderText = "Địa chỉ";
            this.cAddress.Name = "cAddress";
            // 
            // cNgayLanDauCungCap
            // 
            this.cNgayLanDauCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNgayLanDauCungCap.HeaderText = "Ngày lần đầu cung cấp";
            this.cNgayLanDauCungCap.Name = "cNgayLanDauCungCap";
            // 
            // cSDT
            // 
            this.cSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cSDT.HeaderText = "SĐT";
            this.cSDT.Name = "cSDT";
            // 
            // cEmail
            // 
            this.cEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            // 
            // cDangCungCap
            // 
            this.cDangCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDangCungCap.HeaderText = "Đang cung cấp";
            this.cDangCungCap.Name = "cDangCungCap";
            // 
            // cDaCungCap
            // 
            this.cDaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDaCungCap.HeaderText = "Đã cung cấp";
            this.cDaCungCap.Name = "cDaCungCap";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 537);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNCC";
            this.Text = "Quản lí nhà cung cấp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNCCs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker datetimeNLDCC;
        private System.Windows.Forms.TextBox txtNCCname;
        private System.Windows.Forms.TextBox txtNCCcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNCCname;
        private System.Windows.Forms.DataGridView dataNCCs;
        private System.Windows.Forms.Button btAddNCC;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDangCungCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNCCcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNCCname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayLanDauCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDangCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDaCungCap;
    }
}