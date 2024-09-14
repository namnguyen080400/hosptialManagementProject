using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystems
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static HosptialMainPage hosptialMainForm = null;
        public static PatientHomepageForm patientMainForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HospitalManagementHomepageForm());
            hosptialMainForm = new HosptialMainPage();

            int loginId = 0;
            patientMainForm = new PatientHomepageForm(loginId);
        }
    }
}
