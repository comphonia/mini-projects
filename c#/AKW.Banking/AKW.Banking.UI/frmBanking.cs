using AKW.Banking.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AKW.Banking.UI
{
    public partial class frmBanking : Form
    {
        Customers customers = new Customers();
        Customer customer;
        List<Customer> customerData;

        bool Addmode = false;

        public frmBanking()
        {
            InitializeComponent();
        }

        // On the load
        private void frmBanking_Load(object sender, EventArgs e)
        {
            customerData = customers.ReadFile();

            Rebind(customerData);

        }


        //ListBox Names
        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Addmode = false;

            if (lstNames.SelectedIndex > -1)
            {
                int index = lstNames.SelectedIndex;
                txtSSN.Text = customerData[index].SSN;
                txtFirstName.Text = customerData[index].FirstName;
                txtLastName.Text = customerData[index].LastName;
                txtAge.Text = customerData[index].Age.ToString();
                txtBirthDate.Text = customerData[index].BirthDate.Date.ToString("M/dd/yyyy");

                if (Addmode == true)
                    lblid.Text = customerData.Count.ToString();
                else
                    lblid.Text = lstNames.SelectedIndex.ToString();
            }
        }

        //FieldChange Method
        private void FieldChange(int index)
        {
            customer = customers[index];
            txtSSN.Text = customer.SSN;
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtAge.Text = customer.Age.ToString();
            txtBirthDate.Text = customer.BirthDate.ToString();
            lblid.Text = customer.CustomerID.ToString();
            txtFirstName.Text = customer.FirstName + " " + customer.LastName;
        }


        //Rebind Method
        public void Rebind(List<Customer> customerData)
        {
            /*  customer = new Customer();
              //customer.Populate();

              //dgv
              //  dgvdeposit.DataSource = null;
              dgvdeposit.DataSource = customer.DepositList;
              //  dgvwithdrawl.DataSource = null;
              dgvwithdrawl.DataSource = customer.WithDrawlList;

              //Listbox
              lstNames.DataSource = null;
              lstNames.DataSource = customers;
              lstNames.DisplayMember = "FullName";
              lstNames.ValueMember = "CustomerID"; */

            List<string> customerNameDS = new List<string>();
            DepositList depositDS = new DepositList();
            WithDrawlList withdrawalDS = new WithDrawlList();

            //populate datasources
            for (int i = 0; i < customerData.Count; i++)
            {
                customerNameDS.Add(customerData[i].FullName);
                depositDS.AddRange(customerData[i].DepositList);
                withdrawalDS.AddRange(customerData[i].WithDrawlList);

            }


            int index;
            index = lstNames.SelectedIndex;

            //bind datasource
            lstNames.DataSource = customerNameDS;
            dgvdeposit.DataSource = depositDS;
            dgvwithdrawl.DataSource = withdrawalDS;


        }



        private void dgvdeposit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdeposit.CurrentRow != null)
            {
                // customer = customers[dgvdeposit.CurrentRow.Index];
            }
        }

        private void dgvwithdrawl_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvwithdrawl.CurrentRow != null)
            {
                // customer = customers[dgvwithdrawl.CurrentRow.Index];
            }
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            int index;
            index = lstNames.SelectedIndex;
            //  dgvdeposit.DataSource = customers[index].DepositList;
            //  dgvwithdrawl.DataSource = customers[index].WithDrawlList;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //customer variables
            int id = Convert.ToInt32(lblid.Text);
            string ssn = txtSSN.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            DateTime date = Convert.ToDateTime(txtBirthDate.Text);
            string fullName = txtFirstName.Text + " " + txtLastName.Text;

            customer = new Customer(id, ssn, firstName, lastName, age, date, fullName);

            //update deposit/withdrawal values
            customer.AddDeposits(id, 0, date);
            customer.AddWithDrawl(id, 0, date);

            customerData.Add(customer);
            Rebind(customerData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSSN.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtBirthDate.Text = "";
            if (Addmode == true)
                lblid.Text = customerData.Count.ToString();
            else
                lblid.Text = lstNames.SelectedIndex.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Addmode = true;

            txtSSN.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtBirthDate.Text = "";
            if (Addmode == true)
                lblid.Text = customerData.Count.ToString();
            else
                lblid.Text = lstNames.SelectedIndex.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstNames.SelectedIndex;
            customerData.RemoveAt(index);
            Rebind(customerData);
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            customers.WriteFile(customerData);
        }
    }

}

