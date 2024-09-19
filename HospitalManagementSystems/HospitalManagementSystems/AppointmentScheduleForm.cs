using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagementSystems
{
    public partial class AppointmentScheduleForm : Form
    {
        int patientId;
        int doctorId;
        public AppointmentScheduleForm(int patientId, int doctorId)
        {
            InitializeComponent();
            loadUpcomingVisit();
            loadPastVisit();

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

            string[] visitType = { "Select Visit", "Annual physical", "Non-urgent problem", 
                                "Follow up", "Screening", "Diagnostic", "Psychiatric" };
            comboBoxVisitType.DataSource = visitType;
        }

        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();
        
        private void loadUpcomingVisit()
        {
            var upcomingVisit = from currentVisit in hospitalContext.UpcomingVisits                    
                                select new
                                {
                                    PatientId = $"{currentVisit.PatientId}",
                                    UpcomingVisitDate = $"{currentVisit.UpcomingVisitDate}",
                                    VisitType = $"{currentVisit.VisitType}",
                                    DoctorName = $"{currentVisit.DoctorName}",
                                    VisitLocation = $"{currentVisit.VisitLocation}"
                                };
            dataGridViewUpcomingVisit.DataSource = upcomingVisit.ToList();
        }

        private void loadPastVisit()
        {
           var afterVisit = from pastVisit in hospitalContext.PastVisits
                                select new
                                {
                                    PatientId = $"{pastVisit.PatientId}",
                                    UpcomingVisitDate = $"{pastVisit.PastVisitDate}",
                                    VisitType = $"{pastVisit.VisitType}",
                                    DoctorName = $"{pastVisit.DoctorName}",
                                    VisitLocation = $"{pastVisit.VisitLocation}",
                                    VisitSummary = $"{pastVisit.VisitSummary}"
                                };
           dataGridViewPastVisit.DataSource = afterVisit.ToList();
        }
        
        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {
            string selectDoctor = comboBoxSearchDoctor.SelectedValue.ToString();
            DateTime appointmentDate = monthCalendarUpcomingVisitDate.SelectionStart;

            var getAllInfo = from loginId in hospitalContext.Logins
                             join people in hospitalContext.Peoples
                             on loginId.LoginId equals people.LoginId
                             join patient in hospitalContext.Patients
                             on loginId.LoginId equals patient.LoginId
                             join address in hospitalContext.AddressNames
                             on people.AddressId equals address.AddressId
                             join doctor in hospitalContext.Doctors
                             on people.UserId equals doctor.UserId
                             select new
                             {
                                 PatientId = $"{patient.PatientId}",
                                 Username = $"{loginId.Username}",
                                 Firstname = $"{people.FirstName}",
                                 Lastname = $"{people.LastName}",
                                 DateOfBirth = $"{people.DateOfBirth}",
                                 Gender = $"{people.Gender}",
                                 Ethnicity = $"{people.Ethnicity}"
                             };


            var upcomingAppointment = new UpcomingVisit
            {
                UpcomingVisitDate = monthCalendarUpcomingVisitDate.SelectionStart,
                VisitType = comboBoxVisitType.SelectedValue.ToString(),
                DoctorName = comboBoxSearchDoctor.SelectedValue.ToString(),

            };

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HosptialMainPage hosptialMainPage = new HosptialMainPage();
            hosptialMainPage.Show();
            this.Close();
        }
    }
}
