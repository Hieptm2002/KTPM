using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTBYT
{   
    public partial class Hoadon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlCommand command1;
        SqlCommand command2;
        string str = "Data Source=DESKTOP-FN8LO94\\SQLEXPRESS;Initial Catalog=QLKD_TB_Y_TE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        //SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();

        void HoaDon_Load() {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon ";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dataHoadon.DataSource = table1;
        }
        void ChitietHoadon_Load() {
            command = connection.CreateCommand();
            command.CommandText = "select * from ChiTietHoaDon ";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dataChitiet.DataSource = table2;
        }

    public Hoadon()
        {
        InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            HoaDon_Load();
            ChitietHoadon_Load();
        }

        private void dataHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataHoadon.CurrentRow.Index;
            tb_idhd.Text = dataHoadon.Rows[i].Cells[0].Value.ToString();
            tb_idnv.Text = dataHoadon.Rows[i].Cells[3].Value.ToString();
            tb_idkh.Text = dataHoadon.Rows[i].Cells[4].Value.ToString();
            dt_thoigian.Text = dataHoadon.Rows[i].Cells[1].Value.ToString();
            tb_diadiem.Text = dataHoadon.Rows[i].Cells[2].Value.ToString();
            if (tb_idhd1.Text == "" && tb_idhd.Text != "")
            {
                tb_idhd1.ReadOnly = false;
                tb_idhd1.Text = dataHoadon.Rows[i].Cells[0].Value.ToString();
            }
            if (tb_idhd.Text != "")
            {
                tb_idhd.ReadOnly = true;
                tb_idhd.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
            if (tb_idhd1.Text != "")
            {
                tb_idhd1.ReadOnly = true;
                tb_idhd1.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        private void dataChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataChitiet.CurrentRow.Index;
            tb_idhd1.Text = dataChitiet.Rows[i].Cells[0].Value.ToString();
            tb_idtbyt.Text = dataChitiet.Rows[i].Cells[1].Value.ToString();
            tb_soluong.Text = dataChitiet.Rows[i].Cells[2].Value.ToString();
            tb_gia.Text = dataChitiet.Rows[i].Cells[3].Value.ToString();
            if (tb_idhd.Text == "" && tb_idhd1.Text != "")
            {
                tb_idhd.ReadOnly = false;
                tb_idhd.Text = dataChitiet.Rows[i].Cells[0].Value.ToString();
            }
            if (tb_idhd1.Text != "")
                {
                    tb_idhd1.ReadOnly = true;
                    tb_idhd1.BackColor = System.Drawing.SystemColors.ScrollBar;
                }
            if (tb_idhd.Text != "")
            {
                tb_idhd.ReadOnly = true;
                tb_idhd.BackColor = System.Drawing.SystemColors.ScrollBar;
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (tb_idhd.ReadOnly == true)
                {
                    tb_idhd.ReadOnly = false;
                    tb_idhd.BackColor = System.Drawing.SystemColors.Window;
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into HoaDon values('" + tb_idhd.Text + "', '" + dt_thoigian.Text + "', N'" + tb_diadiem.Text + "', '" + tb_idnv.Text + "', '" + tb_idkh.Text + "', 0, 0) ";
                    command.ExecuteNonQuery();
                    HoaDon_Load();
                }
            }
            
            if (tabControl1.SelectedIndex == 1)
            { 
                command = connection.CreateCommand();
                command.CommandText = "insert into ChiTietHoaDon values('" + tb_idhd1.Text + "', '" + tb_idtbyt.Text + "', '" + tb_soluong.Text + "', '" + tb_gia.Text + "', 0) ";
                command.ExecuteNonQuery();
                command1 = connection.CreateCommand();
                command1.CommandText = "UPDATE T1 SET T1.TongTien = (SELECT (T2.SoLuong * T2.Gia) sumPrice FROM ChiTietHoaDon T2 WHERE T2.IDTBYT = '" + tb_idtbyt.Text + "') FROM ChiTietHoaDon T1 WHERE T1.IDTBYT = '" + tb_idtbyt.Text + "' ";
                command1.ExecuteNonQuery();
                ChitietHoadon_Load();
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            { 
                command = connection.CreateCommand();
                command.CommandText = "UPDATE T1 SET T1.TongSoLuong = (SELECT SUM(T2.SoLuong) sumPrice FROM ChiTietHoaDon T2 WHERE T2.IDHD = '" + tb_idhd.Text + "') FROM HoaDon T1 WHERE T1.IDHD = '" + tb_idhd.Text + "';";
                command.ExecuteNonQuery();
                command1 = connection.CreateCommand();
                command1.CommandText = "UPDATE T1 SET T1.TongTien = (SELECT SUM(T2.TongTien) sumPrice1 FROM ChiTietHoaDon T2 WHERE T2.IDHD = '" + tb_idhd.Text + "') FROM HoaDon T1 WHERE T1.IDHD = '" + tb_idhd.Text + "';";
                command1.ExecuteNonQuery();
                HoaDon_Load();
            }
            if (tabControl1.SelectedIndex == 1)
            {

            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) {
                command = connection.CreateCommand();
                command.CommandText = "update HoaDon set IDNV = '" + tb_idnv.Text + "', IDKH = '" + tb_idkh.Text + "', ThoiGian = '" + dt_thoigian.Text + "', DiaDiem = '" + tb_diadiem.Text + "' where IDHD = '" + tb_idhd.Text + "' ";
                command.ExecuteNonQuery();
                HoaDon_Load();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                command = connection.CreateCommand();
                command.CommandText = "update ChiTietHoaDon set IDTBYT = '" + tb_idtbyt.Text + "', SoLuong = '" + tb_soluong.Text + "', Gia = '" + tb_gia.Text + "' where IDHD = '" + tb_idhd1.Text + "' ";
                command.ExecuteNonQuery();
                command1 = connection.CreateCommand();
                command1.CommandText = "UPDATE T1 SET T1.TongTien = (SELECT (T2.SoLuong * T2.Gia) sumPrice FROM ChiTietHoaDon T2 WHERE T2.IDTBYT = '" + tb_idtbyt.Text + "') FROM ChiTietHoaDon T1 WHERE T1.IDTBYT = '" + tb_idtbyt.Text + "' ";
                command1.ExecuteNonQuery();
                ChitietHoadon_Load();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from HoaDon where IDHD = '" + tb_idhd.Text + "'";
                command.ExecuteNonQuery();
                HoaDon_Load();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from ChiTietHoaDon where IDHD = '" + tb_idhd1.Text + "'";
                command.ExecuteNonQuery();
                ChitietHoadon_Load();
            }
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) {
                if (tb_idhd.ReadOnly == true)
                {
                    tb_idhd.ReadOnly = false;
                    tb_idhd.BackColor = System.Drawing.SystemColors.Window;
                }
                else
                {
                    //dt_thoigian = null;
                    string HD;
                    string NV;
                    string KH;
                    //string TG;
                    string DD;
                    command = connection.CreateCommand();
                    if (tb_idhd.Text == "") { HD = " is not null"; }
                        else { HD = " = '" + tb_idhd.Text +"'"; }
                    if (tb_idnv.Text == "") { NV = " is not null "; }
                     else { NV = " = '" + tb_idnv.Text + "'"; }
                    if (tb_idkh.Text == "") { KH = " is not null "; }
                        else { KH = " = '" + tb_idkh.Text + "'"; }
                    //if (dt_thoigian.Text == "") { TG = " is not null "; }
                    //    else { TG = " = '" + dt_thoigian.Text + "'"; }
                    if (tb_diadiem.Text == "") { DD = " is not null "; }
                        else { DD = " = '" + tb_diadiem.Text + "'"; }
                    command.CommandText = "SELECT * FROM HoaDon WHERE IDHD " + HD + " and IDNV " + NV + " and IDKH " + KH + /* " and ThoiGian " + TG + */ " and DiaDiem " + DD + ";";
                    adapter.SelectCommand = command;
                    table1.Clear();
                    adapter.Fill(table1);
                    dataHoadon.DataSource = table1;
                } 
            }
            if (tabControl1.SelectedIndex == 1) 
            {
                if (tb_gia.ReadOnly == false && tb_soluong.ReadOnly == false)
                {
                    tb_gia.ReadOnly = true;
                    tb_gia.BackColor = System.Drawing.SystemColors.ScrollBar;
                    tb_soluong.ReadOnly = true;
                    tb_soluong.BackColor = System.Drawing.SystemColors.ScrollBar;
                }
                else
                {
                    string TBYT;
                    command = connection.CreateCommand();
                    if (tb_idtbyt.Text == "") { TBYT = " is not null"; }
                    else { TBYT = " = '" + tb_idtbyt.Text + "'"; }
                    command.CommandText = "SELECT * FROM ChiTietHoaDon WHERE IDTBYT " + TBYT + ";";
                    adapter.SelectCommand = command;
                    table2.Clear();
                    adapter.Fill(table2);
                    dataChitiet.DataSource = table2;
                    tb_gia.ReadOnly = false;
                    tb_gia.BackColor = System.Drawing.SystemColors.Window;
                    tb_soluong.ReadOnly = false;
                    tb_soluong.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                HoaDon_Load();
            }
        }

        private void bt_refresh1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ChitietHoadon_Load();
            }
        }
    }

}
