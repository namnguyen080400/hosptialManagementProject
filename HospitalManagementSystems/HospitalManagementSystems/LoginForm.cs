using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystems
{
    public partial class LoginForm : Form
    {
        const int PATIENT_ROLEID = 1;
        const int DOCTOR_ROLEID = 2;
        const int NURSE_ROLEID = 3;
        const int STAFF_ROLEID = 4;
        public LoginForm()
        {
            InitializeComponent();
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var queries = from login in hospitalContext.Logins
                        join people in hospitalContext.Peoples
                        on login.LoginId equals people.LoginId
                        join role in hospitalContext.Roles
                        on people.RoleId equals role.RoleId
                        where login.Username == username && login.Passwords == password
                        select new
                        {
                            loginId = login.LoginId,
                            roleId = role.RoleId
                        };

            if (queries.Count() > 0)
            {
                if (queries.ToList()[0].roleId == PATIENT_ROLEID)
                {
                    PatientHomepageForm patientPage = new PatientHomepageForm(queries.ToList()[0].loginId);
                    patientPage.Show(); 
                    this.Hide();
                }
                else
                {
                    HosptialMainPage hosptialMainPage = new HosptialMainPage();
                    hosptialMainPage.Show();
                    this.Hide();
                }
                
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            HospitalManagementHomepageForm hospitalManagementHomepage = new HospitalManagementHomepageForm();
            hospitalManagementHomepage.Show();
            this.Hide();
        }
    }
}
