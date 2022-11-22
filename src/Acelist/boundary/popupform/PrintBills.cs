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
    public partial class PrintBills : Form
    {
        private int bookid;
        private Booking booking = new Booking();
        DateNightBook dnb;
        private Order orders = new Order();
        private Menu menus = new Menu();
        private Room room = new Room();

        private List<int> itemlist = new List<int>();
        private List<int> amountlist = new List<int>();
        private List<int> pricelist = new List<int>();

        public PrintBills(int bookid)
        {
            InitializeComponent();
            this.bookid = bookid;
            dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            setArrList();
            printToTable();
            this.label1.Text = "Book #" + bookid;
        }

        private void printToTable()
        {
            string typeRoom = room.getTypeByRoomId(booking.getRoomIdByBookId(bookid));
            string nightspent = "x" + dnb.countNightById(bookid).ToString()+" nights";
            int priceroom = dnb.countNightById(bookid) * room.getPriceByRoomId(booking.getRoomIdByBookId(bookid));
            dataGridView1.Rows.Add(typeRoom, nightspent, priceroom);

            string itemname;
            string amountitem;
            for (int i = 0; i < itemlist.Count; i++)
            {
                itemname = menus.getNameFromItemId(itemlist[i]);
                amountitem = "x"+ amountlist[i].ToString();
                dataGridView1.Rows.Add(itemname, amountitem, pricelist[i]);
            }
            dataGridView1.Rows.Add("", "Total :", sumPriceList(pricelist)+priceroom);
        }

        private int sumPriceList(List<int> pricelist)
        {
            int sum = 0;
            for (int i = 0; i < pricelist.Count; i++)
            {
                sum += pricelist[i];
            }
            return sum;
        }


        private int idxID(List<int> itemlist, int itemid)
        {
            int i = 0;
            bool found = false;
            while (found == false && i < itemlist.Count)
            {
                if (itemid == itemlist[i])
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }

        public void setArrList()
        {
            int idx;
            for (int i = 0; i < orders.getArrBookingId().Count; i++)
            {
                if (orders.getArrBookingId()[i] == bookid)
                {
                    if (itemlist.Contains(orders.getArrItemId()[i]))
                    {
                        idx = idxID(itemlist, orders.getArrItemId()[i]);
                        amountlist[idx] = amountlist[idx] + orders.getArrAmount()[i]; 
                    }
                    else
                    {
                        itemlist.Add(orders.getArrItemId()[i]);
                        amountlist.Add(orders.getArrAmount()[i]);
                    }
                }
            }
            int value;
            for (int i = 0; i<itemlist.Count; i++)
            {
                value = menus.getPriceFromItemId(itemlist[i]) * amountlist[i];
                pricelist.Add(value);
            }
        }
    }
}
