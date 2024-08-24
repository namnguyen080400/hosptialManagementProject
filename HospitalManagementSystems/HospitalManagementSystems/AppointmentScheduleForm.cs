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

        private void buttonSearchPatients_Click(object sender, EventArgs e)
        {
            var queries = from people in hospitalContext.Peoples
                          join contactInfo in hospitalContext.ContactInfos
                          on people.AddressId equals contactInfo.AddressId
                          where people.RoleId == 1
                          select new
                          {
                              FirstName = $"{people.FirstName}",
                              LastName = $"{people.LastName}",
                              DateOfBirth = $"{people.DateOfBirth}",
                              HomePhone = $"{contactInfo.HomePhone}",
                              MobilePhone = $"{contactInfo.MobilePhone}"
                          };

            dataGridView1.DataSource = queries.ToList();
        }

        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}
