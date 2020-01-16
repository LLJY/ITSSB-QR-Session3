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
    public partial class ArrivalSummary : Form
    {
        List<int> jul22blacklist;
        List<int> jul23blacklist;
        User LoggedIn;
        public ArrivalSummary(User user)
        {
            LoggedIn = user;
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
            InitializeComponent();
            InitializeDGV();
            GetData();
        }
        private void InitializeDGV()
        {
            july22_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            july23_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            july22_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            july23_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            july22_dgv.Columns.Clear();
            july22_dgv.Rows.Clear();
            july22_dgv.Columns.Add("9am", "9am");
            july22_dgv.Columns.Add("10am", "10am");
            july22_dgv.Columns.Add("11am", "11am");
            july22_dgv.Columns.Add("12pm", "12pm");
            july22_dgv.Columns.Add("1pm", "1pm");
            july22_dgv.Columns.Add("2pm", "2pm");
            july22_dgv.Columns.Add("3pm", "3pm");
            july22_dgv.Columns.Add("4pm", "4pm");
            july22_dgv.ColumnHeadersVisible = false;
            july22_dgv.Rows.Add("9am", "10am", "11am", "12pm", "1pm", "2pm", "3pm", "4pm");
            july22_dgv.ScrollBars = ScrollBars.None;
            july22_dgv.ReadOnly = true;
            july23_dgv.Columns.Clear();
            july23_dgv.Rows.Clear();
            july23_dgv.Columns.Add("9am", "9am");
            july23_dgv.Columns.Add("10am", "10am");
            july23_dgv.Columns.Add("11am", "11am");
            july23_dgv.Columns.Add("12pm", "12pm");
            july23_dgv.Columns.Add("1pm", "1pm");
            july23_dgv.Columns.Add("2pm", "2pm");
            july23_dgv.Columns.Add("3pm", "3pm");
            july23_dgv.Columns.Add("4pm", "4pm");
            july23_dgv.ColumnHeadersVisible = false;
            july23_dgv.Rows.Add("9am", "10am", "11am", "12pm", "1pm", "2pm", "3pm", "4pm");
            july23_dgv.ScrollBars = ScrollBars.None;
            july23_dgv.ReadOnly = true;
            foreach (DataGridViewColumn item in july22_dgv.Columns)
            {
                item.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            foreach (DataGridViewColumn item in july23_dgv.Columns)
            {
                item.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            foreach (var item in jul22blacklist)
            {
                july22_dgv.Rows[0].Cells[item].Style.BackColor = Color.Black;
            }
            foreach (var item in jul23blacklist)
            {
                july23_dgv.Rows[0].Cells[item].Style.BackColor = Color.Black;
            }
        }
        private void GetData()
        {
            using(var db = new Session3Entities())
            {
                var jul22 = DateTime.Parse("Jul 22 2020");
                var jul23 = DateTime.Parse("Jul 23 2020");
                var arrival = (from a in db.Arrivals
                               where a.arrivalTime == "9am"
                               where a.arrivalDate == jul22
                               select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "10am"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "11am"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "12pm"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "1pm"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "2pm"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "3pm"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "4pm"
                           where a.arrivalDate == jul22
                           select a);
                foreach (var item in arrival)
                {
                    july22_dgv.Rows[0].Cells[0].Value = $"\n\n{july22_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "9am"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "10am"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "11am"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "12pm"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "1pm"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "2pm"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "3pm"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }
                arrival = (from a in db.Arrivals
                           where a.arrivalTime == "4pm"
                           where a.arrivalDate == jul23
                           select a);
                foreach (var item in arrival)
                {
                    july23_dgv.Rows[0].Cells[0].Value = $"\n\n{july23_dgv.Rows[0].Cells[0].Value.ToString()}\n{item.User.countryName}\n({item.number42seat + item.number19seat}veh)";
                }

            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
