using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyTBYT
{

    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-FN8LO94\\SQLEXPRESS;Initial Catalog=QLKD_TB_Y_TE;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DataGV.DataSource = table;
        }
        public Form3()
        {
            InitializeComponent();
        }
        private void DataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void DataGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DataGV.CurrentRow.Index;
            tb_id.Text = DataGV.Rows[i].Cells[0].Value.ToString();
            tb_name.Text = DataGV.Rows[i].Cells[1].Value.ToString();
            dtP_ns.Text = DataGV.Rows[i].Cells[2].Value.ToString();
            cbB_1.Text = DataGV.Rows[i].Cells[3].Value.ToString();
            tb_CCCD.Text = DataGV.Rows[i].Cells[4].Value.ToString();
            tb_SDT.Text = DataGV.Rows[i].Cells[5].Value.ToString();
            tb_ADD.Text = DataGV.Rows[i].Cells[6].Value.ToString();
            tb_job.Text = DataGV.Rows[i].Cells[7].Value.ToString();
            dtP_1.Text = DataGV.Rows[i].Cells[8].Value.ToString();
            dtP_2.Text = DataGV.Rows[i].Cells[9].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
