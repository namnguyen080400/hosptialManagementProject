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
    public partial class PatientHomepageForm : Form
    {
        int loginId;
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
    }
}
