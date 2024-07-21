using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystems
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var query = from login in hospitalContext.Logins
                        where login.Username == username && login.Passwords == password
                        select new
                        {
                            Username = $"{login.Username}",
                            Passwords = $"{login.Passwords}"
                        };
            if (query.Count() > 0)
            {

            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }
    }
}
