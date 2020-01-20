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
        List<int> jul22blacklist;
        List<int> jul23blacklist;
        public ConfirmArrival(User user)
        {
            jul22blacklist = new List<int>
            {
                1,
                4,
                5
            };
            jul23blacklist = new List<int>
            {
                0,
                3,
                7
            };
            LoggedIn = user;
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
            jul22.Checked = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void jul22_CheckedChanged(object sender, EventArgs e)
        {
            checkedchanged();
        }

        private void jul23_CheckedChanged(object sender, EventArgs e)
        {
            checkedchanged();
        }
        private void checkedchanged()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("9am", "9am");
            dataGridView1.Columns.Add("10am", "10am");
            dataGridView1.Columns.Add("11am", "11am");
            dataGridView1.Columns.Add("12pm", "12pm");
            dataGridView1.Columns.Add("1pm", "1pm");
            dataGridView1.Columns.Add("2pm", "2pm");
            dataGridView1.Columns.Add("3pm", "3pm");
            dataGridView1.Columns.Add("4pm", "4pm");
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Rows.Add("9am", "10am", "11am", "12pm", "1pm", "2pm", "3pm", "4pm");
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.ReadOnly = true;
            if (jul22.Checked)
            {
                
                jul23.Checked = false;
                foreach (var item in jul22blacklist)
                {
                    dataGridView1.Rows[0].Cells[item].Style.BackColor = Color.Black;
                }

            }
            else if (jul23.Checked)
            {
               
                jul22.Checked = false;
                foreach (var item in jul23blacklist)
                {
                    dataGridView1.Rows[0].Cells[item].Style.BackColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTime = null;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if(dataGridView1.Rows[0].Cells[i].Style.BackColor == Color.Yellow)
                {
                    switch (i)
                    {
                        case 0:
                            selectedTime = "9am";
                            break;
                        case 1:
                            selectedTime = "10am";
                            break;
                        case 2:
                            selectedTime = "11am";
                            break;
                        case 3:
                            selectedTime = "12pm";
                            break;
                        case 4:
                            selectedTime = "1pm";
                            break;
                        case 5:
                            selectedTime = "2pm";
                            break;
                        case 6:
                            selectedTime = "3pm";
                            break;
                        case 7:
                            selectedTime = "4pm";
                            break;
                        default:
                            break;
                    }
                }
            }
            if (selectedTime != null)
            {
                if (delegates_updown.Value != 0)
                {
                    if (competitors_updown.Value != 0)
                    {
                        using (var db = new Session3Entities())
                        {
                            Arrival an = new Arrival()
                            {
                                arrivalDate = jul22.Checked ? DateTime.Parse("Jul 22 2020") : DateTime.Parse("Jul 23 2020"),
                                number19seat = int.Parse(bigbus_label.Text),
                                number42seat = int.Parse(smallbus_label.Text),
                                numberCars = (int)head_updown.Value,
                                numberCompetitors = (int)competitors_updown.Value,
                                numberDelegate = (int)delegates_updown.Value,
                                userIdFK = LoggedIn.userId,
                                arrivalTime = selectedTime,
                                numberHead = (int)head_updown.Value
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
            else
            {
                MessageBox.Show("Please Select a Valid Time!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Style.BackColor != Color.Black)
            {
                checkedchanged();
                dataGridView1.Rows[0].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Head_updown_ValueChanged(object sender, EventArgs e)
        {
            calculateVehicles();
        }

        private void Delegates_updown_ValueChanged(object sender, EventArgs e)
        {
            calculateVehicles();
        }

        private void Competitors_updown_ValueChanged(object sender, EventArgs e)
        {
            calculateVehicles();
        }
        private void calculateVehicles()
        {
            car_label.Text = head_updown.Value.ToString();
            int numSmallBus = 0;
            int numBigBus = 0;
            decimal numPeople = delegates_updown.Value + competitors_updown.Value;
            if(numPeople > 38)
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
                numSmallBus = (int) Math.Ceiling(numPeople / 19);
            }
            bigbus_label.Text = numBigBus.ToString();
            smallbus_label.Text = numSmallBus.ToString();
        }

        private void ConfirmArrival_Load(object sender, EventArgs e)
        {

        }
    }
}
