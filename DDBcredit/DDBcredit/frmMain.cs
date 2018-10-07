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

            //PopulateCustomers();
            PopulateDgv();
            PopulateDgvAccounts();
        }

        //private void PopulateCustomers()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", connection))
        //    {
        //        DataTable customerTable = new DataTable();
        //        adapter.Fill(customerTable);

        //        lstCustomers.DisplayMember = "Name";
        //        lstCustomers.ValueMember = "Id";
        //        lstCustomers.DataSource = customerTable;
        //    }
        //}

        //private void PopulateAdresses()
        //{
        //    string query = "SELECT a.AccountStatus FROM Accounts a" +
        //        " INNER JOIN CustomerAccount b ON a.Id = b.AccountId" +
        //        " WHERE b.CustomerId = @CustomerId";

        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //    {
        //        command.Parameters.AddWithValue("@CustomerId", lstCustomers.SelectedValue);

        //        DataTable adressesTable = new DataTable();
        //        adapter.Fill(adressesTable);

        //        lstAdresses.DisplayMember = "AccountStatus";
        //        lstAdresses.ValueMember = "Id";
        //        lstAdresses.DataSource = adressesTable;
        //    }
        //}

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

        private void PopulateDgvAccounts()
        {
            string query = "SELECT a.AccountType, a.OpeningDate, a.ClosingDate, a.AccountStatus, a.CurrentBalance FROM Accounts a" +
                " INNER JOIN CustomerAccount b ON a.Id = b.AccountId" +
                " WHERE b.CustomerId = @CustomerId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentCell.RowIndex + 1);

                DataTable adressesTable = new DataTable();
                adapter.Fill(adressesTable);

                dgvAccounts.DataSource = adressesTable;
            }
        }

        //private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //PopulateAdresses();
        //    //PopulateDgvAccounts();
        //}

        private void btnAddCustomerName_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customers VALUES (@CustomerName, @CustomerSurname, @CustomerBirthdate, @CustomerPesel, @CustomerBirthPlace, @CustomerDocument)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                command.Parameters.AddWithValue("@CustomerSurname", txtCustomerSurname.Text);
                command.Parameters.AddWithValue("@CustomerBirthdate", txtCustomerBirthdate.Text);
                command.Parameters.AddWithValue("@CustomerPesel", txtCustomerPesel.Text);
                command.Parameters.AddWithValue("@CustomerBirthplace", txtCustomerBirthPlace.Text);
                command.Parameters.AddWithValue("@CustomerDocument", txtCustomerDocument.Text);
                txtCustomerName.Text = String.Empty;
                txtCustomerSurname.Text = String.Empty;
                txtCustomerBirthdate.Text = String.Empty;
                txtCustomerPesel.Text = String.Empty;
                txtCustomerBirthPlace.Text = String.Empty;
                txtCustomerDocument.Text = String.Empty;
                command.ExecuteScalar();
            }

            //PopulateCustomers();
            PopulateDgv();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Dot Net Perls is awesome.");

            //PopulateAdresses();
            PopulateDgvAccounts();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        // basic functionalities:
        //1.1) browse actual customers
        //1.2) add new customers
        //1.3) update info about customers, delete and do any other operation with them.

        //2.1 add new accounts - new table with accounts
        // - id has to be set automatically
        // - account type
        // - select customer
        // - colect date and time when account opened
        // - give to admin possibility to change date and user

        //2.2
        // -to customer browser add functionality to see account which he actually has and ones from the past
    }
}