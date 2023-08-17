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
using System.Data.SqlClient;
namespace QuanLyTBYT
{
    public partial class Form5 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-9J7H9969\\SQLEXPRESS;Initial Catalog=KTMPUD;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TBYT ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DataGV.DataSource = table;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
