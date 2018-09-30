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

        public void frmMain_Load_1(object sender, EventArgs e)
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

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.Customers);

            PopulateCustomers();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}