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
    public partial class AddOrder : Form
    {
        private Menu menu = new Menu();
        private Order orders = new Order();

        private int bookid;
        private Form choosenRoom;
        public AddOrder(int bookid)
        {
            this.bookid = bookid;
            InitializeComponent();
            initialize();
            
        }

        private void initialize()
        {
            comboBoxService.Items.Clear();
            comboBoxService.Text = "";
            textBoxAmount.Text = "";
            this.labelBookId.Text = "Book #"+bookid.ToString();
            for (int i = 0; i < menu.getArrItemName().Count; i++)
            {
                comboBoxService.Items.Add(menu.getArrItemName()[i]);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxService.Text != "" && textBoxAmount.Text != "")
            {
                int itemid = menu.getItemIdFromItemName(this.comboBoxService.Text);
                orders.addOrder(bookid, itemid, Int32.Parse(textBoxAmount.Text));
                MessageBox.Show("Additional Service Added to The Booking");
                comboBoxService.Text = "";
                textBoxAmount.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill the column!");
            }
        }
    }
}
