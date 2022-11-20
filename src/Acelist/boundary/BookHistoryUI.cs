using Acelist.boundary.popupform;
using Acelist.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelist.boundary
{
    public partial class BookHistoryUI : Form
    {
        private Booking booking = new Booking();
        private Panel panelmainmenu;
        public BookHistoryUI(Panel panelmainmenu)
        {
            InitializeComponent();
            printHistoryToTable();
            this.panelmainmenu = panelmainmenu;
        }

        private void printHistoryToTable()
        {
            int bookID;
            int roomID;
            string custID;
            string checkinDate;
            string checkoutDate;
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < booking.getArrBookingID().Count; i++)
            {
                if (booking.getArrHasCheckedOut()[i] == true)
                {
                    bookID = booking.getArrBookingID()[i];
                    roomID = booking.getArrRoomID()[i];
                    custID = booking.getArrCustomerID()[i];
                    checkinDate = booking.getArrCheckinTime()[i].ToShortDateString();
                    checkoutDate = booking.getArrCheckoutTime()[i].ToShortDateString();
                    this.dataGridView1.Rows.Add(bookID,roomID,custID, checkinDate,checkoutDate);

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (this.textBoxSearch.Text == "")
            {
                printHistoryToTable();
            }
            else
            {
                int bookID = Int32.Parse(textBoxSearch.Text);
                this.dataGridView1.Rows.Clear();
                int i = 0;
                bool found = false;
                while (found == false && i < booking.getArrBookingID().Count)
                {
                    if (bookID == booking.getArrBookingID()[i] && booking.getArrHasCheckedOut()[i] == true)
                    {
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (found)
                {
                    dataGridView1.Rows.Add(bookID, booking.getArrRoomID()[i], booking.getArrCustomerID()[i], booking.getArrCheckinTime()[i].ToShortDateString(), booking.getArrCheckoutTime()[i].ToShortDateString());
                }
                
            }
        }

        private void callHistoryDetails(int iddetail)
        {
            HistoryDetails history = new HistoryDetails(panelmainmenu, this, iddetail);
            history.TopLevel = false;
            history.FormBorderStyle = FormBorderStyle.None;
            history.Dock = DockStyle.Fill;
            this.Hide();
            this.panelmainmenu.Controls.Add(history);
            this.panelmainmenu.Tag = history;
            history.BringToFront();
            history.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                int iddetail = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                callHistoryDetails(iddetail);
            }
        }
    }
}
