using Personal_Patient_Management_System_for_Doctors.Data_Access_Layer;
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
    public partial class AssistantMenu : Form
    {
        public AssistantMenu()
        {
            InitializeComponent();
        }

        private void AssistantMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AssistantMenu_Load(object sender, EventArgs e)
        {
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            PatientListGridView.DataSource = patientDetailsDataAccess.GetPatients();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateHealthRecord updateHealthRecord = new UpdateHealthRecord();
            updateHealthRecord.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdatePatient updatePatient = new UpdatePatient();
            updatePatient.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DeletePatient deletePatient = new DeletePatient();
            deletePatient.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            AddHealthRecord addHealthRecord = new AddHealthRecord();
            addHealthRecord.Show();
            this.Hide();
        }
    }
}
