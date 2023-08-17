using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTBYT
{
    public partial class TBYT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-FN8LO94\\SQLEXPRESS;Initial Catalog=QLKD_TB_Y_TE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData_TBYT() {
            command = connection.CreateCommand();
            command.CommandText = "select * from TBYT ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DataGV.DataSource = table;
        }
        public TBYT()
        {
            InitializeComponent(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TBYT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData_TBYT();
        }
        private void DataGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tb_idTBYT.ReadOnly = true;
            int i = DataGV.CurrentRow.Index;
            tb_idTBYT.Text = DataGV.Rows[i].Cells[0].Value.ToString();
            tb_nameTBYT.Text = DataGV.Rows[i].Cells[1].Value.ToString();
            tb_mota.Text = DataGV.Rows[i].Cells[2].Value.ToString();
            tb_baohanh.Text = DataGV.Rows[i].Cells[3].Value.ToString();
            tb_xuatxu.Text = DataGV.Rows[i].Cells[4].Value.ToString();
            tb_kiemdinh.Text = DataGV.Rows[i].Cells[5].Value.ToString();
            ib_giaTBYT.Text = DataGV.Rows[i].Cells[6].Value.ToString();
        }
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            if (tb_idTBYT.ReadOnly == true)
            {
                tb_idTBYT.ReadOnly = false;
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into dbo.TBYT values('" + tb_idTBYT.Text + "', N'" + tb_nameTBYT.Text + "', N'" + tb_mota.Text + "', N'" + tb_baohanh.Text + "', N'" + tb_xuatxu.Text + "', N'" + tb_kiemdinh.Text + "'," + ib_giaTBYT.Text + ") ";
                command.ExecuteNonQuery();
                LoadData_TBYT();
            }
        }
        private void bt_capnhat_Click_1(object sender, EventArgs e)
        {
                tb_idTBYT.ReadOnly = false;
                command = connection.CreateCommand();
                command.CommandText = "update dbo.TBYT set TenTBYT = N'" + tb_nameTBYT.Text + "', MoTa = N'" + tb_mota.Text + "', BaoHanh = N'" + tb_baohanh.Text + "',XuatXu = N'" + tb_xuatxu.Text + "',KiemDinh = N'" + tb_kiemdinh.Text + "', Gia = " + ib_giaTBYT.Text + " where IDTBYT = '" + tb_idTBYT.Text + "' ";
                command.ExecuteNonQuery();
                LoadData_TBYT();
        }
        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from dbo.TBYT where IDTBYT = '" + tb_idTBYT.Text + "'";
            command.ExecuteNonQuery();
            LoadData_TBYT();
        }
    }
}