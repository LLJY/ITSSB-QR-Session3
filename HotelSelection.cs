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
    public partial class HotelSelection : Form
    {
        public User LoggedIn;
        public HotelSelection(User user)
        {
            LoggedIn = user;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ritz_button_Click(object sender, EventArgs e)
        {
            //id 1
            var hotel = new HotelBooking(LoggedIn, 1, "Ritz Carlton");
            hotel.Show();
        }
        private void pan_pacific_Click(object sender, EventArgs e)
        {
            //id 2
            var hotel = new HotelBooking(LoggedIn, 2, "Pan Pacific");
            hotel.Show();
        }
        private void charlton_Click(object sender, EventArgs e)
        {

            //id 3
            var hotel = new HotelBooking(LoggedIn, 3, "Charlton Hotel");
            hotel.Show();
        }

        private void intercontinental_button_Click(object sender, EventArgs e)
        {
            //id 4
            var hotel = new HotelBooking(LoggedIn, 4, "Intercontinental Hotel");
            hotel.Show();
        }
        private void grand_pacific_button_Click(object sender, EventArgs e)
        {
            //id 5
            var hotel = new HotelBooking(LoggedIn, 5, "Hotel Grand Pacific");
            hotel.Show();
        }
        private void queens_hotel_Click(object sender, EventArgs e)
        {
            // id 6
            var hotel = new HotelBooking(LoggedIn, 6, "Hotel Royal Queens");
            hotel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
