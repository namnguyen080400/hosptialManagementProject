using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystems
{
    public partial class AppointmentScheduleForm : Form
    {
        public AppointmentScheduleForm()
        {
            InitializeComponent();

            string[] searchCriteria = { "All Patient", "First name", "Last name", "Date of birth", "Home phone", "Mobile Phone" };
            comboBoxSearchCriteria.DataSource = searchCriteria;
            comboBoxSearchCriteria.SelectedIndex = 0;
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();

        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {
            var queries = from login in hospitalContext.Logins
                          join people in hospitalContext.Peoples
                          on login.LoginId equals people.LoginId
                          join role in hospitalContext.Roles
                          on people.RoleId equals role.RoleId
                          select new
                          {

                          };
        }
    }
}
