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
    public partial class MainMenu : Form
    {
        User loggedIn;
        public MainMenu(User user)
        {
            loggedIn = user;
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
            if (user.userTypeIdFK == 1)
            {
                menu_label.Text = "Administrator Main Menu";
                arrival_button.Text = "Arrival Summary";
                hotel_button.Text = "Hotel Summary";
                booking_or_guests.Text = "Guests Summary";
            }
            else
            {
                menu_label.Text = "Country Representative Main Menu";
                arrival_button.Text = "Confirm Arrival Details";
                hotel_button.Text = "Hotel Booking";
                booking_or_guests.Text = "Update Info/ Booking";
            }
        }

        private void arrival_button_Click(object sender, EventArgs e)
        {
            if(loggedIn.userTypeIdFK == 2)
            {
                this.Hide();
                var form = new ConfirmArrival(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                this.Hide();
                var form = new ArrivalSummary(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void hotel_button_Click(object sender, EventArgs e)
        {
            if(loggedIn.userTypeIdFK == 2)
            {
                this.Hide();
                var form = new HotelSelection(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                this.Hide();
                var form = new HotelSummary(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void booking_or_guests_Click(object sender, EventArgs e)
        {
            if (loggedIn.userTypeIdFK == 2)
            {
                this.Hide();
                var form = new HotelUpdate(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                this.Hide();
                var form = new GuestSummary(loggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Menu_label_Click(object sender, EventArgs e)
        {

        }
    }
}
