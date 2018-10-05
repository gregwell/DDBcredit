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

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.Customers);

            PopulateCustomers();
            PopulateDgv();
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

        private void PopulateDgv()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", connection))
            {
                var commandBuilder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);

                dgvCustomers.ReadOnly = true;
                dgvCustomers.DataSource = ds.Tables[0];
            }
        }

        private void PopulateAdresses()
        {
            string query = "SELECT a.Country FROM Adresses a" +
                " INNER JOIN CustomerAdress b ON a.Id = b.AdressId" +
                " WHERE b.CustomerId = @CustomerId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CustomerId", lstCustomers.SelectedValue);

                DataTable adressesTable = new DataTable();
                adapter.Fill(adressesTable);

                lstAdresses.DisplayMember = "Country";
                lstAdresses.ValueMember = "Id";
                lstAdresses.DataSource = adressesTable;
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAdresses();
        }

        private void btnAddCustomerName_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customers VALUES (@CustomerName, 'Surname', 'Birthdate', 'Pesel', 'Birthplace', 'Document')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                txtCustomerName.Text = String.Empty;
                command.ExecuteScalar();
            }

            PopulateCustomers();
            PopulateDgv();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}