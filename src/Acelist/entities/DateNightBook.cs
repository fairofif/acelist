using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.entities
{
    public class DateNightBook
    {
        private List<int> booking_id = new List<int>();
        private List<int> room_id = new List<int>();
        private List<DateTime> datenight = new List<DateTime>();

        public DateNightBook(List<int> bookId, List<int> roomId, List<DateTime> checkin, List<DateTime> checkout)
        {
            Initialize(bookId, roomId, checkin, checkout);
        }

        public void Initialize(List<int> bookId, List<int> roomId, List<DateTime> checkin, List<DateTime> checkout)
        {
            this.booking_id = new List<int>();
            this.room_id = new List<int>();
            this.datenight = new List<DateTime>();
            for (int i = 0; i < bookId.Count; i++)
            {
                for (DateTime day = checkin[i]; day < checkout[i]; day = day.AddDays(1))
                {
                    this.booking_id.Add(bookId[i]);
                    this.room_id.Add(roomId[i]);
                    this.datenight.Add(day);
                }
            }
        }

        public List<int> getBookingID()
        {
            return this.booking_id;
        }

        public List<DateTime> getDateNight()
        {
            return this.datenight;
        }

        public List<int> getRoomID()
        {
            return this.room_id;
        }

        public int countNightById(int id)
        {
            int count = 0;
            for (int i = 0; i<booking_id.Count; i++)
            {
                if (booking_id[i] == id)
                {
                    count += 1;
                }
            }
            return count;
        }

    }
}
