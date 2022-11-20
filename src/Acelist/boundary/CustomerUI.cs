using Acelist.boundary.popupform;
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

namespace Acelist.boundary
{
    public partial class CustomerUI : Form
    {
        private Customer customer = new Customer();
        private Booking booking = new Booking();

        private Panel mainmenupanel;
        public CustomerUI(Panel mainmenupanel)
        {
            this.mainmenupanel = mainmenupanel;
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            printToTable();
        }

        private void printToTable()
        {
            string custID;
            string custName;
            string custEmail;
            string custPhone;
            customer.initialize();
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < customer.getArrCustomerId().Count; i++)
            {
                custID = customer.getArrCustomerId()[i];
                custName = customer.getArrCustomerName()[i];
                custEmail = customer.getArrEmail()[i];
                custPhone = customer.getArrPhoneNumber()[i];
                this.dataGridView1.Rows.Add(custID, custName, custEmail, custPhone);
            }
        }

        private void printSearched(string value)
        {
            string custID;
            string custName;
            string custEmail;
            string custPhone;
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < customer.getArrCustomerId().Count; i++)
            {
                if (customer.getArrCustomerName()[i].Contains(value))
                {
                    custID = customer.getArrCustomerId()[i];
                    custName = customer.getArrCustomerName()[i];
                    custEmail = customer.getArrEmail()[i];
                    custPhone = customer.getArrPhoneNumber()[i];
                    this.dataGridView1.Rows.Add(custID, custName, custEmail, custPhone);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            printSearched(this.textBox1.Text);

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer newCustForm = new NewCustomer(mainmenupanel, this, Int32.Parse("0"), "");
            newCustForm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                string idEdited = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (booking.isCustExist(idEdited) == true)
                {
                    NewCustomer newCustForm = new NewCustomer(mainmenupanel, this, Int32.Parse("1"), idEdited);
                    newCustForm.ShowDialog();
                }
                else
                {
                    NewCustomer newCustForm = new NewCustomer(mainmenupanel, this, Int32.Parse("2"), idEdited);
                    newCustForm.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                string idDeleted = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (booking.isCustExist(idDeleted) == true)
                {
                    MessageBox.Show("Can't delete customer that has a booking, Sir.");
                }
                else
                {
                    if (MessageBox.Show("Delete this customer data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        customer.deleteCust(idDeleted);
                        this.initialize();
                    }
                }
            }
        }
    }
}
