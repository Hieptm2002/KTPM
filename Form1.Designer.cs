namespace QuanLyTBYT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_body = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.btn_DK = new System.Windows.Forms.Button();
            this.btn_DN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.textBox2);
            this.panel_body.Controls.Add(this.textBox1);
            this.panel_body.Controls.Add(this.lbl_MK);
            this.panel_body.Controls.Add(this.lbl_TK);
            this.panel_body.Controls.Add(this.btn_DK);
            this.panel_body.Controls.Add(this.btn_DN);
            this.panel_body.Controls.Add(this.pictureBox1);
            this.panel_body.Controls.Add(this.button1);
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(812, 468);
            this.panel_body.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Location = new System.Drawing.Point(17, 167);
            this.lbl_MK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(52, 13);
            this.lbl_MK.TabIndex = 4;
            this.lbl_MK.Text = "Mật khẩu";
            this.lbl_MK.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Location = new System.Drawing.Point(15, 122);
            this.lbl_TK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(55, 13);
            this.lbl_TK.TabIndex = 3;
            this.lbl_TK.Text = "Tài khoản";
            // 
            // btn_DK
            // 
            this.btn_DK.BackColor = System.Drawing.Color.LightBlue;
            this.btn_DK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DK.Location = new System.Drawing.Point(15, 293);
            this.btn_DK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DK.Name = "btn_DK";
            this.btn_DK.Size = new System.Drawing.Size(149, 31);
            this.btn_DK.TabIndex = 2;
            this.btn_DK.Text = "Đăng kí";
            this.btn_DK.UseVisualStyleBackColor = false;
            // 
            // btn_DN
            // 
            this.btn_DN.BackColor = System.Drawing.Color.LightBlue;
            this.btn_DN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DN.Location = new System.Drawing.Point(15, 240);
            this.btn_DN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(149, 29);
            this.btn_DN.TabIndex = 1;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.UseVisualStyleBackColor = false;
            this.btn_DN.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font(".VnArial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(812, 106);
            this.button1.TabIndex = 7;
            this.button1.Text = "PHẦN MỀM QUẢN LÝ THIẾT BỊ Y TẾ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 468);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btn_DK;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

