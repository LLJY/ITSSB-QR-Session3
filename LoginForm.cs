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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(user_box.Text) && string.IsNullOrWhiteSpace(password_box.Text))){
                using (var db = new Session3Entities()) {
                    try
                    {
                        var user = (from a in db.Users
                                    where a.passwd == password_box.Text
                                    where a.userId == user_box.Text
                                    select a).First();
                        this.Hide();
                        var form = new MainMenu(user);
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Login");
                    }
                    }
            }
            else
            {
                MessageBox.Show("One or more fields are empty!!");
            }
        }

        private void create_acct_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CreateAccount();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
