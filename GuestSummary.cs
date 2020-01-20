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
    public partial class GuestSummary : Form
    {
        User LoggedIn;
        public GuestSummary(User user)
        {
            LoggedIn = user;
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd'/'MM'/'yy");
            guests_combo.Items.Add("All");
            guests_combo.Items.Add("Delegates");
            guests_combo.Items.Add("Competitors");
        }
        private void UpdateUI()
        {
            using (var db = new Session3Entities())
            {
                chart1.Series.Clear();
                if (guests_combo.SelectedItem.ToString().Equals("All"))
                {
                    chart1.Series.Add("Competitors");
                    chart1.Series.Add("Delegates");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                    var arrivals = (from d in db.Arrivals
                                    group d by new { d.User.countryName } into u
                                    select new
                                    {
                                        u.Key.countryName,
                                        TotalDelegates = u.Sum(a => a.numberDelegate + a.numberHead),
                                        TotalCompetitors = u.Sum(a => a.numberCompetitors)
                                    });

                    foreach (var item in arrivals)
                    {
                        chart1.Series["Competitors"].Points.AddXY(item.countryName, item.TotalCompetitors);
                        chart1.Series["Delegates"].Points.AddXY(item.countryName, item.TotalDelegates);
                    }
                }
                else if (guests_combo.SelectedItem.ToString().Equals("Delegates"))
                {
                    chart1.Series.Add("Delegates");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                    var arrivals = (from d in db.Arrivals
                                    group d by new { d.User.countryName } into u
                                    select new
                                    {
                                        u.Key.countryName,
                                        TotalCompetitors = u.Sum(a => a.numberCompetitors)
                                    });

                    foreach (var item in arrivals)
                    {
                        chart1.Series["Delegates"].Points.AddXY(item.countryName, item.TotalCompetitors);
                    }
                }
                else if (guests_combo.SelectedItem.ToString().Equals("Competitors"))
                {
                    chart1.Series.Add("Competitors");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                    var arrivals = (from d in db.Arrivals
                                    group d by new { d.User.countryName } into u
                                    select new
                                    {
                                        u.Key.countryName,
                                        TotalCompetitors = u.Sum(a => a.numberCompetitors)
                                    });
                    foreach (var item in arrivals)
                    {
                        chart1.Series["Competitors"].Points.AddXY(item.countryName, item.TotalCompetitors);
                    }
                }
            }
        }
        private void Guests_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedIn);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
