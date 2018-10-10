namespace DDBcredit
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new DDBcredit.Database1DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DDBcredit.Database1DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new DDBcredit.Database1DataSetTableAdapters.TableAdapterManager();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerBirthdate = new System.Windows.Forms.TextBox();
            this.txtCustomerPesel = new System.Windows.Forms.TextBox();
            this.txtCustomerBirthPlace = new System.Windows.Forms.TextBox();
            this.txtCustomerDocument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBlockAccount = new System.Windows.Forms.Button();
            this.btnUnblockAccount = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.dgvAdresses = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeleteAdress = new System.Windows.Forms.Button();
            this.txtUpdateAdress = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtApartmentNo = new System.Windows.Forms.TextBox();
            this.txtAddAdress = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAdressCat = new System.Windows.Forms.TextBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerAdressTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = DDBcredit.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblCustomers.Location = new System.Drawing.Point(16, 11);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(220, 47);
            this.lblCustomers.TabIndex = 3;
            this.lblCustomers.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(19, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected customer accounts:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1049, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add new customer to database";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(1186, 149);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerName.TabIndex = 7;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(1204, 341);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(116, 28);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(25, 60);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(927, 384);
            this.dgvCustomers.TabIndex = 9;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(1186, 181);
            this.txtCustomerSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerSurname.TabIndex = 10;
            // 
            // txtCustomerBirthdate
            // 
            this.txtCustomerBirthdate.Location = new System.Drawing.Point(1186, 213);
            this.txtCustomerBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerBirthdate.Name = "txtCustomerBirthdate";
            this.txtCustomerBirthdate.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerBirthdate.TabIndex = 11;
            // 
            // txtCustomerPesel
            // 
            this.txtCustomerPesel.Location = new System.Drawing.Point(1186, 245);
            this.txtCustomerPesel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerPesel.Name = "txtCustomerPesel";
            this.txtCustomerPesel.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerPesel.TabIndex = 12;
            // 
            // txtCustomerBirthPlace
            // 
            this.txtCustomerBirthPlace.Location = new System.Drawing.Point(1186, 277);
            this.txtCustomerBirthPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerBirthPlace.Name = "txtCustomerBirthPlace";
            this.txtCustomerBirthPlace.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerBirthPlace.TabIndex = 13;
            // 
            // txtCustomerDocument
            // 
            this.txtCustomerDocument.Location = new System.Drawing.Point(1186, 309);
            this.txtCustomerDocument.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerDocument.Name = "txtCustomerDocument";
            this.txtCustomerDocument.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerDocument.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(1042, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(1042, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(1042, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(1042, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "PESEL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(1042, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Birth place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(1042, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Document no.";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(25, 486);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(927, 187);
            this.dgvAccounts.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label14.Location = new System.Drawing.Point(1093, 532);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Account type";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(1269, 592);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 28);
            this.btnAddAccount.TabIndex = 24;
            this.btnAddAccount.Text = "Add customer";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1032, 486);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(358, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "Create new account for selected user";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(1125, 341);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(71, 28);
            this.btnUpdateCustomer.TabIndex = 31;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(1046, 341);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(71, 28);
            this.btnDeleteUser.TabIndex = 32;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(976, 593);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(80, 28);
            this.btnDeleteAccount.TabIndex = 33;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(1093, 564);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Currency";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // btnBlockAccount
            // 
            this.btnBlockAccount.Location = new System.Drawing.Point(976, 526);
            this.btnBlockAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlockAccount.Name = "btnBlockAccount";
            this.btnBlockAccount.Size = new System.Drawing.Size(80, 28);
            this.btnBlockAccount.TabIndex = 36;
            this.btnBlockAccount.Text = "Block";
            this.btnBlockAccount.UseVisualStyleBackColor = true;
            this.btnBlockAccount.Click += new System.EventHandler(this.btnBlockAccount_Click);
            // 
            // btnUnblockAccount
            // 
            this.btnUnblockAccount.Location = new System.Drawing.Point(976, 560);
            this.btnUnblockAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnblockAccount.Name = "btnUnblockAccount";
            this.btnUnblockAccount.Size = new System.Drawing.Size(80, 28);
            this.btnUnblockAccount.TabIndex = 37;
            this.btnUnblockAccount.Text = "Unblock";
            this.btnUnblockAccount.UseVisualStyleBackColor = true;
            this.btnUnblockAccount.Click += new System.EventHandler(this.btnUnblockAccount_Click);
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Location = new System.Drawing.Point(976, 629);
            this.btnCloseAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(80, 28);
            this.btnCloseAccount.TabIndex = 38;
            this.btnCloseAccount.Text = "Close";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // dgvAdresses
            // 
            this.dgvAdresses.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresses.Location = new System.Drawing.Point(24, 717);
            this.dgvAdresses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdresses.Name = "dgvAdresses";
            this.dgvAdresses.RowTemplate.Height = 24;
            this.dgvAdresses.Size = new System.Drawing.Size(928, 284);
            this.dgvAdresses.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(19, 690);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Selected customer adresses:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1040, 706);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Add new adress for selected user";
            // 
            // txtDeleteAdress
            // 
            this.txtDeleteAdress.Location = new System.Drawing.Point(1057, 973);
            this.txtDeleteAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteAdress.Name = "txtDeleteAdress";
            this.txtDeleteAdress.Size = new System.Drawing.Size(71, 28);
            this.txtDeleteAdress.TabIndex = 57;
            this.txtDeleteAdress.Text = "Delete";
            this.txtDeleteAdress.UseVisualStyleBackColor = true;
            // 
            // txtUpdateAdress
            // 
            this.txtUpdateAdress.Location = new System.Drawing.Point(1136, 973);
            this.txtUpdateAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateAdress.Name = "txtUpdateAdress";
            this.txtUpdateAdress.Size = new System.Drawing.Size(71, 28);
            this.txtUpdateAdress.TabIndex = 56;
            this.txtUpdateAdress.Text = "Update";
            this.txtUpdateAdress.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(1053, 898);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label13.Location = new System.Drawing.Point(1053, 870);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 24);
            this.label13.TabIndex = 54;
            this.label13.Text = "Province";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label16.Location = new System.Drawing.Point(1053, 838);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 24);
            this.label16.TabIndex = 53;
            this.label16.Text = "Postal code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label17.Location = new System.Drawing.Point(1053, 806);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 24);
            this.label17.TabIndex = 52;
            this.label17.Text = "City";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label18.Location = new System.Drawing.Point(1053, 774);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 24);
            this.label18.TabIndex = 51;
            this.label18.Text = "Apartment no";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label19.Location = new System.Drawing.Point(1053, 742);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 50;
            this.label19.Text = "Street";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(1197, 899);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(132, 22);
            this.txtCountry.TabIndex = 49;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(1197, 867);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(132, 22);
            this.txtProvince.TabIndex = 48;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(1197, 835);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(132, 22);
            this.txtPostalCode.TabIndex = 47;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(1197, 803);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 22);
            this.txtCity.TabIndex = 46;
            // 
            // txtApartmentNo
            // 
            this.txtApartmentNo.Location = new System.Drawing.Point(1197, 771);
            this.txtApartmentNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.Size = new System.Drawing.Size(132, 22);
            this.txtApartmentNo.TabIndex = 45;
            // 
            // txtAddAdress
            // 
            this.txtAddAdress.Location = new System.Drawing.Point(1215, 973);
            this.txtAddAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddAdress.Name = "txtAddAdress";
            this.txtAddAdress.Size = new System.Drawing.Size(116, 28);
            this.txtAddAdress.TabIndex = 44;
            this.txtAddAdress.Text = "Add";
            this.txtAddAdress.UseVisualStyleBackColor = true;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(1197, 739);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(132, 22);
            this.txtStreet.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label20.Location = new System.Drawing.Point(1053, 932);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 24);
            this.label20.TabIndex = 60;
            this.label20.Text = "Adress cat.";
            // 
            // txtAdressCat
            // 
            this.txtAdressCat.Location = new System.Drawing.Point(1197, 935);
            this.txtAdressCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdressCat.Name = "txtAdressCat";
            this.txtAdressCat.Size = new System.Drawing.Size(132, 22);
            this.txtAdressCat.TabIndex = 58;
            // 
            // cbCurrency
            // 
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(1237, 561);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(132, 24);
            this.cbCurrency.TabIndex = 61;
            this.cbCurrency.Text = "EUR";
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(1237, 532);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(132, 24);
            this.cbAccountType.TabIndex = 62;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 1055);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtAdressCat);
            this.Controls.Add(this.txtDeleteAdress);
            this.Controls.Add(this.txtUpdateAdress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtApartmentNo);
            this.Controls.Add(this.txtAddAdress);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvAdresses);
            this.Controls.Add(this.btnCloseAccount);
            this.Controls.Add(this.btnUnblockAccount);
            this.Controls.Add(this.btnBlockAccount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerDocument);
            this.Controls.Add(this.txtCustomerBirthPlace);
            this.Controls.Add(this.txtCustomerPesel);
            this.Controls.Add(this.txtCustomerBirthdate);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "DDBc management panel";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerBirthdate;
        private System.Windows.Forms.TextBox txtCustomerPesel;
        private System.Windows.Forms.TextBox txtCustomerBirthPlace;
        private System.Windows.Forms.TextBox txtCustomerDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBlockAccount;
        private System.Windows.Forms.Button btnUnblockAccount;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.DataGridView dgvAdresses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button txtDeleteAdress;
        private System.Windows.Forms.Button txtUpdateAdress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtApartmentNo;
        private System.Windows.Forms.Button txtAddAdress;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAdressCat;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ComboBox cbAccountType;
    }
}

