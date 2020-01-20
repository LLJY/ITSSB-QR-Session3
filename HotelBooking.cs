using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class HotelBooking : Form
    {
        List<BookingTable> dgvlist = new List<BookingTable>();
        string hotelname;
        int hotelID;
        User LoggedIn;
        int Totalpeople;
        public HotelBooking(User user, int hotelid, string hotelname)
        {
            LoggedIn = user;
            hotelID = hotelid;
            this.hotelname = hotelname;
            Initialize();
        }
        public async void Initialize()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
            using (var db = new Session3Entities())
            {
                try
                {
                    var h = (from a in db.Hotel_Booking
                             where a.userIdFK == LoggedIn.userId
                             select a).First();
                    MessageBox.Show("Error: Already booked");
                    this.Close();
                }
                catch
                {
                    //carry on.
                }
                try
                {
                    var arrival = (from a in db.Arrivals
                                   where a.userIdFK == LoggedIn.userId
                                   select new { a.numberCompetitors, a.numberDelegate }).First();
                    hotel_label.Text = hotelname;
                    people_number.Text = arrival.numberDelegate.ToString();
                    competitors_number.Text = arrival.numberCompetitors.ToString();
                    dgvlist = await getInfo(arrival.numberCompetitors, arrival.numberDelegate);
                    Totalpeople = arrival.numberCompetitors + arrival.numberDelegate;
                    dataGridView1.DataSource = dgvlist;
                    updateValuelabel();
                }
                catch
                {
                    MessageBox.Show("Error, no arrival found");
                }
                
            }

        }
        public void updateValuelabel()
        {
            valuelabel.Text = (int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()) + int.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString())).ToString();
        }
        public async Task<List<BookingTable>> getInfo(int comp, int delegates)
        {
            var returnlist = new List<BookingTable>();
            using (var db = new Session3Entities())
            {
                int singlerooms = 0;
                int doublerooms = 0;
                int i = comp;
                while ((i-2) >= 1)
                {
                    i = i - 2;
                    doublerooms++;
                }
                singlerooms = i;
                singlerooms += delegates;
                var hotel = (from d in db.Hotels
                             where d.hotelId == hotelID
                             select d).First();

                var singlebt = new BookingTable()
                {
                    RoomType = "Single",
                    AvailableNoOfRooms = hotel.numSingleRoomsTotal - hotel.numSingleRoomsBooked,
                    RoomRatePerNight = hotel.singleRate,
                    RoomsRequired = singlerooms,
                    SubTotal = hotel.singleRate * singlerooms
                };
                var doublebt = new BookingTable()
                {
                    RoomType = "Double",
                    AvailableNoOfRooms = hotel.numDoubleRoomsTotal - hotel.numDoubleRoomsBooked,
                    RoomRatePerNight = hotel.doubleRate,
                    RoomsRequired = doublerooms,
                    SubTotal = hotel.doubleRate * doublerooms
                };
                returnlist.Add(singlebt);
                returnlist.Add(doublebt);
            }
            return returnlist;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class BookingTable
        {
            public string RoomType { get; set; }
            public int RoomRatePerNight { get; set; }
            public int AvailableNoOfRooms { get; set; }
            public int RoomsRequired { get; set; }
            public int SubTotal { get; set; }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            refreshDGV();
        }
        private void refreshDGV()
        {
            var singlebt = new BookingTable()
            {
                RoomType = "Single",
                AvailableNoOfRooms = dgvlist[0].AvailableNoOfRooms,
                RoomRatePerNight = dgvlist[0].RoomRatePerNight,
                RoomsRequired = int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()),
                SubTotal = int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString()) * dgvlist[0].RoomRatePerNight
            };
            var doublebt = new BookingTable()
            {
                RoomType = "Double",
                AvailableNoOfRooms = dgvlist[1].AvailableNoOfRooms,
                RoomRatePerNight = dgvlist[0].RoomRatePerNight,
                RoomsRequired = int.Parse(dataGridView1.Rows[1].Cells[3].Value.ToString()),
                SubTotal = int.Parse(dataGridView1.Rows[1].Cells[3].Value.ToString()) * dgvlist[1].RoomRatePerNight
            };
            dgvlist = new List<BookingTable>();
            dgvlist.Add(singlebt);
            dgvlist.Add(doublebt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dgvlist;
            updateValuelabel();
        }

        private async void done_button_Click(object sender, EventArgs e)
        {
            using(var db = new Session3Entities())
            {
                if(!(dgvlist[0].RoomsRequired > dgvlist[0].AvailableNoOfRooms))
                {
                    if (!(dgvlist[1].RoomsRequired > dgvlist[1].AvailableNoOfRooms))
                    {
                        if (((dgvlist[1].RoomsRequired * 2) + dgvlist[0].RoomsRequired) >= Totalpeople)
                        {
                            try
                            {
                                Hotel_Booking hb = new Hotel_Booking()
                                {
                                    bookingId = (from a in db.Hotel_Booking
                                                 orderby a.bookingId descending
                                                 select a.bookingId).First() + 1,
                                    hotelIdFK = hotelID,
                                    userIdFK = LoggedIn.userId,
                                    numDoubleRoomsRequired = dgvlist[1].RoomsRequired,
                                    numSingleRoomsRequired = dgvlist[0].RoomsRequired
                                };
                                db.Hotel_Booking.Add(hb);
                                await db.SaveChangesAsync();
                            }
                            catch
                            {
                                Hotel_Booking hb = new Hotel_Booking()
                                {
                                    bookingId = 1,
                                    hotelIdFK = hotelID,
                                    userIdFK = LoggedIn.userId,
                                    numDoubleRoomsRequired = dgvlist[1].RoomsRequired,
                                    numSingleRoomsRequired = dgvlist[0].RoomsRequired
                                };
                                db.Hotel_Booking.Add(hb);
                                await db.SaveChangesAsync();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Enough Rooms for arrivals");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, more rooms requested than available");
                    }
                }
                else
                {
                    MessageBox.Show("Error, more rooms requested than available");
                }
                
            }
        }
    }
}
