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
    public partial class ChoosenRoomUI : Form
    {
        private Panel mainmenupanel;
        private RoomAvailabilityUI availabilityUI;
        private Booking booking = new Booking();
        private Order orders = new Order();
        private Menu menus = new Menu();
        private Room room = new Room();
        private Customer customer = new Customer();
        private Receptionist receptionist = new Receptionist();
        private Button roomMapButton;
        private int bookid;
        private DateTime dtPickedOnAvailability;
        public ChoosenRoomUI(Button roomMapButton, Panel mainmenupanel, RoomAvailabilityUI availabilityUI, int bookid, DateTime dt)
        {
            InitializeComponent();
            this.bookid = bookid;
            this.dtPickedOnAvailability = dt;
            initialize(roomMapButton);
            this.mainmenupanel = mainmenupanel;
            this.availabilityUI = availabilityUI;
            this.roomMapButton = roomMapButton;
            
        }
        private void initialize(Button roomMapButton)
        {
            this.statusRoom.Enabled = false;
            this.dataGridView1.Columns[4].Visible = true;
            if (roomMapButton.BackColor == Color.FromArgb(21, 87, 36)) // ijo
            {
                this.dataGridView1.Rows.Clear();
                this.labelTotalBill.Text = "Total Bills: Rp. XXX";
                this.statusRoom.BackColor = Color.FromArgb(21, 87, 36);
                this.buttonCheckedIn.Enabled = false;
                this.buttonCheckedOut.Enabled = false;
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
                
                this.dataGridView1.Rows.Clear();
                int idxBook = booking.findIdx(bookid);
                this.labelTotalBill.Text = "Total Bills: Rp. XXX";
                this.statusRoom.BackColor = Color.FromArgb(153, 144, 11);
                this.buttonCheckedIn.Enabled = true;
                this.buttonCheckedOut.Enabled = false;
                this.buttonCheckedIn.Text = "Checkin";
                this.buttonNewBook.Text = "Delete Book";
                this.buttonNewBook.BackColor = Color.FromArgb(97, 6, 26);
                this.buttonNewBook.Enabled = true;
                this.buttonAddService.Enabled = false;
                this.buttonBills.Enabled = false;
                this.labelBook.Text = "Book #" + this.bookid.ToString();
                this.labelCheckin.Text = "Checkin Date: " + booking.getArrCheckinTime()[idxBook].ToShortDateString();
                this.labelCheckout.Text = "Checkout Date: " + booking.getArrCheckoutTime()[idxBook].ToShortDateString();
                this.labelCustomer.Text = "Customer: " + customer.getNameFromId(booking.getArrCustomerID()[idxBook].ToString());
                this.labelReceptionist.Text = "Receptionist: " + receptionist.getNameFromId(booking.getArrEmployeeID()[idxBook].ToString()); 
                this.labelTotalBill.Text = "Total Bill: Rp. ###"; // to be implement
                this.labelRoom.Text = "Room #" + roomMapButton.Text;

                
                if (roomMapButton.BackColor == Color.FromArgb(97, 6, 26))
                {
                    addRowsToTable();
                    this.labelTotalBill.Text = "Total Bills: Rp. " + totalBills().ToString();
                    this.buttonNewBook.Enabled = false;
                    if (booking.getArrHasCheckedIn()[idxBook] == true)
                    {
                        this.buttonCheckedOut.Enabled = true;
                        this.buttonCheckedIn.Text = "Un-Checkin";
                        this.statusRoom.BackColor = Color.FromArgb(97, 6, 26);
                        if (orders.isHasOrder(bookid) == true && buttonCheckedIn.Text == "Un-Checkin")
                        {
                            this.buttonCheckedIn.Enabled = false;
                        }
                    }
                    
                    this.buttonAddService.Enabled = true;
                    this.buttonBills.Enabled = true;
                    if (booking.getArrHasCheckedOut()[idxBook] == false)
                    {
                        this.buttonCheckedOut.Text = "Checkout";
                        this.buttonAddService.Enabled = true;
                        this.statusRoom.BackColor = Color.FromArgb(97, 6, 26);
                    }
                    else
                    {
                        this.buttonCheckedOut.Text = "Un-Checkout";
                        this.buttonAddService.Enabled = false;
                        this.statusRoom.BackColor = Color.White;
                        this.buttonCheckedIn.Enabled = false;
                        this.dataGridView1.Columns[4].Visible = false;
                    }
                    
                }
            }
        }

        private int totalBills()
        {
            int total = 0;
            for (int i = 0; i < orders.getArrIdx().Count; i++)
            {
                if (orders.getArrBookingId()[i] == bookid)
                {
                    total += (menus.getPriceFromItemId(orders.getArrItemId()[i]) * orders.getArrAmount()[i]);
                }
            }
            return (total + room.getPriceByRoomId(booking.getRoomIdByBookId(bookid)));
        }
        private void addRowsToTable()
        {
            int itemid;
            int amount;
            int idx;
            string itemname;
            int itemprice;
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < orders.getArrBookingId().Count; i++)
            {
                if (orders.getArrBookingId()[i] == bookid)
                {
                    idx = orders.getArrIdx()[i];
                    itemid = orders.getArrItemId()[i];
                    amount = orders.getArrAmount()[i];
                    itemname = menus.getNameFromItemId(itemid);
                    itemprice = menus.getPriceFromItemId(itemid);
                    this.dataGridView1.Rows.Add(idx, itemname, amount.ToString(), (itemprice * amount).ToString());
                    // lanjut disini *REMINDER REMINDER REMINDER*
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            availabilityUI.Show();
        }


        private void buttonCheckedIn_Click(object sender, EventArgs e)
        {
            if (this.buttonCheckedIn.Text == "Checkin")
            {
                this.buttonCheckedIn.Text = "Un-Checkin";
                this.statusRoom.BackColor = Color.FromArgb(97, 6, 26);
                this.roomMapButton.BackColor = Color.FromArgb(97, 6, 26);
                booking.updateHasCheckedin(bookid, true);
                initialize(roomMapButton);
            }
            else
            {
                this.buttonCheckedIn.Text = "Checkin";
                this.statusRoom.BackColor = Color.FromArgb(153, 144, 11);
                this.roomMapButton.BackColor = Color.FromArgb(153, 144, 11);
                booking.updateHasCheckedin(bookid, false);
                initialize(roomMapButton);
            }
        }

        private void buttonCheckedOut_Click(object sender, EventArgs e)
        {
            if (this.buttonCheckedOut.Text == "Checkout")
            {
                this.buttonCheckedOut.Text = "Un-Checkout";
                this.statusRoom.BackColor = Color.White;
                booking.updateHasCheckedout(bookid, true);
                initialize(roomMapButton);
            }
            else
            {
                this.buttonCheckedOut.Text = "Checkout";
                this.statusRoom.BackColor = Color.FromArgb(97, 6, 26);
                booking.updateHasCheckedout(bookid, false);
                initialize(roomMapButton);
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            Form addOrder = new AddOrder(bookid);
            addOrder.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            orders.initialize();
            initialize(roomMapButton);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Delete this order?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int idxdelete = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    orders.deleteOrder(idxdelete);
                    initialize(roomMapButton);
                    MessageBox.Show("Order Deleted, My Prince!");
                }
                
            }
        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            if (this.buttonNewBook.Text == "New Book")
            {
                Form newBook = new NewBooking(this, roomMapButton, mainmenupanel, availabilityUI, dtPickedOnAvailability);
                newBook.ShowDialog();
            }
            else
            {
                booking.deleteBooking(bookid);
                MessageBox.Show("Booking Deleted!");
                roomMapButton.BackColor = Color.FromArgb(21, 87, 36);
                initialize(roomMapButton);

            }
        }
    }
}
