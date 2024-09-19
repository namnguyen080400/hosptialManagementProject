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
            var queriesPatientDoctorId = from people in hospitalContext.Peoples
                                         join doctor in hospitalContext.Doctors
                                         on people.UserId equals doctor.UserId
                                         join login in hospitalContext.Logins
                                         on 
                                         

                                select new
                                {
                    
                                };
            AppointmentScheduleForm appointmentScheduleForm = new AppointmentScheduleForm();
            appointmentScheduleForm.Show();
            this.Close();
        }
    }
}
