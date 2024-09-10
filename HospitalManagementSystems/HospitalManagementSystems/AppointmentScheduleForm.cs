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
        
        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HosptialMainPage hosptialMainPage = new HosptialMainPage();
            hosptialMainPage.Show();
            this.Close();
        }
    }
}
