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
    public partial class HotelUpdate : Form
    {
        User LoggedIn;
        List<UpdateTable> dgvlist;
        public HotelUpdate(User user)
        {
            LoggedIn = user;
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
            using (var db = new Session3Entities())
            {
                try
                {
                    var h = (from a in db.Hotel_Booking
                             where a.userIdFK == LoggedIn.userId
                             select a).First();
                }
                catch
                {
                    MessageBox.Show("Error: No Booking Found");
                    this.Close();
                }
                try
                {
                    var arrival = (from a in db.Arrivals
                                   where a.userIdFK == LoggedIn.userId
                                   select a).First();
                    head_updown.Value = arrival.numberHead;
                    delegates_updown.Value = arrival.numberDelegate;
                    competitors_updown.Value = arrival.numberCompetitors;
                    dgvlist = GetInfo(arrival.numberCompetitors, arrival.numberDelegate);
                    dataGridView1.DataSource = dgvlist;
                    updateValuelabel();
                }
                catch
                {
                    MessageBox.Show("Error, no arrival found");
                }

            }
        }
        public List<UpdateTable> GetInfo(int comp, int delegates)
        {
            var returnlist = new List<UpdateTable>();
            using (var db = new Session3Entities())
            {
                int singlerooms = 0;
                int doublerooms = 0;
                int i = comp;
                while ((i - 2) >= 1)
                {
                    i = i - 2;
                    doublerooms++;
                }
                singlerooms = i;
                singlerooms += delegates;
                try
                {
                    var booking = (from d in db.Hotel_Booking
                                   where d.userIdFK == LoggedIn.userId
                                   select d).First();
                    var hotelID = booking.hotelIdFK;
                    var hotel = (from d in db.Hotels
                                 where d.hotelId == hotelID
                                 select d).First();

                    var singlebt = new UpdateTable()
                    {
                        RoomType = "Single",
                        AvailableNoOfRooms = hotel.numSingleRoomsTotal - hotel.numSingleRoomsBooked,
                        RoomRatePerNight = hotel.singleRate,
                        RoomsBooked = booking.numSingleRoomsRequired,
                        NewNoOfRoomsRequired = singlerooms,
                        SubTotal = hotel.singleRate * singlerooms
                    };
                    var doublebt = new UpdateTable()
                    {
                        RoomType = "Double",
                        AvailableNoOfRooms = hotel.numDoubleRoomsTotal - hotel.numDoubleRoomsBooked,
                        RoomsBooked = booking.numDoubleRoomsRequired,
                        RoomRatePerNight = hotel.doubleRate,
                        NewNoOfRoomsRequired = doublerooms,
                        SubTotal = hotel.doubleRate * doublerooms
                    };
                    returnlist.Add(singlebt);
                    returnlist.Add(doublebt);
                }
                catch
                {
                    MessageBox.Show("No Valid Booking Found");
                    }
                return returnlist;
            }
        }
        private void RefreshDGV()
        {
            var singlebt = new UpdateTable()
            {
                RoomType = "Single",
                AvailableNoOfRooms = dgvlist[0].AvailableNoOfRooms,
                RoomRatePerNight = dgvlist[0].RoomRatePerNight,
                RoomsBooked = dgvlist[0].RoomsBooked,
                NewNoOfRoomsRequired = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()),
                SubTotal = int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()) * dgvlist[0].RoomRatePerNight
            };
            var doublebt = new UpdateTable()
            {
                RoomType = "Double",
                AvailableNoOfRooms = dgvlist[1].AvailableNoOfRooms,
                RoomRatePerNight = dgvlist[1].RoomRatePerNight,
                RoomsBooked = dgvlist[1].RoomsBooked,
                NewNoOfRoomsRequired = int.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString()),
                SubTotal = int.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString()) * dgvlist[1].RoomRatePerNight
            };
            dgvlist = new List<UpdateTable>();
            dgvlist.Add(singlebt);
            dgvlist.Add(doublebt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dgvlist;
            updateValuelabel();
        }
        public void updateValuelabel()
        {
            valuelabel.Text = (int.Parse(dataGridView1.Rows[0].Cells[5].Value.ToString()) + int.Parse(dataGridView1.Rows[1].Cells[5].Value.ToString())).ToString();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session3Entities())
            {
                if (!(dgvlist[0].NewNoOfRoomsRequired > dgvlist[0].AvailableNoOfRooms))
                {
                    if (!(dgvlist[1].NewNoOfRoomsRequired > dgvlist[1].AvailableNoOfRooms))
                    {
                        if (((dgvlist[1].NewNoOfRoomsRequired * 2) + dgvlist[0].NewNoOfRoomsRequired) >= delegates_updown.Value + competitors_updown.Value)
                        {
                            var arrivals = (from a in db.Arrivals
                                            where a.userIdFK == LoggedIn.userId
                                            select a).First();
                            var booking = (from b in db.Hotel_Booking
                                           where b.userIdFK == LoggedIn.userId
                                           select b).First();
                            arrivals.numberCars = (int)delegates_updown.Value;
                            int numSmallBus = 0;
                            int numBigBus = 0;
                            decimal numPeople = delegates_updown.Value + competitors_updown.Value;
                            if (numPeople > 38)
                            {
                                decimal bigbusraw = numPeople / 42;
                                numBigBus = (int)Math.Floor(bigbusraw);
                                numPeople -= (numBigBus * 42);
                                decimal smallbusraw = numPeople / 19;
                                numSmallBus = (int)Math.Ceiling(smallbusraw);
                            }
                            else
                            {
                                //if below 38, only calculate number of 19 seaters
                                numSmallBus = (int)Math.Ceiling(numPeople / 19);
                            }
                            arrivals.number42seat = numBigBus;
                            arrivals.number19seat = numSmallBus;
                            arrivals.numberCompetitors = (int)competitors_updown.Value;
                            arrivals.numberHead = (int)head_updown.Value;
                            arrivals.numberDelegate = (int)delegates_updown.Value;
                            booking.numDoubleRoomsRequired = dgvlist[1].NewNoOfRoomsRequired;
                            booking.numSingleRoomsRequired = dgvlist[0].NewNoOfRoomsRequired;
                            db.SaveChanges();
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

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshDGV();
        }
    }
    public class UpdateTable
    {
        public string RoomType { get; set; }
        public int RoomRatePerNight { get; set; }
        public int AvailableNoOfRooms { get; set; }
        public int RoomsBooked { get; set; }
        public int NewNoOfRoomsRequired { get; set; }
        public int SubTotal { get; set; }
    }
}
