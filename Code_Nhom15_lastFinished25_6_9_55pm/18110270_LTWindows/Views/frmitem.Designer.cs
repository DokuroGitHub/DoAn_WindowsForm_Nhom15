namespace Nhom15_QuanLySanPham.Views
{
    partial class frmitem
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSearchName = new System.Windows.Forms.ListBox();
            this.txtSearchname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstNCC = new System.Windows.Forms.ListBox();
            this.datetimeNNK = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimeHSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.datetimeNSX = new System.Windows.Forms.DateTimePicker();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbItemcode = new System.Windows.Forms.Label();
            this.dataitems = new System.Windows.Forms.DataGridView();
            this.citemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataitems)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnQR);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox_QRCode);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.lstSearchName);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchname);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.lstNCC);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeNNK);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeHSD);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdditem);
            this.splitContainer1.Panel1.Controls.Add(this.datetimeNSX);
            this.splitContainer1.Panel1.Controls.Add(this.cbBox);
            this.splitContainer1.Panel1.Controls.Add(this.txtitemname);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrice);
            this.splitContainer1.Panel1.Controls.Add(this.txtitemcode);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbItemcode);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataitems);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 594);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(331, 125);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(100, 23);
            this.btnQR.TabIndex = 17;
            this.btnQR.Text = "In";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click_1);
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.Location = new System.Drawing.Point(448, 125);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(123, 114);
            this.pictureBox_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_QRCode.TabIndex = 16;
            this.pictureBox_QRCode.TabStop = false;
            this.pictureBox_QRCode.Click += new System.EventHandler(this.pictureBox_QRCode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(15, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Search NCC";
            // 
            // lstSearchName
            // 
            this.lstSearchName.FormattingEnabled = true;
            this.lstSearchName.Location = new System.Drawing.Point(85, 183);
            this.lstSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.lstSearchName.Name = "lstSearchName";
            this.lstSearchName.Size = new System.Drawing.Size(81, 56);
            this.lstSearchName.TabIndex = 14;
            this.lstSearchName.Visible = false;
            this.lstSearchName.DoubleClick += new System.EventHandler(this.lstSearchName_DoubleClick);
            // 
            // txtSearchname
            // 
            this.txtSearchname.Location = new System.Drawing.Point(85, 159);
            this.txtSearchname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchname.Name = "txtSearchname";
            this.txtSearchname.Size = new System.Drawing.Size(100, 20);
            this.txtSearchname.TabIndex = 13;
            this.txtSearchname.TextChanged += new System.EventHandler(this.txtSearchNCCname_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "DS NCC :";
            // 
            // lstNCC
            // 
            this.lstNCC.FormattingEnabled = true;
            this.lstNCC.Location = new System.Drawing.Point(220, 174);
            this.lstNCC.Margin = new System.Windows.Forms.Padding(2);
            this.lstNCC.Name = "lstNCC";
            this.lstNCC.Size = new System.Drawing.Size(87, 56);
            this.lstNCC.TabIndex = 11;
            this.lstNCC.SelectedIndexChanged += new System.EventHandler(this.lstNCC_SelectedIndexChanged);
            this.lstNCC.DoubleClick += new System.EventHandler(this.lstNCC_DoubleClick);
            // 
            // datetimeNNK
            // 
            this.datetimeNNK.CustomFormat = "dd/MM/yy";
            this.datetimeNNK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNNK.Location = new System.Drawing.Point(416, 64);
            this.datetimeNNK.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeNNK.Name = "datetimeNNK";
            this.datetimeNNK.Size = new System.Drawing.Size(155, 20);
            this.datetimeNNK.TabIndex = 10;
            this.datetimeNNK.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(328, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày nhập kho : ";
            // 
            // datetimeHSD
            // 
            this.datetimeHSD.CustomFormat = "dd/MM/yy";
            this.datetimeHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeHSD.Location = new System.Drawing.Point(416, 37);
            this.datetimeHSD.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeHSD.Name = "datetimeHSD";
            this.datetimeHSD.Size = new System.Drawing.Size(155, 20);
            this.datetimeHSD.TabIndex = 8;
            this.datetimeHSD.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(328, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hạn sử dụng : ";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(220, 123);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 24);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(18, 124);
            this.btnAdditem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(100, 24);
            this.btnAdditem.TabIndex = 4;
            this.btnAdditem.Text = "Thêm sản phẩm";
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // datetimeNSX
            // 
            this.datetimeNSX.CustomFormat = "dd/MM/yy";
            this.datetimeNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeNSX.Location = new System.Drawing.Point(416, 15);
            this.datetimeNSX.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeNSX.Name = "datetimeNSX";
            this.datetimeNSX.Size = new System.Drawing.Size(155, 20);
            this.datetimeNSX.TabIndex = 3;
            this.datetimeNSX.Value = new System.DateTime(2020, 4, 11, 0, 0, 0, 0);
            // 
            // cbBox
            // 
            this.cbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Items.AddRange(new object[] {
            "Hộp/Lon",
            "Gói/Bịch",
            "Thùng",
            "Kg"});
            this.cbBox.Location = new System.Drawing.Point(103, 85);
            this.cbBox.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(192, 21);
            this.cbBox.TabIndex = 2;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.cbBox_SelectedIndexChanged);
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(103, 47);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(2);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(192, 20);
            this.txtitemname.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(401, 91);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(170, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(103, 11);
            this.txtitemcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(192, 20);
            this.txtitemcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dạng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(328, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sản xuất : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(328, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá : ";
            // 
            // lbItemcode
            // 
            this.lbItemcode.AutoSize = true;
            this.lbItemcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbItemcode.Location = new System.Drawing.Point(15, 13);
            this.lbItemcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbItemcode.Name = "lbItemcode";
            this.lbItemcode.Size = new System.Drawing.Size(80, 13);
            this.lbItemcode.TabIndex = 0;
            this.lbItemcode.Text = "Mã sản phẩm : ";
            // 
            // dataitems
            // 
            this.dataitems.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citemCode,
            this.citemname,
            this.citemForm,
            this.cNSX,
            this.cHSD,
            this.cNNK,
            this.cPrice,
            this.cNCC});
            this.dataitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataitems.Location = new System.Drawing.Point(0, 0);
            this.dataitems.Margin = new System.Windows.Forms.Padding(2);
            this.dataitems.Name = "dataitems";
            this.dataitems.RowTemplate.Height = 24;
            this.dataitems.Size = new System.Drawing.Size(1283, 182);
            this.dataitems.TabIndex = 0;
            this.dataitems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataitems_CellClick);
            this.dataitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataitems_CellContentClick);
            this.dataitems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataitems_CellEndEdit);
            this.dataitems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataitems_DataError);
            this.dataitems.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataitems_RowLeave);
            // 
            // citemCode
            // 
            this.citemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.citemCode.HeaderText = "Mã sản phẩm";
            this.citemCode.Name = "citemCode";
            // 
            // citemname
            // 
            this.citemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.citemname.HeaderText = "Tên sản phẩm";
            this.citemname.Name = "citemname";
            // 
            // citemForm
            // 
            this.citemForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.citemForm.HeaderText = "Dạng";
            this.citemForm.Name = "citemForm";
            this.citemForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cNSX
            // 
            this.cNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNSX.HeaderText = "Ngày sản xuất";
            this.cNSX.Name = "cNSX";
            // 
            // cHSD
            // 
            this.cHSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cHSD.HeaderText = "Hạn sử dụng";
            this.cHSD.Name = "cHSD";
            // 
            // cNNK
            // 
            this.cNNK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNNK.HeaderText = "Ngày nhập kho";
            this.cNNK.Name = "cNNK";
            // 
            // cPrice
            // 
            this.cPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPrice.HeaderText = "Giá";
            this.cPrice.Name = "cPrice";
            // 
            // cNCC
            // 
            this.cNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNCC.HeaderText = "Nhà cung cấp";
            this.cNCC.Name = "cNCC";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1283, 594);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmitem";
            this.Text = "Quản lí kho hàng";
            this.Load += new System.EventHandler(this.frmitem_Load);
            this.TextChanged += new System.EventHandler(this.txtSearchNCCname_TextChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataitems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker datetimeNSX;
        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbItemcode;
        private System.Windows.Forms.DataGridView dataitems;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeNNK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datetimeHSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSearchName;
        private System.Windows.Forms.TextBox txtSearchname;
        private System.Windows.Forms.PictureBox pictureBox_QRCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNCC;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnUpdate;
    }
}