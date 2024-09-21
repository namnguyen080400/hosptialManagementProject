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
    public partial class PatientHomepageForm : Form
    {
        int loginId;
        HospitalDataDataContext hospitalContext = new HospitalDataDataContext();
        public PatientHomepageForm(int loginId)
        {
            InitializeComponent();
            this.loginId = loginId;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void buttonVisit_Click(object sender, EventArgs e)
        {
            VisitForm visitForm = new VisitForm();
            visitForm.Show();
            this.Close();
        }

        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {
            var queriesPatientDoctorId = from patient in hospitalContext.Patients
                                         where patient.LoginId == loginId
                                select new
                                {
                                    DoctorId = $"{patient.DoctorId}",
                                    PatientId = $"{patient.PatientId}"
                                };
            if (queriesPatientDoctorId.ToList().Count() > 0 )
            {
                int patientId = Int32.Parse(queriesPatientDoctorId.ToList()[0].PatientId);
                int doctorId = Int32.Parse(queriesPatientDoctorId.ToList()[0].DoctorId);
                AppointmentScheduleForm appointmentScheduleForm = new AppointmentScheduleForm(patientId, doctorId);
                appointmentScheduleForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("COULD NOT FIND PATIENT!!! STOP TO DEBUG");
            }
        }
    }
}
