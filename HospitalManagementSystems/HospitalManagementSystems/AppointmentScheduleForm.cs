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

            var queriesDoctor = from people in hospitalContext.Peoples
                          where people.RoleId == 2
                          select new
                          {
                              FirstName = $"{people.FirstName}",
                              LastName = $"{people.LastName}"
                          };
            List<string> doctors = new List<string>();
            doctors.Add("Select doctor");
            foreach (var doctor in queriesDoctor)
            {
                doctors.Add(doctor.FirstName + " " + doctor.LastName);
            }
            comboBoxSearchDoctor.DataSource = doctors;
            comboBoxSearchDoctor.SelectedIndex = 0;
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

        private void comboBoxSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchCriteria.SelectedIndex == 0)
            {
                labelCriteria.Text = "All patients";
                textBoxSearchCriteria.Text = "*";
            }
            else if (comboBoxSearchCriteria.SelectedIndex == 1)
            {
                labelCriteria.Text = "First name";
            }
            else if (comboBoxSearchCriteria.SelectedIndex == 2)
            {
                labelCriteria.Text = "Last name";
            }
            else if (comboBoxSearchCriteria.SelectedIndex == 3)
            {
                labelCriteria.Text = "Textbox not use";
            }
            else if (comboBoxSearchCriteria.SelectedIndex == 4)
            {
                labelCriteria.Text = "Home phone";
            }
            else if (comboBoxSearchCriteria.SelectedIndex == 5)
            {
                labelCriteria.Text = "Mobile Phone";
            }
        }
    }
}
