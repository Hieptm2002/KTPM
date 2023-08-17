namespace QuanLyTBYT
{
    partial class TBYT
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.tb_idTBYT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nameTBYT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_baohanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_xuatxu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kiemdinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ib_giaTBYT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.DataGV);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng số liệu TBYT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DataGV
            // 
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(3, 16);
            this.DataGV.Margin = new System.Windows.Forms.Padding(2);
            this.DataGV.Name = "DataGV";
            this.DataGV.RowHeadersWidth = 51;
            this.DataGV.RowTemplate.Height = 24;
            this.DataGV.Size = new System.Drawing.Size(617, 143);
            this.DataGV.TabIndex = 1;
            this.DataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellContentClick_1);
            // 
            // tb_idTBYT
            // 
            this.tb_idTBYT.Location = new System.Drawing.Point(20, 190);
            this.tb_idTBYT.Margin = new System.Windows.Forms.Padding(2);
            this.tb_idTBYT.Name = "tb_idTBYT";
            this.tb_idTBYT.Size = new System.Drawing.Size(121, 20);
            this.tb_idTBYT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Thiết bị y tế";
            // 
            // tb_nameTBYT
            // 
            this.tb_nameTBYT.Location = new System.Drawing.Point(20, 248);
            this.tb_nameTBYT.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nameTBYT.Name = "tb_nameTBYT";
            this.tb_nameTBYT.Size = new System.Drawing.Size(121, 20);
            this.tb_nameTBYT.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên thiết bị y tế";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(20, 308);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(121, 20);
            this.tb_mota.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mô tả";
            // 
            // tb_baohanh
            // 
            this.tb_baohanh.Location = new System.Drawing.Point(20, 371);
            this.tb_baohanh.Margin = new System.Windows.Forms.Padding(2);
            this.tb_baohanh.Name = "tb_baohanh";
            this.tb_baohanh.Size = new System.Drawing.Size(121, 20);
            this.tb_baohanh.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bảo hành";
            // 
            // tb_xuatxu
            // 
            this.tb_xuatxu.Location = new System.Drawing.Point(220, 190);
            this.tb_xuatxu.Margin = new System.Windows.Forms.Padding(2);
            this.tb_xuatxu.Name = "tb_xuatxu";
            this.tb_xuatxu.Size = new System.Drawing.Size(121, 20);
            this.tb_xuatxu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xuất xứ";
            // 
            // tb_kiemdinh
            // 
            this.tb_kiemdinh.Location = new System.Drawing.Point(220, 248);
            this.tb_kiemdinh.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kiemdinh.Name = "tb_kiemdinh";
            this.tb_kiemdinh.Size = new System.Drawing.Size(121, 20);
            this.tb_kiemdinh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kiểm định";
            // 
            // ib_giaTBYT
            // 
            this.ib_giaTBYT.Location = new System.Drawing.Point(220, 308);
            this.ib_giaTBYT.Margin = new System.Windows.Forms.Padding(2);
            this.ib_giaTBYT.Name = "ib_giaTBYT";
            this.ib_giaTBYT.Size = new System.Drawing.Size(121, 20);
            this.ib_giaTBYT.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xoa.Location = new System.Drawing.Point(454, 319);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(103, 30);
            this.bt_xoa.TabIndex = 20;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiem.Location = new System.Drawing.Point(454, 280);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(103, 30);
            this.bt_timkiem.TabIndex = 19;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_capnhat.Location = new System.Drawing.Point(454, 238);
            this.bt_capnhat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(103, 30);
            this.bt_capnhat.TabIndex = 18;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = false;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click_1);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_them.Location = new System.Drawing.Point(454, 198);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 30);
            this.bt_them.TabIndex = 17;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // TBYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 420);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.ib_giaTBYT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_kiemdinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_xuatxu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_baohanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nameTBYT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_idTBYT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TBYT";
            this.Text = "TBYT";
            this.Load += new System.EventHandler(this.TBYT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.TextBox tb_idTBYT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nameTBYT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_baohanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_xuatxu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_kiemdinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ib_giaTBYT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_them;
    }
}