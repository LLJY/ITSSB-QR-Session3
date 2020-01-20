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
    public partial class HotelSummary : Form
    {
        User LoggedIn;
        public HotelSummary(User user)
        {
            LoggedIn = user;
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
        }
        private void UpdateUI(int id)
        {
            var dgvlist = new List<SummaryHotel>();
            using (var db = new Session3Entities())
            {
                var hotel = (from h in db.Hotels
                             where h.hotelId == id
                             select h.hotelName).First();
                var bookings = (from b in db.Hotel_Booking
                                where b.hotelIdFK == id
                                select b);
                foreach (var item in bookings)
                {
                    var sh = new SummaryHotel()
                    {
                        Country = item.User.countryName,
                        NoOfDoubleRoomsBooked = item.numDoubleRoomsRequired,
                        NoOfSingleRoomsBooked = item.numSingleRoomsRequired
                    };
                    dgvlist.Add(sh);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dgvlist;
                hotelname_label.Text = hotel;
            }
        }
        private void Ritz_button_Click(object sender, EventArgs e)
        {
            UpdateUI(1);
        }

        private void Pan_pacific_button_Click(object sender, EventArgs e)
        {
            UpdateUI(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateUI(3);
        }
        private void Intercontinental_button_Click(object sender, EventArgs e)
        {
            UpdateUI(4);
        }
        private void Grand_pacific_button_Click(object sender, EventArgs e)
        {
            UpdateUI(5);
        }

        private void Queens_hotel_button_Click(object sender, EventArgs e)
        {
            UpdateUI(6);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
    public class SummaryHotel
    {
        public string Country { get; set; }
        public int NoOfSingleRoomsBooked { get; set; }
        public int NoOfDoubleRoomsBooked { get; set; }
    }
}
