using Acelist.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelist.boundary
{
    public partial class LevelFloorMapUI : Form
    {
        private Button[] arrButton = new Button[30];
        Booking booking;
        DateNightBook DNBook;

        private Panel mainmenupanel;
        private Form activeChoosenRoomUI;
        private Form availabilityUI;
        private DateTime dt;

        public LevelFloorMapUI(string floor, DateTime dt, Booking booking, DateNightBook DNBook, Panel mainmenupanel, Form availabilityUI)
        {
            InitializeComponent();
            setArrButton();
            setButtonText(this.arrButton, floor);
            this.booking = booking;
            this.DNBook = DNBook;
            this.dt = dt;

            for (int i = 0; i < arrButton.Length; i++)
            {
                availabilityPrint(booking, DNBook, dt, arrButton[i]);
            }
            this.availabilityUI = availabilityUI;
            this.mainmenupanel = mainmenupanel;
        }

        private void availabilityPrint(Booking booking, DateNightBook DNBook, DateTime dc, Button btn)
        {
            int roomid = Int32.Parse(btn.Text);
            int i = 0;
            bool found = false;
            int bookid_ = -1;
            while (found == false && i < DNBook.getBookingID().Count)
            {
                if (roomid == DNBook.getRoomID()[i] && dc.Day == DNBook.getDateNight()[i].Day && dc.Month == DNBook.getDateNight()[i].Month && dc.Year == DNBook.getDateNight()[i].Year)
                {
                    found = true;
                    bookid_ = DNBook.getBookingID()[i];
                }
                i++;          
            }
            if (found == true)
            {
                bool stats = statusRoom(booking, bookid_);
                if (stats == true) // udah checkin
                {
                    btn.BackColor = Color.FromArgb(97, 6, 26);
                }
                else // belum checkin
                {
                    btn.BackColor = Color.FromArgb(153, 144, 11);
                }
            }
        }

        private bool statusRoom(Booking booking, int bookid)
        {
            bool found = false;
            int i = 0;
            while (found == false && i < booking.getArrBookingID().Count)
            {
                if (booking.getArrBookingID()[i] == bookid)
                {
                    found=true;
                }
                else { i++; }
            }
            return booking.getArrHasCheckedIn()[i];
        }
    
        private void setButtonText(Button[] arrButton, string floor)
        {
            for (int i = 0; i < arrButton.Length; i++)
            {
                if (i < 9)
                {
                    arrButton[i].Text = floor + "0" + (i+1).ToString();
                }
                else
                {
                    arrButton[i].Text = floor + (i+1).ToString();
                }
                
            }
        }
        private void setArrButton()
        {
            this.arrButton[0] = button1;
            this.arrButton[1] = button2;
            this.arrButton[2] = button3;
            this.arrButton[3] = button4;
            this.arrButton[4] = button5;
            this.arrButton[5] = button6;
            this.arrButton[6] = button7;
            this.arrButton[7] = button8;
            this.arrButton[8] = button9;
            this.arrButton[9] = button10;
            this.arrButton[10] = button11;
            this.arrButton[11] = button12;
            this.arrButton[12] = button13;
            this.arrButton[13] = button14;
            this.arrButton[14] = button15;
            this.arrButton[15] = button16;
            this.arrButton[16] = button17;
            this.arrButton[17] = button18;
            this.arrButton[18] = button19;
            this.arrButton[19] = button20;
            this.arrButton[20] = button21;
            this.arrButton[21] = button22;
            this.arrButton[22] = button23;
            this.arrButton[23] = button24;
            this.arrButton[24] = button25;
            this.arrButton[25] = button26;
            this.arrButton[26] = button27;
            this.arrButton[27] = button28;
            this.arrButton[28] = button29;
            this.arrButton[29] = button30;
        }

        private void callChoosenRoomUI(Form choosenRoomUI, object sender)
        {
            if (activeChoosenRoomUI != null)
            {
                activeChoosenRoomUI.Close();
            }
            activeChoosenRoomUI = choosenRoomUI;
            choosenRoomUI.TopLevel = false;
            choosenRoomUI.FormBorderStyle = FormBorderStyle.None;
            choosenRoomUI.Dock = DockStyle.Fill;
            this.availabilityUI.Hide();
            this.mainmenupanel.Controls.Add(choosenRoomUI);
            this.mainmenupanel.Tag = choosenRoomUI;
            choosenRoomUI.BringToFront();
            choosenRoomUI.Show();
        }

        private int findBookId(Booking booking, DateNightBook DNB,Button btn)
        {
            int i = 0;
            bool found = false;
            DateTime datecheck;
            int bookid = 0;
            while (found == false && i < DNB.getDateNight().Count)
            {
                datecheck = DNB.getDateNight()[i];
                if (datecheck.Day == dt.Day && datecheck.Month == dt.Month && datecheck.Year == dt.Year)
                {
                    bookid = DNB.getBookingID()[i];
                }
                int j = 0;
                while (found == false && j < booking.getArrBookingID().Count)
                {
                    if (bookid == booking.getArrBookingID()[j] && booking.getArrRoomID()[j].ToString() == btn.Text)
                    {
                        found = true;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (found == false)
                {
                    i++;
                }
            }
            if (found == true)
            {
                return bookid;
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(),booking.getArrRoomID(), booking.getArrCheckinTime(),booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button1);
            callChoosenRoomUI(new ChoosenRoomUI(this.button1, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button3);
            callChoosenRoomUI(new ChoosenRoomUI(this.button3, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button2);
            callChoosenRoomUI(new ChoosenRoomUI(this.button2, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button4);
            callChoosenRoomUI(new ChoosenRoomUI(this.button4, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button5);
            callChoosenRoomUI(new ChoosenRoomUI(this.button5, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button6);
            callChoosenRoomUI(new ChoosenRoomUI(this.button6, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button7);
            callChoosenRoomUI(new ChoosenRoomUI(this.button7, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button8);
            callChoosenRoomUI(new ChoosenRoomUI(this.button8, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button9);
            callChoosenRoomUI(new ChoosenRoomUI(this.button9, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button10);
            callChoosenRoomUI(new ChoosenRoomUI(this.button10, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button11);
            callChoosenRoomUI(new ChoosenRoomUI(this.button11, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button12);
            callChoosenRoomUI(new ChoosenRoomUI(this.button12, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button13);
            callChoosenRoomUI(new ChoosenRoomUI(this.button13, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button14);
            callChoosenRoomUI(new ChoosenRoomUI(this.button14, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button15);
            callChoosenRoomUI(new ChoosenRoomUI(this.button15, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button16);
            callChoosenRoomUI(new ChoosenRoomUI(this.button16, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button22);
            callChoosenRoomUI(new ChoosenRoomUI(this.button22, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button17);
            callChoosenRoomUI(new ChoosenRoomUI(this.button17, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button18);
            callChoosenRoomUI(new ChoosenRoomUI(this.button18, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button19);
            callChoosenRoomUI(new ChoosenRoomUI(this.button19, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button20);
            callChoosenRoomUI(new ChoosenRoomUI(this.button20, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button21);
            callChoosenRoomUI(new ChoosenRoomUI(this.button21, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button23);
            callChoosenRoomUI(new ChoosenRoomUI(this.button23, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button24);
            callChoosenRoomUI(new ChoosenRoomUI(this.button24, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button25);
            callChoosenRoomUI(new ChoosenRoomUI(this.button25, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button26);
            callChoosenRoomUI(new ChoosenRoomUI(this.button26, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button27);
            callChoosenRoomUI(new ChoosenRoomUI(this.button27, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button28);
            callChoosenRoomUI(new ChoosenRoomUI(this.button28, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button29);
            callChoosenRoomUI(new ChoosenRoomUI(this.button29, mainmenupanel, availabilityUI, bid, dt), sender);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            booking.Initialize();
            DNBook.Initialize(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            int bid = findBookId(booking, DNBook, this.button30);
            callChoosenRoomUI(new ChoosenRoomUI(this.button30, mainmenupanel, availabilityUI, bid, dt), sender);
        }
    }
}
