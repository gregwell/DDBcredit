using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DDBcredit
{
    public partial class frmMain : Form
    {
        private SqlConnection connection;
        private string connectionString;

        public frmMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DDBcredit.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
        }

        private void PopulateCustomers()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", connection))
            {
                DataTable customerTable = new DataTable();
                adapter.Fill(customerTable);

                lstCustomers.DisplayMember = "Name";
                lstCustomers.ValueMember = "Id";
                lstCustomers.DataSource = customerTable;
            }
        }
    }
}