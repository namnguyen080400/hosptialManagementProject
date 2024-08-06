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
    public partial class HosptialMainPage : Form
    {
        public HosptialMainPage()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LoginForm  loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonAppointmentScheduling_Click(object sender, EventArgs e)
        {
            AppointmentScheduleForm scheduleForm = new AppointmentScheduleForm();
            scheduleForm.Show();
            this.Hide();
        }
    }
}
