using Acelist.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelist.boundary.popupform
{
    public partial class NewCustomer : Form
    {
        private Panel mainmenupanel;
        private Form customerUI;
        private int action;
        private string idEdited;

        Customer customer = new Customer();
        public NewCustomer(Panel mainmenupanel, Form customerUI, int status, string idCust)
        {
            this.mainmenupanel = mainmenupanel;
            this.customerUI = customerUI;
            this.action = status;
            InitializeComponent();
            if (this.action == 1)
            {
                this.Text = "Edit Customer";
                this.label1.Text = "Edit Customer";
                this.textBoxID.Text = idCust;
                this.textBoxID.Enabled = false;
                this.buttonAdd.Text = "Edit";
            }
            else if (this.action == 2)
            {
                this.Text = "Edit Customer";
                this.label1.Text = "Edit Customer";
                this.textBoxID.Enabled = true;
                this.buttonAdd.Text = "Edit";
            }
            else if (this.action == 0)
            {
                this.Text = "New Customer";
                this.label1.Text = "New Customer";
                this.textBoxID.Enabled = true;
                this.buttonAdd.Text = "Add";
            }
            this.idEdited = idCust;
        }

        private void callNewCustomerUI(Form CUI)
        {
            customerUI.Close();
            this.customerUI = CUI;
            customerUI.TopLevel = false;
            customerUI.FormBorderStyle = FormBorderStyle.None;
            customerUI.Dock = DockStyle.Fill;
            this.mainmenupanel.Controls.Add(customerUI);
            this.mainmenupanel.Tag = customerUI;
            customerUI.BringToFront();
            customerUI.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Please fill all columns, Sir.");
            }
            else
            {
                if (this.action == 0)
                {
                    if (customer.isIDExist(textBoxID.Text))
                    {
                        MessageBox.Show("ID is already Exist, Sir.");
                    }
                    else
                    {
                        customer.addCustomer(textBoxID.Text, textBoxName.Text, textBoxEmail.Text, textBoxPhone.Text);
                        callNewCustomerUI(new CustomerUI(mainmenupanel));
                        this.Close();
                    }
                }
                else if (this.action == 2)
                {
                    if (customer.isIDExist(textBoxID.Text))
                    {
                        MessageBox.Show("ID is already Exist, Sir.");
                    }
                    else
                    {
                        customer.editCust(idEdited, textBoxID.Text, textBoxName.Text, textBoxEmail.Text, textBoxPhone.Text);
                        callNewCustomerUI(new CustomerUI(mainmenupanel));
                        this.Close();
                    }
                }
                else if (this.action == 1) // bisa edit tapi ID gaboleh
                {
                    customer.editWithoutEditId(textBoxID.Text, textBoxName.Text, textBoxEmail.Text, textBoxPhone.Text);
                    callNewCustomerUI(new CustomerUI(mainmenupanel));
                    this.Close();
                }
            }
        }
    }
}
