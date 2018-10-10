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

            PopulateDgv();
            PopulateDgvAccounts();
            cbAddItems();
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

                dgvCustomers.Columns[0].Width = 30;
                dgvCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            }
        }

        private void PopulateDgvAccounts()
        {
            string query = "SELECT a.Id, a.AccountType, a.IBAN, a.Currency, a.OpeningDate, a.ClosingDate, a.AccountStatus, a.CurrentBalance FROM Accounts a" +
                " INNER JOIN CustomerAccount b ON a.Id = b.AccountId" +
                " WHERE b.CustomerId = @CustomerId " +
                " ORDER BY CASE WHEN a.AccountStatus = 'active' THEN 1 ELSE 2 END, a.AccountStatus";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentRow.Cells[0].Value);

                DataTable adressesTable = new DataTable();
                adapter.Fill(adressesTable);

                dgvAccounts.DataSource = adressesTable;
            }
            dgvAccounts.Columns[0].Width = 30;
            dgvAccounts.Columns[1].Width = 74;
            dgvAccounts.Columns[2].Width = 180;
            dgvAccounts.Columns[3].Width = 57;
            dgvAccounts.Columns[4].Width = 118;
            dgvAccounts.Columns[5].Width = 85;
            dgvAccounts.Columns[6].Width = 95;
            dgvAccounts.Columns[7].Width = 95;
            dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control;

            for (int i = 0; i < dgvAccounts.Rows.Count - 1; i++)
            {
                if (dgvAccounts.Rows[i].Cells[6].Value.ToString() == "active")
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#c5ffa8");
                }
                else if (dgvAccounts.Rows[i].Cells[6].Value.ToString() == "blocked")
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFA8A8");
                }
                else
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#B0B0B0");
                }
            }
        }

        //Populate Adresses
        private void PopulateDgvAdresses()
        {
            string query = "SELECT a.Id, a.AccountType, a.IBAN, a.Currency, a.OpeningDate, a.ClosingDate, a.AccountStatus, a.CurrentBalance FROM Adresses a" +
                " INNER JOIN CustomerAdress b ON a.Id = b.AdressId" +
                " WHERE b.CustomerId = @CustomerId " +
                " ORDER BY CASE WHEN a.AdressStatus = 'active' THEN 1 ELSE 2 END, a.AdressStatus";

            //I need to add adress status AND adding date AND deactivation date as a table data

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentRow.Cells[0].Value);

                DataTable adressesTable = new DataTable();
                adapter.Fill(adressesTable);

                dgvAccounts.DataSource = adressesTable;
            }
            dgvAccounts.Columns[0].Width = 30;
            dgvAccounts.Columns[1].Width = 74;
            dgvAccounts.Columns[2].Width = 180;
            dgvAccounts.Columns[3].Width = 57;
            dgvAccounts.Columns[4].Width = 118;
            dgvAccounts.Columns[5].Width = 85;
            dgvAccounts.Columns[6].Width = 95;
            dgvAccounts.Columns[7].Width = 95;
            dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control;

            for (int i = 0; i < dgvAccounts.Rows.Count - 1; i++)
            {
                if (dgvAccounts.Rows[i].Cells[6].Value.ToString() == "active")
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#c5ffa8");
                }
                else if (dgvAccounts.Rows[i].Cells[6].Value.ToString() == "blocked")
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFA8A8");
                }
                else
                {
                    dgvAccounts.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#B0B0B0");
                }
            }
        }

        // Populate adresses end

        private void btnAddCustomer_Click(object sender, EventArgs e)
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

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customers SET Name = @CustomerName, Surname = @CustomerSurname, Birthdate = @CustomerBirthdate, Pesel = @CustomerPesel, BirthPlace = @CustomerBirthPlace, Document =  @CustomerDocument WHERE Id = @CustomerId";

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
                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentCell.Value);
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Customers WHERE Id = @CustomerId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentRow.Cells[0].Value);
                command.ExecuteScalar();
            }

            PopulateDgv();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Accounts VALUES (@AccountType, @IBAN, @Currency, 'active', 0, @OpeningDate, null)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                Random rnd = new Random();
                int IBAN = rnd.Next(10000000, 99999999);

                command.Parameters.AddWithValue("@AccountType", cbAccountType.Text);
                command.Parameters.AddWithValue("@OpeningDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@IBAN", GenerateIBAN());
                command.Parameters.AddWithValue("@Currency", cbCurrency.Text);
                command.ExecuteScalar();
            }

            string query2 = "INSERT INTO CustomerAccount VALUES (@AccountId, @CustomerId)";
            string maxid = "SELECT MAX(Id) FROM Accounts";

            var userId = 1;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(maxid, connection))
            {
                connection.Open();
                //
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read(); // read first row
                userId = rd.GetInt32(0);
                //
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@AccountId", userId);
                command.Parameters.AddWithValue("@CustomerId", dgvCustomers.CurrentRow.Cells[0].Value);

                command.ExecuteScalar();
            }

            PopulateDgvAccounts();
        }

        private string GenerateIBAN()
        {
            var r = new Random();

            var v = new char[26];
            for (var j = 0; j < 26; j++) v[j] = (char)(r.NextDouble() * 10 + 48);
            return new string(v);
        }

        private void txtAccountType_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CustomerAccount WHERE AccountId = @AccountId; DELETE FROM Accounts WHERE Id = @AccountId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AccountId", dgvAccounts.CurrentRow.Cells[0].Value);
                command.ExecuteScalar();
            }

            PopulateDgvAccounts();
        }

        private void btnBlockAccount_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Accounts SET AccountStatus = 'blocked' WHERE Id = @AccountId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AccountId", dgvAccounts.CurrentRow.Cells[0].Value);

                command.ExecuteScalar();
            }

            PopulateDgvAccounts();
        }

        private void btnUnblockAccount_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Accounts SET AccountStatus = 'active' WHERE Id = @AccountId; " +
              "UPDATE Accounts SET ClosingDate = @ClosingDate WHERE Id = @AccountId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AccountId", dgvAccounts.CurrentRow.Cells[0].Value);
                command.Parameters.AddWithValue("@ClosingDate", "");

                command.ExecuteScalar();
            }

            PopulateDgvAccounts();
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Accounts SET AccountStatus = 'closed' WHERE Id = @AccountId;" +
                "UPDATE Accounts SET ClosingDate = @ClosingDate WHERE Id = @AccountId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AccountId", dgvAccounts.CurrentRow.Cells[0].Value);
                command.Parameters.AddWithValue("@ClosingDate", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

                command.ExecuteScalar();
            }

            PopulateDgvAccounts();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void cbAddItems()
        {
            cbCurrency.Items.Add("PLN");
            cbCurrency.Items.Add("EUR");
            cbCurrency.Items.Add("GBP");
            cbCurrency.Items.Add("UAH");
            cbCurrency.Items.Add("RUB");
            cbAccountType.Items.Add("checking");
            cbAccountType.Items.Add("savings");
            cbAccountType.Items.Add("business");
        }

        // TASK1: do not allow to update cells with null data. only update these cells with text inside.
        // TASK2: add new account to selected user.

        // if text box is null then download the data from this cell using sql command and fill with it this string
        //
    }
}