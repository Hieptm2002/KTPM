namespace QuanLyTBYT
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_ADD = new System.Windows.Forms.TextBox();
            this.tb_job = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_CCCD = new System.Windows.Forms.TextBox();
            this.dtP_ns = new System.Windows.Forms.DateTimePicker();
            this.dtP_1 = new System.Windows.Forms.DateTimePicker();
            this.dtP_2 = new System.Windows.Forms.DateTimePicker();
            this.cbB_1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(627, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DataGV
            // 
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGV.Location = new System.Drawing.Point(2, 15);
            this.DataGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGV.Name = "DataGV";
            this.DataGV.RowHeadersWidth = 51;
            this.DataGV.RowTemplate.Height = 24;
            this.DataGV.Size = new System.Drawing.Size(623, 145);
            this.DataGV.TabIndex = 0;
            this.DataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID nhân viên";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(20, 191);
            this.tb_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 20);
            this.tb_id.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(455, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(455, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(455, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(455, 319);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Xoá";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày bắt đầu làm việc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Số CCCD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 357);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ngày kết thúc làm việc";
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(228, 191);
            this.tb_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(130, 20);
            this.tb_SDT.TabIndex = 16;
            // 
            // tb_ADD
            // 
            this.tb_ADD.Location = new System.Drawing.Point(228, 240);
            this.tb_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ADD.Name = "tb_ADD";
            this.tb_ADD.Size = new System.Drawing.Size(130, 20);
            this.tb_ADD.TabIndex = 17;
            // 
            // tb_job
            // 
            this.tb_job.Location = new System.Drawing.Point(228, 285);
            this.tb_job.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_job.Name = "tb_job";
            this.tb_job.Size = new System.Drawing.Size(130, 20);
            this.tb_job.TabIndex = 18;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(20, 238);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 20);
            this.tb_name.TabIndex = 20;
            // 
            // tb_CCCD
            // 
            this.tb_CCCD.Location = new System.Drawing.Point(20, 375);
            this.tb_CCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_CCCD.Name = "tb_CCCD";
            this.tb_CCCD.Size = new System.Drawing.Size(121, 20);
            this.tb_CCCD.TabIndex = 23;
            // 
            // dtP_ns
            // 
            this.dtP_ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_ns.Location = new System.Drawing.Point(20, 285);
            this.dtP_ns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtP_ns.Name = "dtP_ns";
            this.dtP_ns.Size = new System.Drawing.Size(121, 20);
            this.dtP_ns.TabIndex = 25;
            // 
            // dtP_1
            // 
            this.dtP_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_1.Location = new System.Drawing.Point(230, 332);
            this.dtP_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtP_1.Name = "dtP_1";
            this.dtP_1.Size = new System.Drawing.Size(128, 20);
            this.dtP_1.TabIndex = 26;
            // 
            // dtP_2
            // 
            this.dtP_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_2.Location = new System.Drawing.Point(230, 373);
            this.dtP_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtP_2.Name = "dtP_2";
            this.dtP_2.Size = new System.Drawing.Size(128, 20);
            this.dtP_2.TabIndex = 27;
            // 
            // cbB_1
            // 
            this.cbB_1.FormattingEnabled = true;
            this.cbB_1.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbB_1.Location = new System.Drawing.Point(20, 332);
            this.cbB_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbB_1.Name = "cbB_1";
            this.cbB_1.Size = new System.Drawing.Size(121, 21);
            this.cbB_1.TabIndex = 28;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 402);
            this.Controls.Add(this.cbB_1);
            this.Controls.Add(this.dtP_2);
            this.Controls.Add(this.dtP_1);
            this.Controls.Add(this.dtP_ns);
            this.Controls.Add(this.tb_CCCD);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_job);
            this.Controls.Add(this.tb_ADD);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_ADD;
        private System.Windows.Forms.TextBox tb_job;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_CCCD;
        private System.Windows.Forms.DateTimePicker dtP_ns;
        private System.Windows.Forms.DateTimePicker dtP_1;
        private System.Windows.Forms.DateTimePicker dtP_2;
        private System.Windows.Forms.ComboBox cbB_1;
    }
}