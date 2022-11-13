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
    public partial class ChoosenRoomUI : Form
    {
        private Panel mainmenupanel;
        private Form availabilityUI;
        private Booking booking = new Booking();
        private Button roomMapButton;
        private int bookid;
        public ChoosenRoomUI(Button roomMapButton, Panel mainmenupanel, Form availabilityUI, int bookid)
        {
            InitializeComponent();
            this.bookid = bookid;
            initialize(roomMapButton);
            this.mainmenupanel = mainmenupanel;
            this.availabilityUI = availabilityUI;
            this.roomMapButton = roomMapButton;
            
        }
        private void initialize(Button roomMapButton)
        {
            if (roomMapButton.BackColor == Color.FromArgb(21, 87, 36)) // ijo
            {
                this.checkBoxCheckin.Enabled = false;
                this.checkBoxCheckout.Enabled = false;
                this.buttonNewBook.Text = "New Book";
                this.buttonAddService.Enabled = false;
                this.buttonBills.Enabled = false;
                this.labelBook.Text = "Book ###";
                this.labelCheckin.Text = "Checkin Date: ###";
                this.labelCheckout.Text = "Checkout Date: ###";
                this.labelCustomer.Text = "Customer: ###";
                this.labelReceptionist.Text = "Receptionist: ###";
                this.labelTotalBill.Text = "Total Bill: Rp. ###";
                this.labelRoom.Text = "Room #" + roomMapButton.Text;
            }
            else // kuning atau merah
            {
                int idxBook = booking.findIdx(bookid);

                this.checkBoxCheckin.Enabled = true;
                this.checkBoxCheckout.Enabled = false;
                this.buttonNewBook.Text = "Delete Book";
                this.buttonNewBook.BackColor = Color.FromArgb(97, 6, 26);
                this.buttonNewBook.Enabled = true;
                this.buttonAddService.Enabled = false;
                this.buttonBills.Enabled = false;
                this.labelBook.Text = "Book #" + this.bookid.ToString();
                this.labelCheckin.Text = "Checkin Date: " + booking.getArrCheckinTime()[idxBook].ToShortDateString();
                this.labelCheckout.Text = "Checkout Date: " + booking.getArrCheckoutTime()[idxBook].ToShortDateString();
                this.labelCustomer.Text = "Customer: " + booking.getArrCustomerID()[idxBook].ToString(); // nanti bagian ini ganti nama
                this.labelReceptionist.Text = "Receptionist: " + booking.getArrEmployeeID()[idxBook].ToString(); 
                this.labelTotalBill.Text = "Total Bill: Rp. ###"; // to be implement
                this.labelRoom.Text = "Room #" + roomMapButton.Text;
                

                if (roomMapButton.BackColor == Color.FromArgb(97, 6, 26))
                {
                    if (booking.getArrHasCheckedIn()[idxBook] == true)
                    {
                        this.checkBoxCheckout.Enabled = true;
                    }
                    
                    this.buttonAddService.Enabled = true;
                    this.buttonBills.Enabled = true;
                    if (booking.getArrHasCheckedOut()[idxBook] == false)
                    {
                        this.buttonNewBook.Enabled = false;
                    }
                }
            }
        }

        private void addRowsToTable()
        {
            string[] row = { "1", "Spa", "1", "120000" };
            this.dataGridView1.Rows.Add(row);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            availabilityUI.Show();
        }

        private void checkBoxCheckin_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCheckin.Checked == true)
            {
                this.roomMapButton.BackColor = Color.FromArgb(97, 6, 26);
                booking.updateHasCheckedin(bookid, true);
                initialize(roomMapButton);
            }
            else
            {
                this.roomMapButton.BackColor = Color.FromArgb(153, 144, 11);
                booking.updateHasCheckedin(bookid, false);
                initialize(roomMapButton);
            }
        }
    }
}
