using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Patient_Management_System_for_Doctors.Presentation_Layer
{
    public partial class CheckPreviousPrescription : Form
    {
        int PatientId;

        public CheckPreviousPrescription()
        {
            InitializeComponent();
        }
        public CheckPreviousPrescription(int PatientId)
        {
            this.PatientId = PatientId;
            InitializeComponent();
        }

        private void CheckPreviousPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckPatient checkPatient = new CheckPatient(this.PatientId);
            checkPatient.Show();
            this.Hide();
        }
    }
}
