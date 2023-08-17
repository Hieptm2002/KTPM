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
    public partial class Form6 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-9J7H9969\\SQLEXPRESS;Initial Catalog=KTMPUD;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataGridView dgv = new DataGridView();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
