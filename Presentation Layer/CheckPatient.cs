using Personal_Patient_Management_System_for_Doctors.Data_Access_Layer;
using Personal_Patient_Management_System_for_Doctors.Entities;
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
    public partial class CheckPatient : Form
    {
        int PatientId;
        public CheckPatient()
        {
            InitializeComponent();
        }

        public CheckPatient(int PatientId)
        {
            this.PatientId = PatientId;
            InitializeComponent();
        }

        private void CheckPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DoctorMenu doctorMenu = new DoctorMenu();
            doctorMenu.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddPrescription addPrescription = new AddPrescription(this.PatientId);
            addPrescription.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PrescribeTest prescribeTest = new PrescribeTest(this.PatientId);
            prescribeTest.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckPreviousPrescription checkPreviousPrescription = new CheckPreviousPrescription(this.PatientId);
            checkPreviousPrescription.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CheckHealthRecord checkHealthRecord = new CheckHealthRecord(this.PatientId);
            checkHealthRecord.Show();
            this.Hide();
        }

        private void CheckPatient_Load(object sender, EventArgs e)
        {


            PatientDetails patientDetails = new PatientDetails();
            PatientDetailsDataAccess patientDetailsDataAccess = new PatientDetailsDataAccess();
            patientDetails = patientDetailsDataAccess.GetPatient(this.PatientId);

            nameTextBox.Text = patientDetails.PatientName;
            addressTextBox.Text = patientDetails.PatientAddress;
            heightTextBox.Text = patientDetails.PatientHeight.ToString();
            weightTextBox.Text = patientDetails.PatientWeight.ToString();
            emailTextBox.Text = patientDetails.PatientEmail;
            dateOfBirthDateTime.Text = patientDetails.PatientDateOfBirth ;
            bloodGroupComboBox.Text = patientDetails.PatientBloodGroup ;
            genderTextBox.Text = patientDetails.PatientGender;
        }
    }
}
