using System;
using System.Collections;
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
    public partial class VisitForm: Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }

        private void buttonLoadVisit_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Office Visit";

            ArrayList row = new ArrayList();
            row.Add("9/5/2024");
            dataGridView1.Rows.Add(row.ToArray());

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            dataGridView1.Columns.Add(link);
            link.HeaderText = "Link";
            link.Name = "https://mychartwa.providence.org/mychart/Visits";
            link.Text = "View After Visit Summary";
            link.UseColumnTextForLinkValue = true; 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AppointmentScheduleForm appointmentSchedule = new AppointmentScheduleForm();
            appointmentSchedule.Show();
            this.Close();
        }

        public void uploadFile(string file)
        {
    
        }
    }
}
