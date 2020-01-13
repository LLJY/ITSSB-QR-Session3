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
    public partial class ConfirmArrival : Form
    {
        User LoggedIn;
        public ConfirmArrival(User user)
        {
            LoggedIn = user;
            InitializeComponent();
            arrival_combo.Items.Add("9am");
            arrival_combo.Items.Add("10am");
            arrival_combo.Items.Add("11am");
            arrival_combo.Items.Add("12am");
            arrival_combo.Items.Add("1pm");
            arrival_combo.Items.Add("2pm");
            arrival_combo.Items.Add("3pm");
            arrival_combo.Items.Add("4pm");
        }

        private void jul22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jul23_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkedchanged()
        {
            if (jul22.Checked)
            {
                arrival_combo.Items.Clear();
                arrival_combo.Items.Add("9am");
                arrival_combo.Items.Add("11am");
                arrival_combo.Items.Add("12am");
                arrival_combo.Items.Add("3pm");
                arrival_combo.Items.Add("4pm");
                jul23.Checked = false;

            }
            else if (jul23.Checked)
            {
                arrival_combo.Items.Add("9am");
                arrival_combo.Items.Add("10am");
                arrival_combo.Items.Add("11am");
                arrival_combo.Items.Add("12am");
                arrival_combo.Items.Add("1pm");
                arrival_combo.Items.Add("2pm");
                arrival_combo.Items.Add("3pm");
                arrival_combo.Items.Add("4pm");
                jul22.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(del_combo.Value != 0)
            {
                if(comp_combo.Value != 0)
                {
                    using (var db = new Session3Entities())
                    {
                        Arrival an = new Arrival()
                        {
                            arrivalDate = jul22.Checked ? DateTime.Parse("Jul 22 2020") : DateTime.Parse("Jul 23 2020"),
                            arrivalId = (from a in db.Arrivals orderby a.arrivalId descending select a.arrivalId).First() + 1,
                            number19seat = 10,
                            number42seat = 10,
                            numberCars = (int)head_combo.Value,
                            numberCompetitors = (int)comp_combo.Value,
                            numberDelegate = (int)del_combo.Value,
                            userIdFK = LoggedIn.userId,
                            arrivalTime = "9am",
                            numberHead = (int)head_combo.Value
                        };
                        db.Arrivals.Add(an);
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Number of competitors must be > 0!!");
                }
            }
            else
            {
                MessageBox.Show("Number of delegates must be > 0!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
