using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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

            this.patientId = patientId;
            this.doctorId = doctorId;

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

            var queriesDoctorAddress = from people in hospitalContext.Peoples
                                   join doctor in hospitalContext.Doctors
                                   on people.LoginId equals doctor.LoginId
                                   join address in hospitalContext.AddressNames
                                   on people.AddressId equals address.AddressId
                                   where doctor.DoctorId == doctorId
                                   select new
                                   {
                                       Numbers = $"{address.Number}",
                                       Street = $"{address.Street}",
                                       City = $"{address.City}",
                                       StateName = $"{address.StateName}",
                                       ZipCode = $"{address.ZipCode}"
                                   };
            string doctorAddress = "";

            foreach(var address in queriesDoctorAddress)
            {
                doctorAddress += address.Numbers + " " + address.Street + " " + 
                    address.City + ", " + address.StateName + " " + address.ZipCode;
            }

            var upcomingAppointment = new UpcomingVisit
            {
                PatientId = patientId,
                UpcomingVisitDate = monthCalendarUpcomingVisitDate.SelectionStart,
                VisitType = comboBoxVisitType.SelectedValue.ToString(),
                DoctorName = comboBoxSearchDoctor.SelectedValue.ToString(),
                VisitLocation = doctorAddress
            };
            dataGridViewUpcomingVisit.DataSource = upcomingAppointment.ToString().ToList();
            hospitalContext.UpcomingVisits.InsertOnSubmit(upcomingAppointment);
            hospitalContext.SubmitChanges();
            MessageBox.Show("Schedule appointment success");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            HosptialMainPage hosptialMainPage = new HosptialMainPage();
            hosptialMainPage.Show();
            this.Close();
        }

        private void buttonLoadUpcomingVisit_Click(object sender, EventArgs e)
        {
            loadUpcomingVisit();
        }

        private void buttonLoadPastVisit_Click(object sender, EventArgs e)
        {
            loadPastVisit();
        }
    }
}
