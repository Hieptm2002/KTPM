namespace QuanLyTBYT
{
    partial class Hoadon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_diadiem = new System.Windows.Forms.Label();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.lb_idkh = new System.Windows.Forms.Label();
            this.lb_idnv = new System.Windows.Forms.Label();
            this.lb_idhd = new System.Windows.Forms.Label();
            this.dt_thoigian = new System.Windows.Forms.DateTimePicker();
            this.tb_diadiem = new System.Windows.Forms.TextBox();
            this.tb_idkh = new System.Windows.Forms.TextBox();
            this.tb_idnv = new System.Windows.Forms.TextBox();
            this.tb_idhd = new System.Windows.Forms.TextBox();
            this.box_hoadon = new System.Windows.Forms.GroupBox();
            this.dataHoadon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_gia = new System.Windows.Forms.Label();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.lb_TBYT = new System.Windows.Forms.Label();
            this.tb_idtbyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_idhd1 = new System.Windows.Forms.TextBox();
            this.box_chitiet = new System.Windows.Forms.GroupBox();
            this.dataChitiet = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_xuat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_refresh1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.box_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoadon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.box_chitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_refresh);
            this.tabPage1.Controls.Add(this.lb_diadiem);
            this.tabPage1.Controls.Add(this.lb_thoigian);
            this.tabPage1.Controls.Add(this.lb_idkh);
            this.tabPage1.Controls.Add(this.lb_idnv);
            this.tabPage1.Controls.Add(this.lb_idhd);
            this.tabPage1.Controls.Add(this.dt_thoigian);
            this.tabPage1.Controls.Add(this.tb_diadiem);
            this.tabPage1.Controls.Add(this.tb_idkh);
            this.tabPage1.Controls.Add(this.tb_idnv);
            this.tabPage1.Controls.Add(this.tb_idhd);
            this.tabPage1.Controls.Add(this.box_hoadon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_diadiem
            // 
            this.lb_diadiem.AutoSize = true;
            this.lb_diadiem.Location = new System.Drawing.Point(309, 67);
            this.lb_diadiem.Name = "lb_diadiem";
            this.lb_diadiem.Size = new System.Drawing.Size(49, 13);
            this.lb_diadiem.TabIndex = 10;
            this.lb_diadiem.Text = "Địa điểm";
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.AutoSize = true;
            this.lb_thoigian.Location = new System.Drawing.Point(58, 71);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(51, 13);
            this.lb_thoigian.TabIndex = 9;
            this.lb_thoigian.Text = "Thời gian";
            // 
            // lb_idkh
            // 
            this.lb_idkh.AutoSize = true;
            this.lb_idkh.Location = new System.Drawing.Point(523, 21);
            this.lb_idkh.Name = "lb_idkh";
            this.lb_idkh.Size = new System.Drawing.Size(78, 13);
            this.lb_idkh.TabIndex = 8;
            this.lb_idkh.Text = "ID khách hàng";
            // 
            // lb_idnv
            // 
            this.lb_idnv.AutoSize = true;
            this.lb_idnv.Location = new System.Drawing.Point(290, 24);
            this.lb_idnv.Name = "lb_idnv";
            this.lb_idnv.Size = new System.Drawing.Size(68, 13);
            this.lb_idnv.TabIndex = 7;
            this.lb_idnv.Text = "ID nhân viên";
            // 
            // lb_idhd
            // 
            this.lb_idhd.AutoSize = true;
            this.lb_idhd.Location = new System.Drawing.Point(58, 24);
            this.lb_idhd.Name = "lb_idhd";
            this.lb_idhd.Size = new System.Drawing.Size(61, 13);
            this.lb_idhd.TabIndex = 6;
            this.lb_idhd.Text = "ID hóa đơn";
            // 
            // dt_thoigian
            // 
            this.dt_thoigian.CustomFormat = "yyyy-MM-dd";
            this.dt_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_thoigian.Location = new System.Drawing.Point(125, 65);
            this.dt_thoigian.Name = "dt_thoigian";
            this.dt_thoigian.Size = new System.Drawing.Size(136, 20);
            this.dt_thoigian.TabIndex = 5;
            this.dt_thoigian.Value = new System.DateTime(2023, 7, 23, 0, 0, 0, 0);
            // 
            // tb_diadiem
            // 
            this.tb_diadiem.Location = new System.Drawing.Point(364, 64);
            this.tb_diadiem.Name = "tb_diadiem";
            this.tb_diadiem.Size = new System.Drawing.Size(343, 20);
            this.tb_diadiem.TabIndex = 4;
            // 
            // tb_idkh
            // 
            this.tb_idkh.Location = new System.Drawing.Point(607, 17);
            this.tb_idkh.Name = "tb_idkh";
            this.tb_idkh.Size = new System.Drawing.Size(100, 20);
            this.tb_idkh.TabIndex = 3;
            // 
            // tb_idnv
            // 
            this.tb_idnv.Location = new System.Drawing.Point(364, 21);
            this.tb_idnv.Name = "tb_idnv";
            this.tb_idnv.Size = new System.Drawing.Size(100, 20);
            this.tb_idnv.TabIndex = 2;
            // 
            // tb_idhd
            // 
            this.tb_idhd.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idhd.Location = new System.Drawing.Point(125, 21);
            this.tb_idhd.Name = "tb_idhd";
            this.tb_idhd.Size = new System.Drawing.Size(100, 20);
            this.tb_idhd.TabIndex = 1;
            // 
            // box_hoadon
            // 
            this.box_hoadon.Controls.Add(this.dataHoadon);
            this.box_hoadon.Location = new System.Drawing.Point(0, 128);
            this.box_hoadon.Name = "box_hoadon";
            this.box_hoadon.Size = new System.Drawing.Size(794, 230);
            this.box_hoadon.TabIndex = 0;
            this.box_hoadon.TabStop = false;
            this.box_hoadon.Text = "Bảng hóa đơn";
            // 
            // dataHoadon
            // 
            this.dataHoadon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoadon.Location = new System.Drawing.Point(0, 19);
            this.dataHoadon.Name = "dataHoadon";
            this.dataHoadon.Size = new System.Drawing.Size(794, 205);
            this.dataHoadon.TabIndex = 0;
            this.dataHoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoadon_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_refresh1);
            this.tabPage2.Controls.Add(this.lb_gia);
            this.tabPage2.Controls.Add(this.tb_gia);
            this.tabPage2.Controls.Add(this.lb_soluong);
            this.tabPage2.Controls.Add(this.tb_soluong);
            this.tabPage2.Controls.Add(this.lb_TBYT);
            this.tabPage2.Controls.Add(this.tb_idtbyt);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_idhd1);
            this.tabPage2.Controls.Add(this.box_chitiet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Location = new System.Drawing.Point(497, 70);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(23, 13);
            this.lb_gia.TabIndex = 14;
            this.lb_gia.Text = "Giá";
            // 
            // tb_gia
            // 
            this.tb_gia.BackColor = System.Drawing.SystemColors.Window;
            this.tb_gia.Location = new System.Drawing.Point(536, 66);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(168, 20);
            this.tb_gia.TabIndex = 13;
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Location = new System.Drawing.Point(81, 73);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(49, 13);
            this.lb_soluong.TabIndex = 12;
            this.lb_soluong.Text = "Số lượng";
            // 
            // tb_soluong
            // 
            this.tb_soluong.BackColor = System.Drawing.SystemColors.Window;
            this.tb_soluong.Location = new System.Drawing.Point(148, 70);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(191, 20);
            this.tb_soluong.TabIndex = 11;
            // 
            // lb_TBYT
            // 
            this.lb_TBYT.AutoSize = true;
            this.lb_TBYT.Location = new System.Drawing.Point(458, 27);
            this.lb_TBYT.Name = "lb_TBYT";
            this.lb_TBYT.Size = new System.Drawing.Size(72, 13);
            this.lb_TBYT.TabIndex = 10;
            this.lb_TBYT.Text = "ID thiết bị y tế";
            // 
            // tb_idtbyt
            // 
            this.tb_idtbyt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idtbyt.Location = new System.Drawing.Point(536, 24);
            this.tb_idtbyt.Name = "tb_idtbyt";
            this.tb_idtbyt.Size = new System.Drawing.Size(168, 20);
            this.tb_idtbyt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID hóa đơn";
            // 
            // tb_idhd1
            // 
            this.tb_idhd1.BackColor = System.Drawing.SystemColors.Window;
            this.tb_idhd1.Location = new System.Drawing.Point(148, 20);
            this.tb_idhd1.Name = "tb_idhd1";
            this.tb_idhd1.Size = new System.Drawing.Size(191, 20);
            this.tb_idhd1.TabIndex = 7;
            // 
            // box_chitiet
            // 
            this.box_chitiet.Controls.Add(this.dataChitiet);
            this.box_chitiet.Location = new System.Drawing.Point(0, 127);
            this.box_chitiet.Name = "box_chitiet";
            this.box_chitiet.Size = new System.Drawing.Size(791, 231);
            this.box_chitiet.TabIndex = 0;
            this.box_chitiet.TabStop = false;
            this.box_chitiet.Text = "bảng chi tiết hoá đơn";
            // 
            // dataChitiet
            // 
            this.dataChitiet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChitiet.Location = new System.Drawing.Point(0, 14);
            this.dataChitiet.Name = "dataChitiet";
            this.dataChitiet.Size = new System.Drawing.Size(791, 210);
            this.dataChitiet.TabIndex = 15;
            this.dataChitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChitiet_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(12, 16);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(87, 43);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(136, 16);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(87, 43);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(273, 16);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(84, 43);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Location = new System.Drawing.Point(552, 16);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(89, 43);
            this.bt_timkiem.TabIndex = 4;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_xuat
            // 
            this.bt_xuat.Location = new System.Drawing.Point(690, 16);
            this.bt_xuat.Name = "bt_xuat";
            this.bt_xuat.Size = new System.Drawing.Size(89, 43);
            this.bt_xuat.TabIndex = 6;
            this.bt_xuat.Text = "Xuất dữ liệu";
            this.bt_xuat.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(407, 16);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(84, 43);
            this.bt_capnhat.TabIndex = 7;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(6, 102);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(53, 24);
            this.bt_refresh.TabIndex = 8;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_refresh1
            // 
            this.bt_refresh1.Location = new System.Drawing.Point(6, 102);
            this.bt_refresh1.Name = "bt_refresh1";
            this.bt_refresh1.Size = new System.Drawing.Size(53, 24);
            this.bt_refresh1.TabIndex = 8;
            this.bt_refresh1.Text = "Refresh";
            this.bt_refresh1.UseVisualStyleBackColor = true;
            this.bt_refresh1.Click += new System.EventHandler(this.bt_refresh1_Click);
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xuat);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tabControl1);
            this.Name = "Hoadon";
            this.Text = "Hoadon";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.box_hoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoadon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.box_chitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.GroupBox box_hoadon;
        private System.Windows.Forms.GroupBox box_chitiet;
        private System.Windows.Forms.TextBox tb_diadiem;
        private System.Windows.Forms.TextBox tb_idkh;
        private System.Windows.Forms.TextBox tb_idnv;
        private System.Windows.Forms.TextBox tb_idhd;
        private System.Windows.Forms.Button bt_xuat;
        private System.Windows.Forms.Label lb_thoigian;
        private System.Windows.Forms.Label lb_idkh;
        private System.Windows.Forms.Label lb_idnv;
        private System.Windows.Forms.Label lb_idhd;
        private System.Windows.Forms.Label lb_diadiem;
        private System.Windows.Forms.DateTimePicker dt_thoigian;
        private System.Windows.Forms.Label lb_TBYT;
        private System.Windows.Forms.TextBox tb_idtbyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idhd1;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.DataGridView dataHoadon;
        private System.Windows.Forms.DataGridView dataChitiet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_refresh1;
    }
}