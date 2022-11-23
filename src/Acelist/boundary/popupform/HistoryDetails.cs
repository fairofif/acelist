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
    public partial class HistoryDetails : Form
    {
        private Booking booking = new Booking();
        private Order orders = new Order();
        private Menu menus = new Menu();
        private Customer customer = new Customer();
        private Receptionist receptionist = new Receptionist();
        private Room room = new Room();
        private DateNightBook dnb;


        public Panel panelmainmenu;
        public BookHistoryUI bookhistoryui;
        public int bookid;

        public HistoryDetails(Panel panelmainmenu, BookHistoryUI bookhistoryui, int bookid)
        {
            InitializeComponent();
            this.panelmainmenu = panelmainmenu;
            this.bookhistoryui = bookhistoryui;
            this.bookid = bookid;
            dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            initialize(bookid);
        }
        public void initialize(int bookid)
        {
            int idxbookid = booking.findIdx(bookid);
            this.labelBookID.Text = "Book #" + bookid.ToString();
            this.labelRoomNumber.Text = "Room Number: " + booking.getArrRoomID()[idxbookid].ToString();
            this.labelReceptionist.Text = "Receptionist: " + receptionist.getNameFromId(booking.getArrEmployeeID()[idxbookid]);
            this.labelCustomer.Text = "Customer: " + customer.getNameFromId(booking.getArrCustomerID()[idxbookid]);
            this.labelCheckin.Text = "Checkin Date: " + booking.getArrCheckinTime()[idxbookid].ToShortDateString();
            this.labelCheckout.Text = "Checkout Date: " + booking.getArrCheckoutTime()[idxbookid].ToShortDateString();
            this.labelCreated.Text = "Created Date: " + booking.getArrBookingTime()[idxbookid].ToShortDateString();
            printOrdersToTable();
        }

        private void printOrdersToTable()
        {
            int idxorder;
            string services;
            int amount;
            int price;
            int sum = 0;
            for (int i = 0; i < orders.getArrIdx().Count; i++)
            {
                if (this.bookid == orders.getArrBookingId()[i])
                {
                    idxorder = orders.getArrIdx()[i];
                    services = menus.getNameFromItemId(orders.getArrItemId()[i]);
                    amount = orders.getArrAmount()[i];
                    price = menus.getPriceFromItemId(orders.getArrItemId()[i]) * amount;
                    sum = sum + price;
                    dataGridView1.Rows.Add(idxorder, services, amount, price);
                }
            }
            int totalnight = dnb.countNightById(bookid);
            sum = sum + (room.getPriceByRoomId(booking.getRoomIdByBookId(this.bookid)) * totalnight);
            this.labelTotal.Text = "Total: Rp." + sum.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            bookhistoryui.Show();
            this.Close();
        }
    }
}
