using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            Initialize();
        }
        public async void Initialize()
        {
            InitializeComponent();
            var combolist = new List<string>();
            combolist.Add("Brunei");
            combolist.Add("Cambodia");
            combolist.Add("Indonesia");
            combolist.Add("Laos");
            combolist.Add("Malaysia");
            combolist.Add("Myanmar");
            combolist.Add("Phillipines");
            combolist.Add("Singapore");
            combolist.Add("Thailand");
            combolist.Add("Vietnam");
            using (var db = new Session3Entities())
            {
                var existing = (from a in db.Users
                                select a.countryName).ToList();
                foreach (var item in existing)
                {
                    if (combolist.Contains(item))
                    {
                        combolist.Remove(item);
                    }
                }
            }
            country_combo.DataSource = combolist;
        }

        private async void create_account_box_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (user_box.Text.Length >= 8)
            {
                using (var db = new Session3Entities())
                {
                    if (regexItem.IsMatch(user_box.Text))
                    {
                        if (!(from a in db.Users select a.userId).ToList().Contains(user_box.Text))
                        {
                            if (password_box.Text == password_again_box.Text)
                            {
                                User user = new User()
                                {
                                    userId = user_box.Text,
                                    countryName = country_combo.Text,
                                    passwd = password_box.Text,
                                    userTypeIdFK = 2
                                };
                                db.Users.Add(user);
                                await db.SaveChangesAsync();
                                button2_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("userid already exists!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User ID cannot contain special characters");
                    }
                }
            }
            else
            {
                MessageBox.Show("UserID must have 8 or more characters!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
