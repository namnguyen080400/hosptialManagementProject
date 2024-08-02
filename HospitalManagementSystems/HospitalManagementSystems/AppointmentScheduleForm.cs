﻿using System;
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
    public partial class AppointmentScheduleForm : Form
    {
        public AppointmentScheduleForm()
        {
            InitializeComponent();

            string[] searchCriteria = { "All Patient", "First name", "Last name", "Date of birth", "Home phone", "Mobile Phone" };
            comboBoxSearchCriteria.DataSource = searchCriteria;
            comboBoxSearchCriteria.SelectedIndex = 0;
        }

        private void buttonScheduleAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}