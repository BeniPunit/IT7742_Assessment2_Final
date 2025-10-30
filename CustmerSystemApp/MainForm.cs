using System;
using System.Windows.Forms;
using CustomerSystemApp.Controller;
using CustomerSystemApp.Model;

namespace CustomerSystemApp
{
    public partial class MainForm : Form
    {
        private CustomerController ctrl = new CustomerController();

        public MainForm()
        {
            InitializeComponent();   // defined in Designer file
            DisplayData();
        }

        private void DisplayData()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = ctrl.ShowAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.AddNew(new Customer(txtCode.Text, txtName.Text));
                DisplayData();
                MessageBox.Show("Customer added successfully!");
                ClearBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.EditCustomer(txtCode.Text, txtName.Text);
                DisplayData();
                MessageBox.Show("Customer updated successfully!");
                ClearBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.RemoveCustomer(txtCode.Text);
                DisplayData();
                MessageBox.Show("Customer deleted successfully!");
                ClearBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void ClearBoxes()
        {
            txtCode.Text = "";
            txtName.Text = "";
        }
    }
}
