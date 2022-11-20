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
    public partial class NewBooking : Form
    {
        private Form choosenRoomUI;
        private RoomAvailabilityUI availabilityUI;
        private Panel mainMenuPanel;
        private Button roomMapButton;
        private Receptionist receptionist = new Receptionist();
        private DateTime dtPicked;

        Booking booking = new Booking();
        
        private Customer customer = new Customer();
        public NewBooking(Form choosenRoomUI, Button roomMapButton, Panel mainMenuPanel, RoomAvailabilityUI AvailabilityUI, DateTime dtPicked)
        {
            InitializeComponent();
            this.choosenRoomUI = choosenRoomUI;
            this.availabilityUI = AvailabilityUI;
            this.roomMapButton = roomMapButton;
            this.mainMenuPanel = mainMenuPanel;
            this.dtPicked = dtPicked;
            initialize();
        }

        private void initialize()
        {
            this.labelRoomNumber.Text = "Room #"+roomMapButton.Text;
            this.textBoxIdCust.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void reInstanceChoosenRoomUI()
        {

        }

        private bool isDateCheckoutValid(DateNightBook DNB, DateTime checkin, DateTime dt, int roomid)
        {
            int count = 0;
            DateTime test = checkin;
            while (test.Day != dt.Day || test.Month != dt.Month || test.Year != dt.Year)
            {
                for (int i = 0; i < DNB.getBookingID().Count; i++)
                {
                    if ((test.Day == DNB.getDateNight()[i].Day && test.Month == DNB.getDateNight()[i].Month && test.Year == DNB.getDateNight()[i].Year) && (roomid == DNB.getRoomID()[i]))
                    {
                        count++;
                    }
                }
                test = test.AddDays(1);
            }
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }

        private void callChoosenRoomUI(Form choosenRoomUI, object sender)
        {
            this.choosenRoomUI.Close();
            this.choosenRoomUI = choosenRoomUI;
            choosenRoomUI.TopLevel = false;
            choosenRoomUI.FormBorderStyle = FormBorderStyle.None;
            choosenRoomUI.Dock = DockStyle.Fill;
            this.availabilityUI.Hide();
            this.mainMenuPanel.Controls.Add(choosenRoomUI);
            this.mainMenuPanel.Tag = choosenRoomUI;
            choosenRoomUI.BringToFront();
            choosenRoomUI.Show();
        }
        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            DateNightBook dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            if (customer.isIDExist(this.textBoxIdCust.Text) == false)
            {
                MessageBox.Show("Customer ID isn't already exist, please register customer on Customer menu.");
            }
            else
            {
                if (dateTimePicker1.Value.Date <= dtPicked.Date)
                {
                    MessageBox.Show("Minimum checkout is D+1 from checkin date");
                }
                else if (isDateCheckoutValid(dnb, dtPicked, dateTimePicker1.Value.Date, Int32.Parse(roomMapButton.Text)) == false)
                {
                    MessageBox.Show("Can't book till that day, Sir.");
                }
                
                else
                {
                    roomMapButton.BackColor = Color.FromArgb(153, 144, 11);
                    booking.addBooking(textBoxIdCust.Text, receptionist.getArrEmployeeId()[availabilityUI.idxUsernameUsed], roomMapButton.Text, DateTime.Now, dtPicked, dateTimePicker1.Value.Date);
                    MessageBox.Show("Book Added");
                    callChoosenRoomUI(new ChoosenRoomUI(roomMapButton, mainMenuPanel, availabilityUI, booking.getArrBookingID()[booking.getArrBookingID().Count-1], dtPicked), sender);
                    this.Close();
                }
            }

        }
    }
}
